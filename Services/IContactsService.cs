using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace genericServiceTest.Services
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public interface IContactsService<T> where T : Contact
    {
        Task<T> GetContact(string email);
    }
}
