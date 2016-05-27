using System;
using System.ComponentModel;

namespace Avam.DigiCura.Domain.Core
{
    public abstract class AuditableBusinessObjectBase : BusinessObjectBase, IAuditable
    {
        #region IAuditable Memebers
        public string CreatedBy { get; set; }
        [DefaultValue("getutcdate()")]
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        #endregion

        #region Public Methods
        public void UpdateAuditMembers(string userName)
        {
            CreatedBy = CreatedBy ?? userName;
            LastModifiedBy = userName;
            CreatedOn = CreatedOn == DateTime.MinValue ? DateTime.UtcNow : CreatedOn;
            LastModifiedOn = DateTime.UtcNow;
        }
        #endregion
    }
}
