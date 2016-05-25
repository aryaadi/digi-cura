using Avam.DigiCura.Domain.Core;

namespace Avam.DigiCura.Domain
{
    public class Article : AuditableBusinessObjectBase
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsProcessed { get; set; }
    }
}
