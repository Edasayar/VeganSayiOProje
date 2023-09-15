using VeganCounter.Core.Enums;

namespace VeganCounter.Models.DTOs.FoodDtos
{
    public class FoodUpdateDto : FoodBaseDto
    {
        public int Id { get; set; }
        public string UpdatedBy { get; set; }
        public State State => State.Updated;
        public DateTime UpdateDate => DateTime.Now;
    }
}
