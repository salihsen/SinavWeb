using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IQuizzesService
    {
        List<Quizzes> GetAll();
        void Add(Quizzes quizzes);
        void Update(Quizzes quizzes);
        void Delete(int Id);
        Quizzes GetById(int ID);
    }
}
