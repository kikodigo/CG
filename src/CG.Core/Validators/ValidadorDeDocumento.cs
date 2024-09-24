using CpfCnpjLibrary;

namespace CG.Core.Validators;

public static class ValidadorDeDocumento
{
    public static bool ValidarDocumento(this string documento)
    {
        var documentoSemPontuacao = documento.Replace(".", "").Replace("-","").Replace("/","");

        return documentoSemPontuacao.Length switch
        {
            11 => Cpf.Validar(documentoSemPontuacao),
            14 => Cnpj.Validar(documentoSemPontuacao),
            _ => false
        };
    }
}