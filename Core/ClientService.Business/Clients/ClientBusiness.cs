using ClientService.Domain.Adapters;
using ClientService.Domain.Adapters.Dtos;
using ClientService.Domain.Business;

namespace ClientService.Business.Clients
{
    public class ClientBusiness : IClientBusiness
    {
        private readonly IClientAdapter _ClientAdapter;

        public ClientBusiness(IClientAdapter ClientAdapter)
        {
            _ClientAdapter = ClientAdapter;
        }

        public IEnumerable<ClientDto> GetList()
        {
            return _ClientAdapter.GetList();
        }

        public ClientDto Get(int id)
        {
            return _ClientAdapter.Get(id);
        }

        public async Task<bool> Add(ClientDto Client)
        {
            return await _ClientAdapter.Add(Client);
        }

        public bool Update(ClientDto Client)
        {
            return _ClientAdapter.Update(Client);
        }

        public bool Delete(int id)
        {
            return _ClientAdapter.Delete(id);
        }
    }
}
