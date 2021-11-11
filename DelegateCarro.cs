using System;
using System.Collections.Generic;

namespace NetCoreConsole
{
    public class DelegateCarro
    {

        private Dictionary<string, Action> acoesCarro = new Dictionary<string, Action>();

        public void IniciarCarro()
        {
            acoesCarro.Add("ligar", Ligar);
            acoesCarro.Add("acelerar", Acelerar);
            acoesCarro.Add("parar", Parar);
            acoesCarro.Add("virar", Virar);
            acoesCarro.Add("trocarMarcha", TrocarMarcha);
            acoesCarro.Add("desligar", Desligar);
            acoesCarro.Add("", null);

            bool execute = true;
            do 
            {
                Console.Write("Digite uma acao: ");
                var acao = Console.ReadLine().ToLower();

                if(acao=="sair")
                {
                    execute = false;
                } else {
                    if(!string.IsNullOrEmpty(acao) && acoesCarro.ContainsKey(acao) )
                        acoesCarro[acao].Invoke();
                }
               

            } while(execute);

        }

        private void Ligar() => Console.WriteLine("Ligar o Carro");
        private void Acelerar() => Console.WriteLine("Acelerar o Carro");
        private void Parar() => Console.WriteLine("Parar o Carro");
        private void Virar() => Console.WriteLine("Virar o Carro");
        private void TrocarMarcha() => Console.WriteLine("Trocar Marcha Carro");
        private void Desligar() => Console.WriteLine("Desligar o Carro");



    }
}