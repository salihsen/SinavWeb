using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.Models
{
    public class QuestionsListViewModel
    {
        public List<Questions> Questions { get; internal set; }
    }
}
