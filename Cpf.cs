public class Cpf : Documento
{
    protected override int TamanhoMaximo => 11;

    public Cpf(string numeroDoDocumento) : base(numeroDoDocumento)
    {
    }

    public override void CalcularDigitoVerificador()
    {
        int[] digito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] digito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "");

        if (numeroDoDocumento.Length != 9)
            throw new ArgumentException("Número de CPF deve conter 9 dígitos.");

        string cpf = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        cpf += digito;

        soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(cpf[i].ToString()) * digito2[i];

        resto = soma % 11;

        digito += resto < 2 ? "0" : (11 - resto).ToString();

        numeroDoDocumento += digito;
    }

    public override bool ValidarDocumento()
    {
        int[] digito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] digito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "");

        if (numeroDoDocumento.Length != 11)
            throw new ArgumentException("Número de CPF deve conter 11 dígitos.");

        string cpf = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        cpf += digito;

        soma = 0;

        for (int i = 0; i < 10; i++)
            soma += int.Parse(cpf[i].ToString()) * digito2[i];

        resto = soma % 11;

        digito += resto < 2 ? "0" : (11 - resto).ToString();

        return numeroDoDocumento.EndsWith(digito);
    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:000\\.###\\.###-##}", long.Parse(numeroDoDocumento));
    }

}
