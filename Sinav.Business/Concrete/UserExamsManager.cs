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
    public class UserExamsManager : IUserExamsService
    {
        private IUserExamsDal _userExamsDal;
        public UserExamsManager(IUserExamsDal userExamsDal)
        {
            _userExamsDal = userExamsDal;
        }
        public void Add(UserExams userExams)
        {
            _userExamsDal.Add(userExams);
        }

        public void Delete(int Id)
        {
            _userExamsDal.Delete(new UserExams { ID = Id });
        }

        public List<UserExams> GetAll()
        {
            return _userExamsDal.GetList();
        }

        public UserExams GetById(int ID)
        {
            return _userExamsDal.Get(p => p.ID == ID);
        }

        public void Update(UserExams userExams)
        {
            _userExamsDal.Update(userExams);
        }
    }
}
