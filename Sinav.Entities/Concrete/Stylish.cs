using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Entities.Concrete
{
    public class Stylish : IEntity
    {
        public int ID{ get; set; }
        public int QuizzesID { get; set; }
        public int QuestionID { get; set; }
        public string Name{ get; set; }
        public bool IsItCorrect{ get; set; }
    }
}
