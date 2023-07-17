using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Entities.Concrete
{
    public class User : IEntity
    {
        public int ID { get; set; }
        public string NameLastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //public byte[] PasswordSalt { get; set; }
        //public byte[] PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

    }
}
