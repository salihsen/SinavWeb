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
    public class QuizzesManager : IQuizzesService
    {
        private IQuizzesDal _quizzesDal;

        public QuizzesManager(IQuizzesDal quizzesDal)
        {
            _quizzesDal = quizzesDal;
        }
        public void Add(Quizzes quizzes)
        {
            _quizzesDal.Add(quizzes);
        }

        public void Delete(int Id)
        {
            _quizzesDal.Delete(new Quizzes { ID = Id });
        }

        public List<Quizzes> GetAll()
        {
            return _quizzesDal.GetList();
        }

        public Quizzes GetById(int ID)
        {
            return _quizzesDal.Get(p => p.ID == ID);
        }

        public void Update(Quizzes quizzes)
        {
            _quizzesDal.Update(quizzes);
        }
    }
}
