public class InscricaoEstadualParana : Documento
{


    public InscricaoEstadualParana(string numeroDoDocumento) : base(numeroDoDocumento)
    {
        Tipo = "InscricaoEstadualParana";
        TamanhoMaximo = 10;
        digito1 = new int[8] { 3, 2, 7, 6, 5, 4, 3, 2 };
        digito2 = new int[9] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
    }
    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:########-##}", long.Parse(numeroDoDocumento));
    }
}
