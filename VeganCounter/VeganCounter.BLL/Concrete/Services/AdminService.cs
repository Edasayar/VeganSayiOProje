using AutoMapper;
using VeganCounter.BLL.Abstract.IServices;
using VeganCounter.DAL.Abstract;
using VeganCounter.Models.VMs.LoginVms;
using VeganCounter.Shared;

namespace VeganCounter.BLL.Concrete.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public AdminService(IUserRepo userRepo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }


        public ResultService<LoginVm> Login(string email, string password)
        {
            ResultService<LoginVm> result = new ResultService<LoginVm>();

            var admin = _userRepo.GetFirstOrDefault(filter: x => x.Email.Equals(email) && x.Password.Equals(password));

            if (admin != null)
            {
                var logged = new LoginVm { Email = email, Password = password, Role = admin.Role };
                result.Data = logged;
            }
            else
            {
                result.AddError(ErrorType.NotFound, "Admin Bulunamadı");
            }

            return result;
        }
    }
}
