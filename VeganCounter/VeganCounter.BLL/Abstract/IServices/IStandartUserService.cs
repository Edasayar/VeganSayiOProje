using VeganCounter.Models.VMs.LoginVms;
using VeganCounter.Models.VMs.StandartUserVMs;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Abstract.IServices
{
    public interface IStandartUserService
    {
        ResultService<LoginVm> Login(string email, string password);
        ResultService<List<StandartUserBaseVm>> GetAll();
        bool Delete(int id);
    }
}
