using VeganCounter.Core.Enums;

namespace VeganCounter.Models.DTOs.FoodDtos
{
    public class FoodCreateDto : FoodBaseDto
    {
        public string CreatedBy { get; set; }
        public State State => State.Created;
        public DateTime CreateDate => DateTime.Now;
    }
}
