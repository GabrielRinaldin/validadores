public class Pis : Documento
{

    public Pis(string numeroDoDocumento) : base(numeroDoDocumento)
    {
        Tipo = "Pis";
        TamanhoMaximo = 11;
        digito1 = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
    }
    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:000\\.#####\\.##-#}", long.Parse(numeroDoDocumento));
    }
}