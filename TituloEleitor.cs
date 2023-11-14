public class TituloEleitor : Documento
{
    protected override int TamanhoMaximo => 12;

    public TituloEleitor(string numeroDoDocumento) : base(numeroDoDocumento)
    {
        digito1 = new int[8] { 2, 3, 4, 5, 6, 7, 8, 9 };
        digito2 = new int[3] { 7, 8, 9 };
    }

    public override void CalcularDigitoVerificador()
    {

        if (numeroDoDocumento.Length > TamanhoMaximo)
            throw new ArgumentException($"Documento deve conter {TamanhoMaximo} digitos.");

        string uf = numeroDoDocumento.Substring(8);

        string documento = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < digito1.Length; i++)
            soma += int.Parse(documento[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito;

        if (uf == "01" || uf == "02")
        {
            digito = resto == 0 ? "1" : (11 - resto).ToString();
        }
        else
        {
            digito = resto < 2 ? "0" : (11 - resto).ToString();
        }

        documento += digito;

        soma = 0;

        string ultimosTresDigitos = documento.Substring(8);

        for (int i = 0; i < digito2.Length; i++)
            soma += int.Parse(ultimosTresDigitos[i].ToString()) * digito2[i];

        resto = soma % 11;

        if (uf == "01" || uf == "02")
        {
            digito = resto == 0 ? "1" : (11 - resto).ToString();
        }
        else
        {
            digito = resto < 2 ? "0" : (11 - resto).ToString();
        }

        numeroDoDocumento += digito;
    }

    public override bool ValidarDocumento()
    {

        if (numeroDoDocumento.Length > TamanhoMaximo)
            throw new ArgumentException($"Documento deve conter {TamanhoMaximo} digitos.");

        string uf = numeroDoDocumento.Substring(8);

        string documento = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < digito1.Length; i++)
            soma += int.Parse(documento[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito;

        if (uf == "01" || uf == "02")
        {
            digito = resto == 0 ? "1" : (11 - resto).ToString();
        }
        else
        {
            digito = resto < 2 ? "0" : (11 - resto).ToString();
        }
        documento += digito;

        soma = 0;

        for (int i = 0; i < digito2.Length; i++)
            soma += int.Parse(documento[i].ToString()) * digito2[i];

        resto = soma % 11;

        if (uf == "01" || uf == "02")
        {
            digito = resto == 0 ? "1" : (11 - resto).ToString();
        }
        else
        {
            digito = resto < 2 ? "0" : (11 - resto).ToString();
        }

        return numeroDoDocumento.EndsWith(digito);

    }

    public override string ObterDocumentoFormatado()
    {
        return string.Format("{0:000\\.#####\\.##-#}", long.Parse(numeroDoDocumento));
    }
}
