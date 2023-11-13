public class Cnpj : Documento
{
    protected override int TamanhoMaximo => 14;

    public Cnpj(string numeroDoDocumento) : base(numeroDoDocumento)
    {
    }

    public override void CalcularDigitoVerificador()
    {
        int[] digito1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] digito2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

        if (numeroDoDocumento.Length != 12)
            throw new ArgumentException("Número de CNPJ deve conter 12 dígitos.");

        string cnpj = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 12; i++)
            soma += int.Parse(cnpj[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        cnpj += digito;

        soma = 0;

        for (int i = 0; i < 13; i++)
            soma += int.Parse(cnpj[i].ToString()) * digito2[i];

        resto = soma % 11;

        digito += resto < 2 ? "0" : (11 - resto).ToString();

        numeroDoDocumento += digito;
    }

    public override bool ValidarDocumento()
    {
        int[] digito1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] digito2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

        if (numeroDoDocumento.Length != 14)
            throw new ArgumentException("Número de CNPJ deve conter 14 dígitos.");

        string cnpj = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 12; i++)
            soma += int.Parse(cnpj[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        cnpj += digito;

        soma = 0;

        for (int i = 0; i < 13; i++)
            soma += int.Parse(cnpj[i].ToString()) * digito2[i];

        resto = soma % 11;

        digito += resto < 2 ? "0" : (11 - resto).ToString();

        return numeroDoDocumento.EndsWith(digito);

    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:00\\.###\\.###\\/####-##}", long.Parse(numeroDoDocumento));
    }
}
