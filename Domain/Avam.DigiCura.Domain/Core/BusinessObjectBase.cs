using System.ComponentModel.DataAnnotations.Schema;

namespace Avam.DigiCura.Domain.Core
{
    public abstract class BusinessObjectBase
    {
        [NotMapped]
        public virtual bool IsNew { get; protected set; }
    }
}
