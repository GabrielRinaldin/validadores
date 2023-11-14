public class Cnpj : Documento
{

    public Cnpj(string numeroDoDocumento) : base(numeroDoDocumento)
    {
        Tipo = "Cnpj";
        TamanhoMaximo = 14;
        digito1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        digito2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:00\\.###\\.###\\/####-##}", long.Parse(numeroDoDocumento));
    }
}
