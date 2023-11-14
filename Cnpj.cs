public class Cnpj : Documento
{
    protected override int TamanhoMaximo => 14;

    public Cnpj(string numeroDoDocumento) : base(numeroDoDocumento)
    {
        Tipo = "Cnpj";
        digito1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        digito2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:00\\.###\\.###\\/####-##}", long.Parse(numeroDoDocumento));
    }
}
