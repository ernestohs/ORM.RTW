using System.Collections.Generic;

namespace ORM.Commands
{
    public class MetaData : IMetadata
    {
        public IList<object> Properties { get; set; }
        public string Name { get; set; }
    }
}