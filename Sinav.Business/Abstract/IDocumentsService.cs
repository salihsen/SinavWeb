using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IDocumentsService
    {
        List<Documents> GetAll();
        void Add(Documents documents);
        void Update(Documents documents);
        void Delete(int Id);
        Documents GetByID(int ID);
    }
}
