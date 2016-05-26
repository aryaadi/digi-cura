using System;

namespace Avam.DigiCura.Domain.Core
{
    public interface IAuditable
    {
        DateTime CreatedOn { get; set; }
        string CreatedBy { get; set; }
        DateTime LastModifiedOn { get; set; }
        string LastModifiedBy { get; set; }
    }
}
