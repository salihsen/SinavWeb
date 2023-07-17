using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sinav.Web.Models
{
    public class DocumentsListViewModel
    {
        public List<Documents> Documents { get; internal set; }
        public Documents Document { get; set; }
    }
}
