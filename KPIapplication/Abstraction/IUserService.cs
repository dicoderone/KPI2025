using KPIapplication.ModelDTO;

namespace KPIapplication.Abstraction
{
    public interface IUserService
    {
        Task<UserViewModel> GetByIdAsync(int id);

        Task<List<UserViewModel>> GetllAsync();

        Task<long> CreateAsync(CreateUserModel model);

        Task<bool> UpdataAsync(UpdateUserModel model);

        Task<bool> DeleteAsync(int id);
    }
}
