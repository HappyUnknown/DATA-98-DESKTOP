using DATA_98_DESKTOP.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_98_DESKTOP.Context
{
    class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderContext() : base("Data98Connection")
        {

        }
        public List<Order> GetRespectiveOrders(Master master)
        {
            List<Order> orders = Orders.ToList();
            List<Order> respectives = new List<Order>();
            for (int i = 0; i < orders.Count; i++)
                if (master.Id == orders[i].MasterId)
                    respectives.Add(orders[i]);
            return respectives;
        }
        public int NextId()
        {
            var db = new OrderContext();
            List<Order> orders = db.Orders.ToList();
            int nextId = orders[orders.Count - 1].Id + 1;
            db.Dispose();
            return nextId;
        }
    }
}
