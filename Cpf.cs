public class Cpf : Documento
{
    protected override int TamanhoMaximo => 11;

    public Cpf(string numeroDoDocumento) : base(numeroDoDocumento)
    {
        digito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        digito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    }
    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:000\\.###\\.###-##}", long.Parse(numeroDoDocumento));
    }

}
