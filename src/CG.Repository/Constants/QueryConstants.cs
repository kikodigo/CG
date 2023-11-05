namespace CG.Repository.Constants
{
    public class QueryConstants
    {
        public const string QUERY_PREVIUS_BY_ID = "SELECT * FROM {0} WHERE id < {1} ORDER BY id DESC LIMIT 1";
        public const string QUERY_NEXT_BY_ID = "SELECT * FROM {0} WHERE id > {1} ORDER BY id ASC LIMIT 1";
    }
}
