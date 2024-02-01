using DAL.DalApi;
using DAL.Models;

namespace DAL.DalMplemantation
{
    public class ClientService : Iclient
    {
        dbcontext dbclient;
        public ClientService(DAL.Models.dbcontext dbcontext) 
        {
            this.dbclient = dbcontext;
        }
        public async void Create(Client item)
        {
            dbclient.Clients.Add(item);
            dbclient.SaveChangesAsync();
        }
        
        public async void Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Client>> Read()
        {
            return dbclient.Clients.ToList();
        }

        public async void Update()
        {
            throw new NotImplementedException();
        }
    }
    }
