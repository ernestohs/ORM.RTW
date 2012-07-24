using System.Data.SqlClient;
using ORM.Contracts;

namespace ORM.Commands
{
    public class DeleteCommand : ICommand
    {
        private MetaData MetaData { get; set; }

        public DeleteCommand(MetaData metaData)
        {
            MetaData = metaData;
        }
        
        public SqlCommand Execute(object id)
        {
            var query = string.Format("DELETE FROM {0} WHERE Id=@Id", MetaData.Name);

            var command = new SqlCommand(query);

            command.Parameters.Add(new SqlParameter("Id", id));

            return command;
        }
    }
}