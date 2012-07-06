using System.Data.SqlClient;

namespace ORM.Commands
{
    public class SelectCommand : ICommand
    {
        public SelectCommand(IMetadata metaData)
        {
            MetaData = metaData;
        }

        private IMetadata MetaData { get; set; }

        public SqlCommand Execute(object Id)
        {
            var command = new SqlCommand(string.Format(
                                    "SELECT Id,{0} FROM {1} WHERE Id=@Id",
                                        string.Join(",", MetaData.Properties),
                                        MetaData.Name
                                        ));

            command.Parameters.Add(new SqlParameter("Id", Id));

            return command;
        }
    }
}