using Sinav.Core.DataAccess.EntityFramework;
using Sinav.DataAccess.Abstract;
using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.DataAccess.Concrete.EntityFramework
{
    public class EfQuizzesDal : EfEntityRepositoryBase<Quizzes, SinavContext>, IQuizzesDal
    {

    }
}
