namespace Tests;

public class UnitTest1
{


    /*Testes De Validação Sucedido*/
    [Fact]
    public void TestPisValido()
    {
        string numeroDoDocumento = "711.46595.16-4";
        string? tipoDocumento = "Pis";
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
            { "Titulo", value => new TituloEleitor(value) },
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
            { "Titulo", value => new TituloEleitor(value) },
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestInscricaoEstadualValido()
    {
        string numeroDoDocumento = "285.93003-00";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestTituloValido()
    {
        string numeroDoDocumento = "287370331201";
        string? tipoDocumento = "Titulo";
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
            { "Titulo", value => new TituloEleitor(value) },
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


    /*Testes De Validação sem Sucesso*/

    [Fact]
    public void TestCpfInvalido()
    {
        string numeroDoDocumento = "511.830.300-99";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestPisInvalido()
    {
        string numeroDoDocumento = "358.39010.84-6";
        string? tipoDocumento = "Pis";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestCnpjInvalido()
    {
        string numeroDoDocumento = "71.723.756/0001-01";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestInscricaoEstadualInvalido()
    {
        string numeroDoDocumento = "852.30886-24";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestTituloInvalido()
    {
        string numeroDoDocumento = "550681720189";
        string? tipoDocumento = "Titulo";
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
            { "Titulo", value => new TituloEleitor(value) },
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

    /*Testes para Calcular Digito Verificador*/
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestPisVerificador()
    {
        string numeroDoDocumento = "163.43757.13";
        string? tipoDocumento = "Pis";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestCnpjVerificador()
    {
        string numeroDoDocumento = "96.875.226/0001";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestInscricaoEstadualVerificador()
    {
        string numeroDoDocumento = "64.956.85";
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
            { "Titulo", value => new TituloEleitor(value) },
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
    public void TestTituloVerificador()
    {
        string numeroDoDocumento = "1846567819";
        string? tipoDocumento = "Titulo";
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
            { "Titulo", value => new TituloEleitor(value) },
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
}