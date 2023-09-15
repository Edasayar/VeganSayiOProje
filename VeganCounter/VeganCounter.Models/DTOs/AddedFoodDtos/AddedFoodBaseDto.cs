namespace VeganCounter.Models.DTOs.AddedFoodDtos
{
    public class AddedFoodBaseDto
    {
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public double CalculatedProtein { get; set; }
        public double CalculatedFat { get; set; }
        public double CalculatedCarbo { get; set; }
        public double CalculatedKcal { get; set; }
        public string Picture { get; set; }
    }
}
