using SimpleZero.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleZero.Migrations.SeedData
{
    public class DefaultContactGroupCreator
    {
        private readonly SimpleZeroDbContext _context;

        public DefaultContactGroupCreator(SimpleZeroDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var groupList = new List<string>() { "Family", "Friends" };

            foreach (var g in groupList)
            {
                var group = _context.ContactGroups.FirstOrDefault(x => x.Name == g);
                if (group == null)
                {
                    _context.ContactGroups.Add(new Contacts.ContactGroup() { Name = g, LimitedTotal = 100 });
                }
            }
            //_context.SaveChanges();
        }
    }
}
