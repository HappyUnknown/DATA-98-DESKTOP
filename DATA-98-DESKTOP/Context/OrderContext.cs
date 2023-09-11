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
            int maxId = Orders.Max(x => x.Id);
            int nextId = maxId + 1;
            return nextId;
        }
        public void SetOrderMaster(int orderIndex, int masterId)
        {
            var orders = Orders.ToList();
            orders[orderIndex].MasterId = masterId;
        }
        public void IdlizeOrder(int orderIndex)
        {
            var orders = Orders.ToList();
            orders[orderIndex].ApprovalPhase = AgreementState.Unapproved;
        }
        public void ApproveOrder(int orderIndex)
        {
            var orders = Orders.ToList();
            orders[orderIndex].ApprovalPhase = AgreementState.Approved;
        }
        public void DisapproveOrder(int orderIndex)
        {
            var orders = Orders.ToList();
            orders[orderIndex].ApprovalPhase = AgreementState.Disapproved;
        }
        public void MarkDone(int orderIndex)
        {
            var orders = Orders.ToList();
            orders[orderIndex].ApprovalPhase = AgreementState.Done;
        }
    }
}
