using Microsoft.AspNetCore.Mvc;
using ClientService.Application.Applications;
using ClientService.Domain.Adapters.Dtos;

namespace ClientService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientApplication _clientApplication;

        public ClientController(IClientApplication clientApplication)
        {
            _clientApplication = clientApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Clients = _clientApplication.GetList();
            return Ok(Clients);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { 
            return Ok(_clientApplication.Get(id));
        }

        [HttpPost]
        public async Task <IActionResult> Post(ClientDto Client)
        {
            return Ok(await _clientApplication.Add(Client));
        }

        [HttpPut]
        public IActionResult Put(ClientDto Client)
        {
            return Ok(_clientApplication.Update(Client));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_clientApplication.Delete(id));
        }
    }
}
