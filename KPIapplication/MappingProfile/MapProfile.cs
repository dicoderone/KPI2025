using AutoMapper;
using KPIapplication.ModelDTO;
using KPIdomain.Models;
using KPIdomain.Role;

namespace KPIapplication.MappingProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, CreateUserModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<CreateUserModel, User>();
            //CreateMap<CreateTeacherModel, User>()                                                             Teacher uchun Map
            //    .ForMember(x => x.Role, o => o.MapFrom(s => UserRole.Teacher))
            //    .ForMember(d => d.PasswordHash, o => o.MapFrom(s => hashProvider.GetHash(s.Password)));
        }
    }
}
