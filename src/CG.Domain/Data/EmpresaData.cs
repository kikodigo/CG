using System.Reflection.Metadata;

namespace CG.Domain.Data
{
    public class EmpresaData
    {
        public string Id { get; set; }
        public string DocNum { get; set; }
        public string Razao { get; set; }
        public string Fantasia { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Num { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public int Logo { get; set; } //Todo: Ajustar essa prop para aceitar imagem
    }
}
