namespace CG.Domain.Response
{
    public class GenericResponse<T>
    {
        public T Data { get; set; }
        public bool HasError { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public GenericResponse<T> Sucesso()
        {
            HasError = false;
            return this;
        }

        public GenericResponse<T> Falha(string erro)
        {
            HasError = true;
            Errors = new List<string>() { erro };
            return this;
        }
    }
}