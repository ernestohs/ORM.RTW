using System.Data.SqlClient;

namespace ORM.Commands
{
    public interface ICommand
    {
        SqlCommand Execute(object id);
    }
}