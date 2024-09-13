namespace CG.Domain.Response
{
    public class GenericResponseList<T>
    {
        public List<T> Data { get; set; }
        public bool HasError { get; set; }
        public IEnumerable<string> Errors { get; set; }
        
        public GenericResponseList<T> Sucesso()
        {
            HasError = false;
            return this;
        }

        public GenericResponseList<T> Falha(string erro)
        {
            HasError = true;
            Errors = new List<string>() { erro };
            return this;
        }
    }
}
