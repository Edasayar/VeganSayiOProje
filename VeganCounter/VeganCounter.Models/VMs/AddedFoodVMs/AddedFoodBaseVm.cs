namespace VeganCounter.Models.VMs.AddedFoodVMs
{
    public class AddedFoodBaseVm
    {
        public string Meal { get; set; }
        public string Category { get; set; }
        public string FoodName { get; set; }
        public double CalculatedProtein { get; set; }
        public double CalculatedFat { get; set; }
        public double CalculatedCarbo { get; set; }
        public double CalculatedKcal { get; set; }
    }
}
