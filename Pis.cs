public class Pis : Documento
{
    protected override int TamanhoMaximo => 11;

    public Pis(string numeroDoDocumento) : base(numeroDoDocumento)
    {
    }

    public override void CalcularDigitoVerificador()
    {

        int[] digito1 = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "");

        if (numeroDoDocumento.Length != 10)
            throw new ArgumentException("Número da Inscrição deve conter 10 dígitos.");

        string pis = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(pis[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        numeroDoDocumento += digito;
    }

    public override bool ValidarDocumento()
    {
        int[] digito1 = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "");

        if (numeroDoDocumento.Length != 11)
            throw new ArgumentException("Número da Inscrição deve conter 11 dígitos.");

        string pis = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(pis[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        return numeroDoDocumento.EndsWith(digito);

    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:000\\.#####\\.##-#}", long.Parse(numeroDoDocumento));
    }
}
