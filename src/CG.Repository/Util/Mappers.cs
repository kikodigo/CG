using MySql.Data.MySqlClient;
using System.Reflection;

namespace CG.Repository.Util
{
    public class Mappers
    {
        private readonly string TableName;

        public Mappers(string tableName)
        {
            TableName = tableName;
        }

        /// <summary>
        ///  Intuito de efetuar um update no banco MySql, o metodo irá criar a query completa baseando-se em todas as propriedades do objeto informado
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public MySqlCommand UpdateMapper<T>(T data, string primaryKey = "Id")
        {

            string updateQuery = $"UPDATE {TableName} SET ";
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                if (property.Name != primaryKey)
                {
                    updateQuery += $"{property.Name}=@{property.Name}, ";
                }
            }

            updateQuery = updateQuery.TrimEnd(',', ' ');
            updateQuery += $" WHERE {primaryKey}=@{primaryKey}"; //TODO: Trocar para Append

            var command = new MySqlCommand(updateQuery);

            foreach (var property in properties)
            {
                command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(data));
            }

            return command;
        }


        public MySqlCommand InsertMapper<T>(T data)
        {

            string insertQuery = $"INSERT INTO {TableName} (";
            string valuesQuery = "VALUES (";
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                insertQuery += $"{property.Name}, ";
                valuesQuery += $"@{property.Name}, ";
            }

            insertQuery = insertQuery.TrimEnd(',', ' ') + ")";
            valuesQuery = valuesQuery.TrimEnd(',', ' ') + ")";

            string fullQuery = insertQuery + " " + valuesQuery;

            var command = new MySqlCommand(fullQuery);

            foreach (var property in properties)
            {
                command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(data));
            }

            return command;
        }
    }
}
