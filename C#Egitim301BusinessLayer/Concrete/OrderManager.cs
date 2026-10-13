using C_Egitim301BusinessLayer.Abstract;
using C_Egitim301EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Egitim301BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        public readonly IOrderService _orderService;

        public OrderManager(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        public void TCreate(Order entity)
        {
            _orderService.TCreate(entity);
        }

        public void TDelete(Order entity)
        {
            _orderService.TDelete(entity);
        }

        public Order TGetById(int id)
        {
            return _orderService.TGetById(id);
        }

        public void TUpdate(Order entity)
        {
            _orderService.TUpdate(entity);
        }
    }
}
