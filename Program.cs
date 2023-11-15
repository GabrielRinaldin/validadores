using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Testar("287370331201", "Titulo");
    }

    static void Testar(string numeroDoDocumento, string? tipoDocumento = null)
    {
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
                documento.CalcularDigitoVerificador();
            }
            else
            {
                Console.WriteLine($"{documento.Tipo} válido: {documento.ValidarDocumento()}");
            }

            Console.WriteLine($"{documento.Tipo}: {documento.ObterDocumentoCompleto()}");
            Console.WriteLine($"{documento.Tipo} formatado: {documento.ObterDocumentoFormatado()}");
        }
        else
        {
            Console.WriteLine($"Não há classe associada ao tipo de documento {tipoDocumento}");
        }
    }
}
