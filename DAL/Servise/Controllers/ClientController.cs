using BL;
using BL.BlApi;
using BL.BLIMP;
using BL.BO;
using DAL.DalMplemantation;
using Microsoft.AspNetCore.Mvc;

namespace Servise.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClientController : Controller
    { 
        BL.BlApi.BLIClients bLClientService;
        public ClientController(BLManager bl) 
        {
            bLClientService = bl.clients;
        }


        [HttpGet]
        [Route("GetClients")]
        public List<BLClient> GetUsersNameList()
        {
            return bLClientService.Read().Result;
        }

        [HttpPost]
        [Route("CreateClient")]
        public void CreateNewClient(BLClient client)
        {
            bLClientService.Create(client);
        }

    }
}
