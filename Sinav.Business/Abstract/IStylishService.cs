using Sinav.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Business.Abstract
{
    public interface IStylishService
    {
        List<Stylish> GetAll();
        void Add(Stylish stylish);
        void Update(Stylish stylish);
        void Delete(int Id);
        Stylish GetQuizzesID(int ID);
    }
}
