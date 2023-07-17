using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IQuestionsService
    {
        List<Questions> GetAll();
        void Add(Questions questions);
        void Update(Questions questions);
        void Delete(int Id);
        Questions GetById(int ID);
        List<Questions> GetAll(int sinavid);
    }
}
