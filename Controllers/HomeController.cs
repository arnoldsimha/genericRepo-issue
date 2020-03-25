using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using genericServiceTest.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace genericServiceTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IContactsService<AppContact> _myNewContactService;

        public HomeController(IContactsService<AppContact> myNewContactService)
        {
            _myNewContactService = myNewContactService;
            
        }
        public async Task<ActionResult> Get()
        {
            var contactService = _myNewContactService as IContactsService<Contact>;
            return Ok(await contactService.GetContact("test"));
        }
    }
}