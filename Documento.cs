public class Documento
{
    protected string numeroDoDocumento;

    protected virtual int TamanhoMaximo => int.MaxValue;


    public Documento(string numeroDoDocumento)
    {
        this.numeroDoDocumento = numeroDoDocumento;
    }

    public virtual void CalcularDigitoVerificador()
    {
    }

    public virtual bool ValidarDocumento()
    {
        return false;
    }

    public virtual string ObterDocumentoCompleto()
    {
        return numeroDoDocumento.PadLeft(TamanhoMaximo, '0');
    }

    public virtual string ObterDocumentoFormatado()
    {
        return numeroDoDocumento.PadLeft(TamanhoMaximo, '0');
    }

}
