using VeganCounter.Core.Enums;

namespace VeganCounter.Models.VMs.DailyMessageVMs
{
    public class DailyMessageVm
    {
        public string MessageText { get; set; }
        public State State { get; set; }
        public int Id { get; set; }
    }
}
