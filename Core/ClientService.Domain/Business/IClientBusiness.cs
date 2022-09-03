using ClientService.Domain.Adapters.Dtos;

namespace ClientService.Domain.Business
{
    public interface IClientBusiness
    {
        public IEnumerable<ClientDto> GetList();
        public ClientDto Get(int id);
        public Task<bool> Add(ClientDto Client);
        public bool Update(ClientDto Client);
        public bool Delete(int id);
    }
}
