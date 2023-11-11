namespace CG.Repository.Constants
{
    public class QueryConstants
    {

        public const string QUERY_GET_ALL = "SELECT * FROM {0} ORDER BY id DESC";

        /// <summary>
        /// Intuito de consultar um valor anterior de acordo com o proximo menor valor quanto a ID
        /// </summary>
        public const string QUERY_PREVIUS_BY_ID = "SELECT * FROM {0} WHERE id < {1} ORDER BY id DESC LIMIT 1";

        /// <summary>
        /// Intuito de consultar um proximo valor de acordo com o proximo menor valor quanto a ID
        /// </summary>
        public const string QUERY_NEXT_BY_ID = "SELECT * FROM {0} WHERE id > {1} ORDER BY id ASC LIMIT 1";

        /// <summary>
        /// Intuito de Excluir um valor de acordo com o ID
        /// </summary>
        public const string QUERY_DELETE_BY_ID = "DELETE FROM {0} WHERE Id = {1}";
    }
}
