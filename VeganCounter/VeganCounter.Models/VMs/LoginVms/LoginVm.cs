using VeganCounter.Core.Enums;

namespace VeganCounter.Models.VMs.LoginVms
{
    public class LoginVm
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
