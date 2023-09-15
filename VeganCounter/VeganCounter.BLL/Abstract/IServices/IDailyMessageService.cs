using VeganCounter.Models.DTOs.DailyMessageDtos;
using VeganCounter.Models.VMs.DailyMessageVMs;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Abstract.IServices
{
    public interface IDailyMessageService
    {
        bool IsExistPlak(string message);
        ResultService<DailyMessageCreateDto> Create(DailyMessageCreateVm createVm);
        ResultService<List<DailyMessageVm>> GetAll();
        bool Delete(int id);
        ResultService<DailyMessageUpdateDto> Update(DailyMessageUpdateVm updateVm);
    }
}
