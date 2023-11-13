public class TituloEleitor : Documento
{
    protected override int TamanhoMaximo => 12;

    public TituloEleitor(string numeroDoDocumento) : base(numeroDoDocumento)
    {
    }

    public override void CalcularDigitoVerificador()
    {

        int[] digito1 = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };

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

        return numeroDoDocumento.EndsWith('0');

    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:000\\.#####\\.##-#}", long.Parse(numeroDoDocumento));
    }
}
