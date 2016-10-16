using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using SimpleZero.Contacts.Dto;

namespace SimpleZero.Contacts
{
    public interface IContactAppService
    {
        Task<ListResultDto<ContactGroupListDto>> GetContactGroups();
    }
}