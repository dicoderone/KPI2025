using AutoMapper;
using KPIapplication.Abstraction;
using KPIapplication.ModelDTO;
using KPIapplication.Repositories;
using KPIdomain.Models;
using Microsoft.EntityFrameworkCore;

namespace KPIapplication.Services
{
    public class UserService : IUserService
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserService(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Int64> CreateAsync(CreateUserModel model)
        {
            try
            {
                var entity = _mapper.Map<User>(model);
                _context.Users.Add(entity);
                return await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Not create user {ex}");
            }
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserViewModel>> GetllAsync()
        {
            var users = await _context.Users.ToListAsync();
            var userModels = _mapper.Map<List<UserViewModel>>(users);  // Teacher, Admin, Kadrlar uchun automapper
            return userModels;
        }

        public Task<bool> UpdataAsync(UpdateUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
