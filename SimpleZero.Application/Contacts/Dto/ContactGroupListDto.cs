using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleZero.Contacts.Dto
{

    [AutoMapFrom(typeof(ContactGroup))]
    public class ContactGroupListDto: EntityDto<int>
    {
        public virtual string Name { get; set; }

        public virtual int LimitedTotal { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
