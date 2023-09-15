using VeganCounter.Models.VMs.LoginVms;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Abstract.IServices
{
    public interface IAdminService
    {
        ResultService<LoginVm> Login(string email, string password);
    }
}
