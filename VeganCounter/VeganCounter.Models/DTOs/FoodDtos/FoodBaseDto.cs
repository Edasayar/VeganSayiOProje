namespace VeganCounter.Models.DTOs.FoodDtos
{
    public class FoodBaseDto
    {
        public string FoodName { get; set; }
        public string CategoryId { get; set; }
        public double ProteinValue { get; set; }
        public double FatValue { get; set; }
        public double CarboValue { get; set; }
        public double Kcal { get; set; }
        public string Picture { get; set; }
    }
}
