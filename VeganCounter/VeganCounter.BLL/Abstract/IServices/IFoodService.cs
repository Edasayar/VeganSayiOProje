using VeganCounter.Models.DTOs.FoodDtos;
using VeganCounter.Models.VMs.FoodVMs;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Abstract.IServices
{
    public interface IFoodService
    {
        bool IsExistFood(string foodName, string categoryName);
        ResultService<FoodCreateDto> Create(FoodCreateVm createVm);
        bool Delete(int id);
        ResultService<FoodUpdateDto> Update(FoodUpdateVm updateVm);
        ResultService<List<FoodDetailVm>> GetAll();

        /// <summary>
        /// Haftalık besinleri getiren metot
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns></returns>
        ResultService<List<FoodDetailVm>> GetWeeklyFoods(string eMail);

        /// <summary>
        /// Haftalık kalorileri getiren metot
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns></returns>
        ResultService<List<FoodDetailVm>> GetWeeklyCalories(string eMail);

        /// <summary>
        /// Aylık besinleri getiren metot
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns></returns>
        ResultService<List<FoodDetailVm>> GetMonthlyFoods(string eMail);

        /// <summary>
        /// Aylık kalorileri getiren metot
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns></returns>
        ResultService<List<FoodDetailVm>> GetMonthlyCalories(string eMail);

        /// <summary>
        /// Son 3 aydaki kiloyu getiren metot
        /// </summary>
        /// <param name="eMail"></param>
        /// <returns></returns>
        ResultService<List<decimal>> GetWeightForLastThreeMonths(string eMail);
    }
}
