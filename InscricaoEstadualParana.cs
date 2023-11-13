public class InscricaoEstadualParana : Documento
{
    protected override int TamanhoMaximo => 14;


    public InscricaoEstadualParana(string numeroDoDocumento) : base(numeroDoDocumento)
    {
    }

    public override void CalcularDigitoVerificador()
    {
        int[] digito1 = new int[8] { 3, 2, 7, 6, 5, 4, 3, 2 };
        int[] digito2 = new int[9] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "");

        if (numeroDoDocumento.Length != 8)
            throw new ArgumentException("Número da Inscrição deve conter 8 dígitos.");

        string inscricao = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 8; i++)
            soma += int.Parse(inscricao[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        inscricao += digito;

        soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(inscricao[i].ToString()) * digito2[i];

        resto = soma % 11;

        digito += resto < 2 ? "0" : (11 - resto).ToString();

        numeroDoDocumento += digito;
    }

    public override bool ValidarDocumento()
    {
        int[] digito1 = new int[8] { 3, 2, 7, 6, 5, 4, 3, 2 };
        int[] digito2 = new int[9] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "");

        if (numeroDoDocumento.Length != 10)
            throw new ArgumentException("Número da Inscrição deve conter 10 dígitos.");

        string inscricao = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 8; i++)
            soma += int.Parse(inscricao[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        inscricao += digito;

        soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(inscricao[i].ToString()) * digito2[i];

        resto = soma % 11;

        digito += resto < 2 ? "0" : (11 - resto).ToString();

        return numeroDoDocumento.EndsWith(digito);

    }
    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:########-##}", long.Parse(numeroDoDocumento));
    }
}
