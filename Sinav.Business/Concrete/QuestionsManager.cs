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
    public class QuestionsManager : IQuestionsService
    {
        private IQuestionsDal _questionDal;

        public QuestionsManager(IQuestionsDal questionsDal)
        {
            _questionDal = questionsDal;
        }

        public void Add(Questions questions)
        {
            _questionDal.Add(questions);
        }

        public void Delete(int Id)
        {
            _questionDal.Delete(new Questions { ID = Id });
        }

        public List<Questions> GetAll()
        {
            return _questionDal.GetList();
        }
        public List<Questions> GetAll(int sinavid)
        {
            return _questionDal.GetList().Where(x=> x.QuizzesID==sinavid).ToList();
        }
        public Questions GetById(int ID)
        {
            return _questionDal.Get(p => p.QuizzesID == ID);
        }

        public void Update(Questions questions)
        {
            _questionDal.Update(questions);
        }
    }
}
