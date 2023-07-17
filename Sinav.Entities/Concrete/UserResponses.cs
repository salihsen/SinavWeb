using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Entities.Concrete
{
    public class UserResponses : IEntity
    {
        public int ID { get; set; }
        public int QuzzesID { get; set; }
        public int QuestionID { get; set; }
        public int StylishID { get; set; }
        public int UserID { get; set; }
    }
}
