namespace VeganCounter.Models.VMs.AdminVMs
{
    public class AdminBaseVm
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
