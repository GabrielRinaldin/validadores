namespace Tests;

public class UnitTest1
{

    /*Testes Validos*/
    [Fact]
    public void TestCpfValido()
    {
        string numeroDoDocumento = "568.894.680-66";
        string? tipoDocumento = null;
        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

        Dictionary<string, Func<string, Documento>> DocumentosValidados = new Dictionary<string, Func<string, Documento>>
        {
            { "9", value => new Cpf(value) },
            { "11", value => new Cpf(value) },
            { "Cpf", value => new Cpf(value) },

            { "12", value => new Cnpj(value) },
            { "14", value => new Cnpj(value) },
            { "Cnpj", value => new Cnpj(value) },

            { "8", value => new InscricaoEstadualParana(value) },
            { "10", value => new InscricaoEstadualParana(value) },
            { "InscricaoEstadualParana", value => new InscricaoEstadualParana(value) },

            { "Pis", value => new Pis(value) },
            { "Titulo", value => new Pis(value) },
        };

        string tipoDeBusca = tipoDocumento == null ? numeroDoDocumento.Length.ToString() : tipoDocumento;

        if (DocumentosValidados.TryGetValue(tipoDeBusca, out var criarDocumento))
        {
            Documento documento = criarDocumento(numeroDoDocumento);

            if (documento.numeroDoDocumento.Length < documento.TamanhoMaximo)
            {
                Assert.Equal(documento.CalcularDigitoVerificador().Length, documento.TamanhoMaximo);
            }
            else
            {
                Assert.True(documento.ValidarDocumento());
            }
        }
    }

    [Fact]
    public void TestCnpjValido()
    {
        string numeroDoDocumento = "01.072.596/0001-06";
        string? tipoDocumento = null;
        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

        Dictionary<string, Func<string, Documento>> DocumentosValidados = new Dictionary<string, Func<string, Documento>>
        {
            { "9", value => new Cpf(value) },
            { "11", value => new Cpf(value) },
            { "Cpf", value => new Cpf(value) },

            { "12", value => new Cnpj(value) },
            { "14", value => new Cnpj(value) },
            { "Cnpj", value => new Cnpj(value) },

            { "8", value => new InscricaoEstadualParana(value) },
            { "10", value => new InscricaoEstadualParana(value) },
            { "InscricaoEstadualParana", value => new InscricaoEstadualParana(value) },

            { "Pis", value => new Pis(value) },
            { "Titulo", value => new Pis(value) },
        };

        string tipoDeBusca = tipoDocumento == null ? numeroDoDocumento.Length.ToString() : tipoDocumento;

        if (DocumentosValidados.TryGetValue(tipoDeBusca, out var criarDocumento))
        {
            Documento documento = criarDocumento(numeroDoDocumento);

            if (documento.numeroDoDocumento.Length < documento.TamanhoMaximo)
            {
                Assert.Equal(documento.CalcularDigitoVerificador().Length, documento.TamanhoMaximo);
            }
            else
            {
                Assert.True(documento.ValidarDocumento());
            }
        }
    }













    [Fact]
    public void TestCpfInvalido()
    {
        string numeroDoDocumento = "568.894.680-69";
        string? tipoDocumento = null;
        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

        Dictionary<string, Func<string, Documento>> DocumentosValidados = new Dictionary<string, Func<string, Documento>>
        {
            { "9", value => new Cpf(value) },
            { "11", value => new Cpf(value) },
            { "Cpf", value => new Cpf(value) },

            { "12", value => new Cnpj(value) },
            { "14", value => new Cnpj(value) },
            { "Cnpj", value => new Cnpj(value) },

            { "8", value => new InscricaoEstadualParana(value) },
            { "10", value => new InscricaoEstadualParana(value) },
            { "InscricaoEstadualParana", value => new InscricaoEstadualParana(value) },

            { "Pis", value => new Pis(value) },
            { "Titulo", value => new Pis(value) },
        };

        string tipoDeBusca = tipoDocumento == null ? numeroDoDocumento.Length.ToString() : tipoDocumento;

        if (DocumentosValidados.TryGetValue(tipoDeBusca, out var criarDocumento))
        {
            Documento documento = criarDocumento(numeroDoDocumento);

            if (documento.numeroDoDocumento.Length < documento.TamanhoMaximo)
            {
                Assert.Equal(documento.CalcularDigitoVerificador().Length, documento.TamanhoMaximo);
            }
            else
            {
                Assert.False(documento.ValidarDocumento());
            }
        }
    }

    [Fact]
    public void TestCpfDigitoVerificador()
    {
        string numeroDoDocumento = "568.894.680";
        string? tipoDocumento = null;
        numeroDoDocumento = numeroDoDocumento.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

        Dictionary<string, Func<string, Documento>> DocumentosValidados = new Dictionary<string, Func<string, Documento>>
        {
            { "9", value => new Cpf(value) },
            { "11", value => new Cpf(value) },
            { "Cpf", value => new Cpf(value) },

            { "12", value => new Cnpj(value) },
            { "14", value => new Cnpj(value) },
            { "Cnpj", value => new Cnpj(value) },

            { "8", value => new InscricaoEstadualParana(value) },
            { "10", value => new InscricaoEstadualParana(value) },
            { "InscricaoEstadualParana", value => new InscricaoEstadualParana(value) },

            { "Pis", value => new Pis(value) },
            { "Titulo", value => new Pis(value) },
        };

        string tipoDeBusca = tipoDocumento == null ? numeroDoDocumento.Length.ToString() : tipoDocumento;

        if (DocumentosValidados.TryGetValue(tipoDeBusca, out var criarDocumento))
        {
            Documento documento = criarDocumento(numeroDoDocumento);

            if (documento.numeroDoDocumento.Length < documento.TamanhoMaximo)
            {
                Assert.Equal(documento.CalcularDigitoVerificador().Length, documento.TamanhoMaximo);
            }
            else
            {
                Assert.False(documento.ValidarDocumento());
            }
        }
    }

}