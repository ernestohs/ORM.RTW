using System.Collections.Generic;
using ORM.Contracts;

namespace ORM.Commands
{
    public class MetaData : IMetadata
    {
        public IList<object> Properties { get; set; }
        public string Name { get; set; }
    }
}