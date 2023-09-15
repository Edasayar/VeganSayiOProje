using VeganCounter.Core.Enums;

namespace VeganCounter.Models.DTOs.DailyMessageDtos
{
    public class DailyMessageUpdateDto : DailyMessageBaseDto
    {
        public int Id { get; set; }
        public string UpdatedBy { get; set; }
        public State State => State.Updated;
        public DateTime UpdateDate => DateTime.Now;
    }
}
