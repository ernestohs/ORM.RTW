using System.Collections.Generic;

namespace ORM.Commands
{
    public interface IMetadata
    {
        IList<object> Properties { get; set; }
        string Name { get; set; }
    }
}