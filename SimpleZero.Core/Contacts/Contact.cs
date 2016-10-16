using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleZero.Contacts
{
    public class Contact: FullAuditedEntity<long>
    {
        public virtual string FullName { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Address { get; set; }
        public virtual string Note { get; set; }
        
        public virtual int? ContactGroupId { get; set; }
        public virtual ContactGroup ContactGroup { get; set; }    
        
    }
}
