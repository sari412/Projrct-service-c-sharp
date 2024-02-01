using DAL.DalApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalMplemantation
{
    public class OrdersService : Iorders
    {
        dbcontext dbOrders;
        public OrdersService(DAL.Models.dbcontext dbcontext)
        {
            dbOrders=dbcontext;
        }
        public async void Create(Order item)
        {
            throw new NotImplementedException();
        }

        public async void  Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> Read()
        {
            throw new NotImplementedException();
        }


        public async void Update()
        {
            throw new NotImplementedException();
        }
    }
}
