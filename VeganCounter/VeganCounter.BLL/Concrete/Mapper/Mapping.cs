using AutoMapper;
using VeganCounter.Entities;
using VeganCounter.Models.DTOs.AddedFoodDtos;
using VeganCounter.Models.DTOs.AdminDtos;
using VeganCounter.Models.DTOs.DailyMessageDtos;
using VeganCounter.Models.DTOs.FoodDtos;
using VeganCounter.Models.DTOs.StandartUserDtos;
using VeganCounter.Models.VMs.AddedFoodVMs;
using VeganCounter.Models.VMs.AdminVMs;
using VeganCounter.Models.VMs.DailyMessageVMs;
using VeganCounter.Models.VMs.FoodVMs;
using VeganCounter.Models.VMs.LoginVms;
using VeganCounter.Models.VMs.StandartUserVMs;

namespace VeganCounter.BLL.Concrete.Mapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<User, LoginVm>().ReverseMap();

            CreateMap<Food, FoodBaseDto>().ReverseMap();
            CreateMap<Food, FoodCreateDto>().ReverseMap();
            CreateMap<Food, FoodUpdateDto>().ReverseMap();
            CreateMap<FoodBaseDto, FoodDetailVm>().ReverseMap();
            CreateMap<FoodCreateDto, FoodCreateVm>().ReverseMap();
            CreateMap<FoodUpdateDto, FoodUpdateVm>().ReverseMap();


            CreateMap<User, AdminBaseDto>().ReverseMap();
            CreateMap<AdminBaseDto, AdminBaseVm>().ReverseMap();


            CreateMap<User, StandartUserBaseDto>().ReverseMap();
            CreateMap<User, StandartUserBodyUpdateDto>().ReverseMap();
            CreateMap<User, StandartUserCreateDto>().ReverseMap();
            CreateMap<StandartUserBaseDto, StandartUserBaseVm>().ReverseMap();
            CreateMap<StandartUserBodyUpdateDto, StandartUserBodyUpdateVm>().ReverseMap();
            CreateMap<StandartUserCreateDto, StandartUserCreateVm>().ReverseMap();


            CreateMap<DailyMessage, StandartUserBaseDto>().ReverseMap();
            CreateMap<DailyMessage, DailyMessageCreateDto>().ReverseMap();
            CreateMap<DailyMessage, DailyMessageUpdateDto>().ReverseMap();
            CreateMap<StandartUserBaseDto, DailyMessageVm>().ReverseMap();
            CreateMap<DailyMessageCreateDto, DailyMessageCreateVm>().ReverseMap();
            CreateMap<DailyMessageUpdateDto, DailyMessageUpdateVm>().ReverseMap();


            CreateMap<AddedFood, AddedFoodBaseDto>().ReverseMap();
            CreateMap<AddedFood, AddedFoodCreateDto>().ReverseMap();
            CreateMap<AddedFoodBaseDto, AddedFoodBaseVm>().ReverseMap();
            CreateMap<AddedFoodCreateDto, AddedFoodCreateVm>().ReverseMap();
        }
    }
}
