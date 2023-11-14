public class Documento
{
    public string Tipo = "Documento";
    public string numeroDoDocumento;
    protected int[] digito1;
    protected int[] digito2;
    public int TamanhoMaximo;
    public string digitosValidados;

    public Documento(string numeroDoDocumento)
    {
        this.numeroDoDocumento = numeroDoDocumento;
        this.digitosValidados = "";
        this.digito1 = new int[0] { };
        this.digito2 = new int[0] { };
    }

    public virtual void CalcularDigitoVerificador()
    {
        if (numeroDoDocumento.Length > TamanhoMaximo)
            throw new ArgumentException($"Documento deve conter {TamanhoMaximo} digitos.");

        string documento = numeroDoDocumento;

        int soma = 0;

        for (int i = 0; i < digito1.Length; i++)
            soma += int.Parse(documento[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        documento += digito;

        if (digito2.Length > 0)
        {
            soma = 0;

            for (int i = 0; i < digito2.Length; i++)
                soma += int.Parse(documento[i].ToString()) * digito2[i];

            resto = soma % 11;

            digito += resto < 2 ? "0" : (11 - resto).ToString();
        }

        numeroDoDocumento += digito;
    }

    public virtual bool ValidarDocumento()
    {

        if (numeroDoDocumento.Length != TamanhoMaximo)
            throw new ArgumentException($"Documento deve conter {TamanhoMaximo} digitos.");

        int soma = 0;

        for (int i = 0; i < digito1.Length; i++)
            soma += int.Parse(numeroDoDocumento[i].ToString()) * digito1[i];

        int resto = soma % 11;

        string digito = resto < 2 ? "0" : (11 - resto).ToString();

        if (digito2.Length > 0)
        {
            soma = 0;

            for (int i = 0; i < digito2.Length; i++)
                soma += int.Parse(numeroDoDocumento[i].ToString()) * digito2[i];

            resto = soma % 11;

            digito += resto < 2 ? "0" : (11 - resto).ToString();
        }

        return numeroDoDocumento.EndsWith(digito);
    }

    public virtual string ObterDocumentoCompleto()
    {
        return numeroDoDocumento;
    }

    public virtual string ObterDocumentoFormatado()
    {
        return numeroDoDocumento;
    }
    public virtual string ObterDigitosVerificadores()
    {
        return digitosValidados;
    }

}
