using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anisimov.Domain.Entities;
using Anisimov.ViewModels;

namespace Anisimov.Infrastructure.Interfaces
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetUserOrders(string userName);
        Order GetOrderById(int id);
        Order CreateOrder(OrderViewModel orderModel, CartViewModel transformCart, string userName);
    }
}
