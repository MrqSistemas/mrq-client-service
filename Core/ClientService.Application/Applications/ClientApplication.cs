using ClientService.Domain.Adapters.Dtos;
using ClientService.Domain.Business;

namespace ClientService.Application.Applications
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientBusiness _ClientBusiness;

        public ClientApplication(IClientBusiness ClientBusiness)
        {
            _ClientBusiness = ClientBusiness;
        }

        public IEnumerable<ClientDto> GetList()
        {
            return _ClientBusiness.GetList();
        }

        public ClientDto Get(int id)
        {
            return _ClientBusiness.Get(id);
        }

        public Task<bool> Add(ClientDto Client)
        {
            return _ClientBusiness.Add(Client);
        }

        public bool Update(ClientDto Client)
        {
            return _ClientBusiness.Update(Client);
        }

        public bool Delete(int id)
        {
            return _ClientBusiness.Delete(id);
        }
    }
}
