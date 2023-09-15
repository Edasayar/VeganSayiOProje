using VeganCounter.Core.Enums;

namespace VeganCounter.Models.DTOs.AddedFoodDtos
{
    public class AddedFoodCreateDto : AddedFoodBaseDto
    {
        public string CreatedBy { get; set; }
        public State State => State.Created;
        public DateTime CreateDate => DateTime.Now;
    }
}
