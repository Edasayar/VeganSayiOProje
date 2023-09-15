using VeganCounter.Core.Enums;

namespace VeganCounter.Models.DTOs.DailyMessageDtos
{
    public class DailyMessageBaseDto
    {
        public string MessageText { get; set; }
        public State State { get; set; }
        public int Id { get; set; }
    }
}
