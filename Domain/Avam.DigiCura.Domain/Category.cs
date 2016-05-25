using Avam.DigiCura.Domain.Core;

namespace Avam.DigiCura.Domain
{
    public class Category : AuditableBusinessObjectBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
