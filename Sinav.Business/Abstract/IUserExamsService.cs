using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IUserExamsService
    {
        List<UserExams> GetAll();
        void Add(UserExams userExams);
        void Update(UserExams userExams);
        void Delete(int Id);
        UserExams GetById(int ID);
        //List<UserExams> GetAll(int sinavid);
    }
}
