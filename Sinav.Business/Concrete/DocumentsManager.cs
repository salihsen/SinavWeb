using Sinav.Business.Abstract;
using Sinav.DataAccess.Abstract;
using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Concrete
{
    public class DocumentsManager : IDocumentsService
    {
        private IDocumentsDal _documentsDal;
        public DocumentsManager(IDocumentsDal documentsDal)
        {
            _documentsDal = documentsDal;
        }
        public void Add(Documents documents)
        {
            _documentsDal.Add(documents);
        }

        public void Delete(int Id)
        {
            _documentsDal.Delete(new Documents { ID = Id });
        }

        public List<Documents> GetAll()
        {
            return _documentsDal.GetList();
        }

        public Documents GetByID(int ID)
        {
            return _documentsDal.Get(x => x.ID == ID);
        }

        public void Update(Documents documents)
        {
            _documentsDal.Update(documents);
        }
    }
}
