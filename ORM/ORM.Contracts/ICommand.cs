using System.Data.SqlClient;

namespace ORM.Contracts
{
    public interface ICommand
    {
        SqlCommand Execute(object id);
    }
}