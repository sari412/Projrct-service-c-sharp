using DAL.DalApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalMplemantation
{
    public class EmployeeService : IEmployee
    {
        dbcontext dbEmployee;
        public EmployeeService(DAL.Models.dbcontext dbcontext)
        {
            dbEmployee=dbcontext;
        }
        public async void Create(Employee item)
    {
        throw new NotImplementedException();
    }

    public async void Delete()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Employee>> Read()
    {
        throw new NotImplementedException();
    }

    public async void Update()
    {
        throw new NotImplementedException();
    }
}
}
