using System;

namespace Avam.DigiCura.Domain.Core
{
    public abstract class AuditableBusinessObjectBase : BusinessObjectBase, IAuditable
    {
        #region IAuditable Memebers
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        #endregion
    }
}
