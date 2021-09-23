using System;

namespace NetCoreConsole
{
    public class PessoaJuridica
    {

        private const string TIPO = "Juridica";

        public PessoaJuridica() {}

        public string MostrarNomeCompleto(string nomeCompleto)
        {
            Console.WriteLine($"Tipo: {TIPO}");
            Console.WriteLine("Nome Completo: {0}", nomeCompleto);   
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