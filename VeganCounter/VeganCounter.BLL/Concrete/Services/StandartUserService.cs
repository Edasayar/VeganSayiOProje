using AutoMapper;
using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.Core.Enums;
using VeganCounter.DAL.Abstract;
using VeganCounter.DAL.Concrete.Repositories;
using VeganCounter.Entities;
using VeganCounter.Models.VMs.LoginVms;
using VeganCounter.Models.VMs.StandartUserVMs;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Concrete.Services
{
    public class StandartUserService : IStandartUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public StandartUserService(IUserRepo userRepo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        public bool Delete(int id)
        {
            User user = _userRepo.GetFirstOrDefault(filter: x => x.Id == id);

            if (user != null)
            {
                return _userRepo.Delete(user);
            }

            return false;
        }

        public ResultService<List<StandartUserBaseVm>> GetAll()
        {
            ResultService<List<StandartUserBaseVm>> result = new ResultService<List<StandartUserBaseVm>>();

            var standarUser = _userRepo.GetFilteredList(select: x => new StandartUserBaseVm
            {
                UserName = x.UserName,
                Email = x.Email,
                BirthDay = x.BirthDay,
                Gender = x.Gender,
                State = x.State,
                Id = x.Id
            }, where: x => x.State != State.Deleted);

            if (standarUser != null)
            {
                result.Data = standarUser.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }

        public ResultService<LoginVm> Login(string email, string password)
        {
            ResultService<LoginVm> result = new ResultService<LoginVm>();

            var standartUser = _userRepo.GetFirstOrDefault(filter: x => x.Email.Equals(email) && x.Password.Equals(password));

            if (standartUser != null)
            {
                var logged = new LoginVm { Email = email, Password = password, Role = standartUser.Role };
                result.Data = logged;
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Kullanıcı Bulunamadı");
            }

            return result;
        }
    }
}
