namespace VeganCounter.Models.VMs.FoodVMs
{
    public class FoodDetailVm : FoodBaseVm
    {
        public double ProteinValue { get; set; }
        public double FatValue { get; set; }
        public double CarboValue { get; set; }
        public double Kcal { get; set; }
        public string Picture { get; set; }
    }
}
