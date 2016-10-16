using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleZero.Contacts
{
    public class ContactGroup: FullAuditedEntity
    {
        //
        // Summary:
        //     Maximum length of the Abp.Authorization.Users.AbpUserBase.EmailAddress property.
        public const int MaxNameLength = 256;
        
        [Required]
        [StringLength(MaxNameLength)]
        public virtual string Name { get; set; }

        public virtual int LimitedTotal { get; set; }

        public virtual bool IsActive { get; set; }
    }
}
