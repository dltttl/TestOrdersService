using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdersServiceDAL.Database;
using OrdersServiceDAL.Models;
namespace OrdersServiceDAL.Repositories
{
    public class OrdersRepository:IRepository<Order>
    {
        private readonly ShippingContext Context;
        
        public OrdersRepository(ShippingContext context)
        {
            Context = context;
        }
        
        public async Task<List<Order>> GetAll()
        {
            return await Context.Orders.ToListAsync();
        }

        public async Task Add(Order newEntity)
        {
            Context.Orders.Add(newEntity);
            await Context.SaveChangesAsync();
        }

        public async Task Clear()
        {
            Context.Orders.RemoveRange(Context.Orders);
            await Context.SaveChangesAsync();
        }
    }
}