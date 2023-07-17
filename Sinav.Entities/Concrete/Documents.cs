using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Entities.Concrete
{
    public class Documents : IEntity
    {
        public int ID { get; set; }
        public string Path{ get; set; }
        public bool IsVideo{ get; set; }
        public bool IsActive { get; set; }
    }
}
