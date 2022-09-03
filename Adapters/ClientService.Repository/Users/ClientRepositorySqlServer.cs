using AutoMapper;
using ClientService.Domain.Adapters;
using ClientService.Domain.Adapters.Dtos;
using ClientService.Domain.Entities.Clients;
using ClientService.Repository.Context;

namespace ClientService.Repository.Clients
{
    public class ClientRepositorySqlServer : IClientAdapter
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ClientRepositorySqlServer(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public IEnumerable<ClientDto> GetList()
        {
            var Clients = _appDbContext.Clients;

            var ClientDtos = _mapper.Map<List<ClientDto>>(Clients);

            return ClientDtos;
        }

        public ClientDto Get(int id)
        {
            var Clients = _appDbContext.Clients;

            var getClient = Clients.Where(p => p.Id == id).FirstOrDefault();

            return _mapper.Map<ClientDto>(getClient);
        }

        public async Task <bool> Add(ClientDto Client)
        {
            Client addClient = _mapper.Map<Client>(Client);

            await _appDbContext.Set<Client>().AddAsync(addClient);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool Update(ClientDto Client)
        {
            Client updateClient = _mapper.Map<Client>(Client);

            _appDbContext.Set<Client>().Update(updateClient);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var Client = _appDbContext.Clients;

            Client deleteClient = Client.Where(p => p.Id == id).FirstOrDefault();

            _appDbContext.Remove(deleteClient);

            _appDbContext.SaveChanges();

            return true;
        }

    }
}
