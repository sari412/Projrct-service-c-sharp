using BL.BlApi;
using BL.BLIMP;
using BL.BO;
using DAL;
using DAL.DalApi;
using DAL.DalMplemantation;
using DAL.Models;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{
    public class BLManager
    {
        public BLIClients clients { get;}
        public BLIEmployee employee { get; }
        public BLIOrders orders { get; }
        public BLManager()
       {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<DalManager>();
           
            services.AddSingleton<BLIClients,BLClientService>();

            services.AddSingleton<BLIEmployee, BLEmployeeService>();

            services.AddSingleton<BLIOrders, BLOrderService>();


            var provider = services.BuildServiceProvider();

            clients = provider.GetRequiredService<BLIClients>();
            employee = provider.GetRequiredService<BLIEmployee>();
            orders = provider.GetRequiredService<BLIOrders>();
        }
    }
}