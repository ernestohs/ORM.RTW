using System.Collections.Generic;

namespace ORM.Contracts
{
    public interface IMetadata
    {
        IList<object> Properties { get; set; }
        string Name { get; set; }
    }
}