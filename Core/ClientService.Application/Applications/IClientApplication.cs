using ClientService.Domain.Adapters.Dtos;

namespace ClientService.Application.Applications
{
    public interface IClientApplication
    {
        public IEnumerable<ClientDto> GetList();
        public ClientDto Get(int id);
        public Task<bool> Add(ClientDto Client);
        public bool Update(ClientDto Client);
        public bool Delete(int id);
    }
}
