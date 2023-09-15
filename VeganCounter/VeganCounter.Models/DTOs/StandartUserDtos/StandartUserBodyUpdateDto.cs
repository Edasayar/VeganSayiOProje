namespace VeganCounter.Models.DTOs.StandartUserDtos
{
    public class StandartUserBodyUpdateDto : StandartUserBaseDto
    {
        public int Id { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
