using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.SessionHelper
{
    public interface IQuizzesSessionHelper
    {
        public string Name { get; }
        Quizzes GetQuzzies();
        void SetQuizzes(Quizzes addQuizzes);
    }
}
