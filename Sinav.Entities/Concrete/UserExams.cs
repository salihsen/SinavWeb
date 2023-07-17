using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Entities.Concrete
{
    public class UserExams : IEntity
    {
        public int ID { get; set; }
        public int QuizzesID{ get; set; }
        public int UserID { get; set; }
    }
}
