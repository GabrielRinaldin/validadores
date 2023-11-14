class Program
{
    static void Main()
    {
        // TestarCPF();
        // TestarCNPJ();
        // TestarInscricaoEstadual();
        // TestarPis();
        TestarTitulo();
    }

    static void TestarCPF()
    {
        try
        {
            Cpf cpf = new Cpf("446.840.350");
            cpf.CalcularDigitoVerificador();

            Console.WriteLine($"CPF completo: {cpf.ObterDocumentoCompleto()}");
            Console.WriteLine($"CPF formatado: {cpf.ObterDocumentoFormatado()}");
            Console.WriteLine($"CPF válido: {cpf.ValidarDocumento()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
    static void TestarCNPJ()
    {
        try
        {
            Cnpj cnpj = new Cnpj("06.947.283/0001");
            cnpj.CalcularDigitoVerificador();

            Console.WriteLine($"Cnpj completo: {cnpj.ObterDocumentoCompleto()}");
            Console.WriteLine($"Cnpj formatado: {cnpj.ObterDocumentoFormatado()}");
            Console.WriteLine($"Cnpj válido: {cnpj.ValidarDocumento()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void TestarInscricaoEstadual()
    {
        try
        {
            InscricaoEstadualParana iep = new InscricaoEstadualParana("12345678");
            iep.CalcularDigitoVerificador();

            Console.WriteLine($"Inscrição Estadual completo: {iep.ObterDocumentoCompleto()}");
            Console.WriteLine($"Inscrição Estadual formatado: {iep.ObterDocumentoFormatado()}");
            Console.WriteLine($"Inscrição Estadual válido: {iep.ValidarDocumento()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
    static void TestarPis()
    {
        try
        {
            Pis pis = new Pis("398.65056.37");
            pis.CalcularDigitoVerificador();

            Console.WriteLine($"Pis completo: {pis.ObterDocumentoCompleto()}");
            Console.WriteLine($"Pis formatado: {pis.ObterDocumentoFormatado()}");
            Console.WriteLine($"Pis válido: {pis.ValidarDocumento()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
    static void TestarTitulo()
    {
        try
        {
            TituloEleitor titulo = new TituloEleitor("7846992406");
            titulo.CalcularDigitoVerificador();

            Console.WriteLine($"titulo completo: {titulo.ObterDocumentoCompleto()}");
            Console.WriteLine($"titulo formatado: {titulo.ObterDocumentoFormatado()}");
            Console.WriteLine($"titulo válido: {titulo.ValidarDocumento()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}