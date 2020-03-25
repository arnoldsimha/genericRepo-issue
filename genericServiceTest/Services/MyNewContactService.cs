using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace genericServiceTest.Services
{
    public class AppContact : Contact
    {
        public string Id { get; set; }
    }

    public class MyNewContactService : IContactsService<AppContact>
    {
        public async Task<AppContact> GetContact(string email)
        {
            return await Task.FromResult(new AppContact { Id = "tttt" });
        }
    }
}
