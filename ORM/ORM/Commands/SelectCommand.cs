using System.Data.SqlClient;
using ORM.Contracts;

namespace ORM.Commands
{
    public class SelectCommand : ICommand
    {
        public SelectCommand(IMetadata metaData)
        {
            MetaData = metaData;
        }

        private IMetadata MetaData { get; set; }

        public SqlCommand Execute(object id)
        {
            var query = string.Format("SELECT Id,{0} FROM {1} WHERE Id=@Id", string.Join(",", MetaData.Properties), MetaData.Name);

            var command = new SqlCommand(query);

            command.Parameters.Add(new SqlParameter("Id", id));

            return command;
        }
    }
}