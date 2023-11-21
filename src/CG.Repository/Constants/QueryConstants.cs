using Org.BouncyCastle.Asn1.X509;

namespace CG.Repository.Constants
{
    public class QueryConstants
    {
        public const string GET_ALL_VALUES_QUERY = "SELECT * FROM {0} ORDER BY id DESC";

        public const string GET_VALUE_BY_ID_QUERY = "SELECT * FROM {0} WHERE id = {1}";

        public const string GET_VALEUES_LIKE_QUERY = "SELECT * FROM {0} WHERE {1} LIKE '%{2}%'";

        public const string GET_LAST_VALUE_QUERY = "SELECT * FROM {0} ORDER BY ID DESC LIMIT 1";

        /// <summary>
        /// Intuito de consultar um valor anterior de acordo com o proximo menor valor quanto a ID
        /// Precisa informar Primeiro a tablela e depois o ID
        /// </summary>
        public const string GET_PREVIUS_VALUE_BY_ID_QUERY = "SELECT * FROM {0} WHERE id < {1} ORDER BY id DESC LIMIT 1";

        /// <summary>
        /// Intuito de consultar um proximo valor de acordo com o proximo menor valor quanto a ID
        /// </summary>
        public const string GET_NEXT_VALUE_BY_ID_QUERY = "SELECT * FROM {0} WHERE id > {1} ORDER BY id ASC LIMIT 1";

        /// <summary>
        /// Intuito de Excluir um valor de acordo com o ID
        /// </summary>
        public const string DELETE_VALUE_BY_ID_QUERY = "DELETE FROM {0} WHERE Id = {1}";
    }
}
