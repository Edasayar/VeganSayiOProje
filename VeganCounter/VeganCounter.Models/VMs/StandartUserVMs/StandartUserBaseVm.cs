using VeganCounter.Core.Enums;

namespace VeganCounter.Models.VMs.StandartUserVMs
{
    public class StandartUserBaseVm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public int Id { get; set; }
        public State State { get; set; }
    }
}