using AutoMapper;
using ClientService.Domain.Adapters.Dtos;
using ClientService.Domain.Entities.Clients;

namespace ClientService.Repository.Clients.Mappers
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {
            CreateMap<Client, ClientDto>()
                .ReverseMap();
        }
    }
}
