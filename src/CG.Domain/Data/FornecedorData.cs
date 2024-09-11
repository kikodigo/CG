using CG.Domain.Enum;

namespace CG.Domain.Data
{
    public class FornecedorData
    {
        public int Id { get; set; }
        public string Razao { get; set; }
        public string Fantasia { get; set; }
        public string DocNum { get; set; }
        public string Rua { get; set; }
        public string Num { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Contato { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public string TipoCont { get; set; }
        public string Ag { get; set; }
        public string Op { get; set; }
        public string Ct { get; set; }
        public string Pix { get; set; }
        public string Obs { get; set; }
        public StatusEnum Status { get; set; }
    }
}
