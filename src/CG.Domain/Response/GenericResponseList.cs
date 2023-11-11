namespace CG.Domain.Response
{
    public class GenericResponseList<T>
    {
        public List<T> Data { get; set; }
        public bool HasError { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
