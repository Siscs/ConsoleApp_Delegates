using System;

namespace NetCoreConsole
{
    public class PessoaFisica
    {
        private const string TIPO = "Fisica";

        public PessoaFisica() {}

        public string MostrarNomeCompleto(string nomeCompleto)
        {
            string teste = @"\teste";

            Console.WriteLine($"Tipo: {TIPO}");
            Console.WriteLine("Nome Completo: {0}", nomeCompleto);   
            Console.WriteLine($"Tipo: {teste}");
            return nomeCompleto;
        }

        public string MostrarSimples(string nomeSimples)
        {
            Console.WriteLine($"Tipo: {TIPO}");
            Console.WriteLine("Nome Simples: {0}", nomeSimples);   
            return nomeSimples;
        }   
    }
}