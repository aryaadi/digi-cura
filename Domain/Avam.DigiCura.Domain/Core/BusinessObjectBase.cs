using System.ComponentModel.DataAnnotations.Schema;

namespace Avam.DigiCura.Domain.Core
{
    public abstract class BusinessObjectBase
    {
        [NotMapped]
        public bool IsNew { get { return IsNewObject(); } }
        protected abstract bool IsNewObject();
    }
}
