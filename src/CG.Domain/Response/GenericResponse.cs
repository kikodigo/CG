namespace CG.Domain.Response
{
    public  class GenericResponse<T>
    {
        public T Data { get; set; }
        public bool HasError { get; set; }
        public dynamic Errors { get; set; }
    }
}
