using System.Threading.Tasks;
using Abp.Application.Services;
using SimpleZero.Roles.Dto;

namespace SimpleZero.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
