using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.DAL.Abstract;
using VeganCounter.Entities;
using VeganCounter.Models.DTOs.FoodDtos;
using VeganCounter.Models.VMs.FoodVMs;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Concrete.Services
{
    public class FoodService : IFoodService
    {

        private readonly IFoodRepo _foodRepo;
        private readonly IMapper _mapper;

        public FoodService(IMapper mapper, IFoodRepo foodRepo)
        {
            _foodRepo = foodRepo;
            _mapper = mapper;
        }

        public ResultService<FoodCreateDto> Create(FoodCreateVm createVm)
        {
            ResultService<FoodCreateDto> result = new ResultService<FoodCreateDto>();   
            FoodCreateDto creatDto=_mapper.Map<FoodCreateDto>(createVm);

            Food newFood = _mapper.Map<Food>(creatDto);
            var addedFood=_foodRepo.Create(newFood);

            if(addedFood != null)
            {
                result.Data = creatDto;
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Ekleme işlemi başarısız");
            }
            return result;
        }

        public bool Delete(int id)
        {
            Food food=_foodRepo.GetFirstOrDefault(filter: x=>x.Id == id);    
            if(food != null)
            {
                return _foodRepo.Delete(food);
            }
            return false;
        }

        public ResultService<List<FoodDetailVm>> GetAll()
        {
            ResultService<List<FoodDetailVm>> result = new ResultService<List<FoodDetailVm>>();

            var foods = _foodRepo.GetFilteredList(
                select: x => new FoodDetailVm
                {
                    FoodName = x.FoodName,
                    CategoryID = x.CategoryID,
                    ProteinValue = x.ProteinValue,
                    FatValue = x.FatValue,
                    CarboValue = x.CarboValue,
                    Kcal = x.Kcal,
                    Picture = x.Picture
                },
                where: x => true, // Varsa filtreleme koşulunu buraya ekleyin, yoksa herhangi bir filtreleme olmayacaktır
                orderBy: x => x.OrderBy(y => y.FoodName), // Eğer sıralama yapmak istiyorsanız buraya sıralama kriterlerini ekleyin
                includes: x => x.Categories // Eğer ilişkili diğer entityleri de çekmek istiyorsanız buraya Include ekleyin
            ) ;

            if (foods != null)
            {
                result.Data = foods.ToList();
            }
            else
            {
                result.AddError(ErrorType.BadRequest, "Beklenmedik bir hata ile karşılaşıldı");
            }

            return result;
        }

        public ResultService<List<FoodDetailVm>> GetMonthlyCalories(string eMail)
        {
            throw new NotImplementedException();
        }

        public ResultService<List<FoodDetailVm>> GetMonthlyFoods(string eMail)
        {
            throw new NotImplementedException();
        }

        public ResultService<List<FoodDetailVm>> GetWeeklyCalories(string eMail)
        {
            throw new NotImplementedException();
        }

        public ResultService<List<FoodDetailVm>> GetWeeklyFoods(string eMail)
        {
            throw new NotImplementedException();
        }

        public ResultService<List<decimal>> GetWeightForLastThreeMonths(string eMail)
        {
            throw new NotImplementedException();
        }


        public bool IsExistFood(string foodName, string categoryName)
        {
            throw new NotImplementedException();
        }

        public ResultService<FoodUpdateDto> Update(FoodUpdateVm updateVm)
        {
            throw new NotImplementedException();
        }
    }
}
