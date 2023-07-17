using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Delete(int Id);
        User GetByUserName(string userName,string password);
        User GetByID(int ID);
        User IsActive(bool ısactive);
    }
}
