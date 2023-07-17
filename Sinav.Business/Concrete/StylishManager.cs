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
    public class StylishManager : IStylishService
    {
        private IStylishDal _stylishDal;

        public StylishManager(IStylishDal stylishDal)
        {
            _stylishDal = stylishDal;
        }
        public void Add(Stylish stylish)
        {
            _stylishDal.Add(stylish);
        }

        public void Delete(int Id)
        {
            _stylishDal.Delete(new Stylish { ID = Id });
        }

        public List<Stylish> GetAll()
        {
            return _stylishDal.GetList();
        }

        public Stylish GetQuizzesID(int ID)
        {
            return _stylishDal.Get(p => p.ID == ID);
        }

        public void Update(Stylish stylish)
        {
            _stylishDal.Update(stylish);
        }
    }
}
