using System;
using System.Collections.Generic;

namespace ORM
{
    public class ORM
    {
        public ORM(string database)
        {

        }

        public IList<T> Get<T>(Func<T, bool> func)
        {
            throw new NotImplementedException();
        }
    }
}
