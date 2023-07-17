using Sinav.Business.Abstract;
using Sinav.DataAccess.Abstract;
using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Delete(int Id)
        {
            _userDal.Delete(new User { ID = Id });
        }

        public List<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User GetByID(int ID)
        {
            return _userDal.Get(x => x.ID == ID);
        }

        public User GetByUserName(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName && u.Password == password);
        }

        public User IsActive(bool ısactive)
        {
            return _userDal.Get(x => x.IsActive == ısactive);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
