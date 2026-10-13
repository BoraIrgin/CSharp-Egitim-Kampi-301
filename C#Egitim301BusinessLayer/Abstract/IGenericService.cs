using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetAll();
        T TGetById(int id);
        void TCreate(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
    }
}
