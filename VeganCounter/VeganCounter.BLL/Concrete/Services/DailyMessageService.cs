using AutoMapper;
using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.Core.Enums;
using VeganCounter.DAL.Abstract;
using VeganCounter.Entities;
using VeganCounter.Models.DTOs.DailyMessageDtos;
using VeganCounter.Models.VMs.DailyMessageVMs;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Concrete.Services
{
    public class DailyMessageService : IDailyMessageService
    {
        private readonly IDailyMessageRepo _dailyMessageRepo;
        private readonly IMapper _mapper;

        public DailyMessageService(IMapper mapper, IDailyMessageRepo dailyMessageRepo)
        {
            _dailyMessageRepo = dailyMessageRepo;
            _mapper = mapper;
        }

        public bool IsExistPlak(string message)
        {
            return _dailyMessageRepo.Any(x => x.MessageText.Equals(message));
        }


        public ResultService<DailyMessageCreateDto> Create(DailyMessageCreateVm createVm)
        {
            ResultService<DailyMessageCreateDto> result = new ResultService<DailyMessageCreateDto>();
            DailyMessageCreateDto creatDto = _mapper.Map<DailyMessageCreateDto>(createVm);

            DailyMessage newDailyMessage = _mapper.Map<DailyMessage>(creatDto);
            var addedMessage = _dailyMessageRepo.Create(newDailyMessage);

            if (addedMessage != null)
            {
                result.Data = creatDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public ResultService<List<DailyMessageVm>> GetAll()
        {
            ResultService<List<DailyMessageVm>> result = new ResultService<List<DailyMessageVm>>();

            var messagess = _dailyMessageRepo.GetFilteredList(select: x => new DailyMessageVm
            {
                MessageText = x.MessageText,
                Id = x.Id
            }, where: x => x.State != State.Deleted);

            if (messagess != null)
            {
                result.Data = messagess.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }

        public bool Delete(int id)
        {
            DailyMessage dailyMessage = _dailyMessageRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if (dailyMessage != null)
            {
                return _dailyMessageRepo.Delete(dailyMessage);
            }

            return false;
        }

        public ResultService<DailyMessageUpdateDto> Update(DailyMessageUpdateVm updateVm)
        {
            ResultService<DailyMessageUpdateDto> result = new ResultService<DailyMessageUpdateDto>();

            var updateDto = _mapper.Map<DailyMessageUpdateDto>(updateVm);
            var data = _mapper.Map<DailyMessage>(updateDto);

            var updateData = _dailyMessageRepo.Update(data);

            if (updateData != null)
            {
                result.Data = updateDto;
            }
            else
            {
                result.AddError(ErrorType.ServerError, "Güncelleme işlemi başarısız");
            }

            return result;
        }
    }
}
