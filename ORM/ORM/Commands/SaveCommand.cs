using System.Data.SqlClient;
using ORM.Contracts;

namespace ORM.Commands
{
    public class SaveCommand : ICommand
    {
        public SqlCommand Execute(object id)
        {
            throw new System.NotImplementedException();
        }
    }
}