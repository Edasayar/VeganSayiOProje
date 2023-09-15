using VeganCounter.Core.Enums;

namespace VeganCounter.Models.DTOs.DailyMessageDtos
{
    public class DailyMessageCreateDto
    {
        public string MessageText { get; set; }
        public string CreatedBy { get; set; }
        public State State => State.Created;
        public DateTime CreateDate => DateTime.Now;
    }
}
