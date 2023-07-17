using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.Models
{
    public class ExamsListViewModel
    {
        public List<Quizzes> Quizzes { get; set; }
        public List<Questions> Questions { get; set; }
        public List<Stylish> Stylish { get; set; }
    }
}
