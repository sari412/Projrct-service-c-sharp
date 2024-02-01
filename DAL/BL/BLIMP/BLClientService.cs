using BL.BlApi;
using BL.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using DAL.DalMplemantation;
using DAL.DalApi;
using DAL;

namespace BL.BLIMP
{

    public class BLClientService : BLIClients
    {
        Iclient DalclientService;

        public BLClientService()
        {
        }

        public BLClientService(DalManager mydalManager) 
        {
            this.DalclientService = mydalManager.clients;
        }

        public async void Create(BLClient item)
        {
            DAL.Models.Client client = new() {ClientId = item.ClientId,Name=item.Name,PhoneNumber=item.PhoneNumber };
            DalclientService.Create(client);
            
        }

        public async void Delete(BLClient item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BLClient>> Read()
        {
            List<BLClient> list = new List<BLClient>();
            DalclientService.Read().Result.ForEach(client =>
            {
                BLClient client1 = new BLClient()
                { Name = client.Name, ClientId = client.ClientId };
                list.Add(client1);
            });
            return list;
        }

        public async void Update(BLClient item)
        {
            throw new NotImplementedException();
        }
    }
}
