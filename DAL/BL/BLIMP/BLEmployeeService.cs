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
    public class BLEmployeeService : BLIEmployee
    {  
        IEmployee Dalemployee;
        public BLEmployeeService(DalManager dlemployee) 
        { 
            this.Dalemployee = dlemployee.employee;
        }
        public async void Create(BLEmployee item)
        {
            throw new NotImplementedException();
        }

        public async void Delete(BLEmployee item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BLEmployee>> Read()
        {
            throw new NotImplementedException();
        }

        public async void Update(BLEmployee item)
        {
            throw new NotImplementedException();
        }
    }
}
