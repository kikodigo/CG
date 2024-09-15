namespace CG.Domain.Response
{
    public class GenericResponse<T>
    {
        public T Data { get; set; }
        public bool HasError { get; set; }
        public IEnumerable<string> Errors { get; set; }

    }
}