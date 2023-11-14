using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Testar();
    }

    static void Testar()
    {
        string numeroDoDocumento = "073130709";

        Dictionary<int, Func<string, Documento>> DocumentosValidados = new Dictionary<int, Func<string, Documento>>
        {
            { 9, value => new Cpf(value) },
            { 14, value => new Cnpj(value) }
        };

        if (DocumentosValidados.TryGetValue(numeroDoDocumento.Length, out var criarDocumento))
        {
            try
            {
                Documento documento = criarDocumento(numeroDoDocumento);

                documento.CalcularDigitoVerificador();
                Console.WriteLine($"{documento.Tipo}: {documento.ObterDocumentoCompleto()}");
                Console.WriteLine($"{documento.Tipo} formatado: {documento.ObterDocumentoFormatado()}");
                Console.WriteLine($"{documento.Tipo} válido: {documento.ValidarDocumento()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"Não há classe associada ao tamanho do documento {numeroDoDocumento.Length}");
        }
    }
}
