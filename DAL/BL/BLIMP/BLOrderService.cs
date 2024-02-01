using BL.BlApi;
using BL.BO;
using DAL;
using DAL.DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BLIMP
{
    public class BLOrderService : BLIOrders
    {
        Iorders DalOrders;
        public BLOrderService(DalManager dlOrders) 
        {
            this.DalOrders = dlOrders.orders;
        }
        public async void Create(BLOrders item)
        {
            throw new NotImplementedException();
        }

        public async void Delete(BLOrders item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BLOrders>> Read()
        {
            throw new NotImplementedException();
        }

        public async void Update(BLOrders item)
        {
            throw new NotImplementedException();
        }
    }
}
