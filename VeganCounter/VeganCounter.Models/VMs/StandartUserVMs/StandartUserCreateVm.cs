namespace VeganCounter.Models.VMs.StandartUserVMs
{
    public class StandartUserCreateVm : StandartUserBaseVm
    {
        public DateTime CreatedDate => DateTime.Now;
    }
}
