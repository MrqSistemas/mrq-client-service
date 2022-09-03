using System.Diagnostics.CodeAnalysis;

namespace ClientService.Domain.Entities
{
    [ExcludeFromCodeCoverage]
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
}
