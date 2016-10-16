using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SimpleZero.MultiTenancy.Dto;

namespace SimpleZero.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
