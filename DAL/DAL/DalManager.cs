using DAL.DalApi;
using DAL.DalMplemantation;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalManager
    {
        public Iclient clients { get; }
        public IEmployee employee { get; }
        public Iorders orders { get; }
        public DalManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton< dbcontext>();
            services.AddSingleton<Iclient, ClientService>();
            services.AddSingleton<IEmployee, EmployeeService>();
            services.AddSingleton<Iorders, OrdersService>();
            

            var provider = services.BuildServiceProvider();

            clients = provider.GetRequiredService<Iclient>();
            employee = provider.GetRequiredService<IEmployee>();
            orders = provider.GetRequiredService<Iorders>();

        } 
    }
}
