using C_Egitim301EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301DataAccesLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
        void Delete(C_Egitim301.EFProject.Customer entity);
        void Insert(C_Egitim301.EFProject.Customer entity);
    }
}
