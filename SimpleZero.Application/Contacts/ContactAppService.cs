using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using SimpleZero.Contacts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleZero.Contacts
{
    public class ContactAppService : SimpleZeroAppServiceBase, IContactAppService
    {
        private readonly IRepository<ContactGroup> _contactGroupRepository;
        private readonly IRepository<Contact,long> _contactRepository;

        public ContactAppService(IRepository<ContactGroup> contactGroupRepository, IRepository<Contact, long> contactRepository)
        {
            _contactGroupRepository = contactGroupRepository;
            _contactRepository = contactRepository;
        }

        public async Task<ListResultDto<ContactGroupListDto>> GetContactGroups()
        {
            var groups = await _contactGroupRepository.GetAllListAsync();
            
            return new ListResultDto<ContactGroupListDto>(
                groups.MapTo<List<ContactGroupListDto>>()
                );
        }
    }
}
