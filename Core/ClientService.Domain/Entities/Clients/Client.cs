using System.Diagnostics.CodeAnalysis;

namespace ClientService.Domain.Entities.Clients
{
    [ExcludeFromCodeCoverage]
    public class Client : EntityBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
    }
}
