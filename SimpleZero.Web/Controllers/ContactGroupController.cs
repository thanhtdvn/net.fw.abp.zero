using SimpleZero.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SimpleZero.Web.Controllers
{
    public class ContactGroupController : SimpleZeroControllerBase
    {
        private readonly IContactAppService _contactAppSrv;

        public ContactGroupController(IContactAppService contactAppSrv)
        {
            _contactAppSrv = contactAppSrv;
        }

        // GET: Group
        public async Task<ActionResult> Index()
        {
            var contactGroups = await _contactAppSrv.GetContactGroups();
            return View(contactGroups);
        }
    }
}