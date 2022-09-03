using System.Diagnostics.CodeAnalysis;

namespace ClientService.Domain.Adapters.Dtos
{
    [ExcludeFromCodeCoverage]
    public class ClientDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
    }
}
