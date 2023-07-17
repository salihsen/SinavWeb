using Microsoft.AspNetCore.Http;
using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.SessionHelper
{
    public class QuizzesSessionHelper : IQuizzesSessionHelper
    {
        private IHttpContextAccessor _httpContextAccessor;
        public QuizzesSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string Name => GetQuzzies() == null ? null : string.Format("{0} {1}", GetQuzzies().Name);

        public Quizzes GetQuzzies()
        {
            return _httpContextAccessor.HttpContext.Session.GetObject<Quizzes>("quizzes");
        }

        public void SetQuizzes(Quizzes addQuizzes)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("quizzes", addQuizzes);
        }
    }
}
