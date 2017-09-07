using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MT.Roles.Dto;
using MT.Users.Dto;

namespace MT.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}