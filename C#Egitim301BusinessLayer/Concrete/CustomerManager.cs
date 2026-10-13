using C_Egitim301BusinessLayer.Abstract;
using C_Egitim301DataAccesLayer.Abstract;
using C_Egitim301EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public void TCreate(Customer entity)
        {
            _customerDal.Insert(entity);
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetByID(id);
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
        }
    }
}
