using System;
using System.Reflection;

namespace NetCoreConsole
{

    public class Eventos
    {
        delegate int EfetuarOperacao(int a, int b);
        delegate void OperacaoEfetuada(string op, int res);
        static event OperacaoEfetuada AoEfeturarOperacao;

        public Eventos()
        {
        }

        public void ExecutarEventos()
        {

            EfetuarOperacao efetuarOperacao = Soma;
            efetuarOperacao += Subtracao;
            efetuarOperacao += Multiplicacao;
            efetuarOperacao += Divisao;
            efetuarOperacao += Media;

            // aponta para qual metodo o evento vai executar
            AoEfeturarOperacao = ResultadoNaTela;
            AoEfeturarOperacao += SeparadorNaTela;

            efetuarOperacao(20, 10);


        }



        public static int Media(int p1, int p2)
        {
            var result = (p1 + p2) / 2;
            AoEfeturarOperacao.Invoke(MethodBase.GetCurrentMethod().Name, result);
            return result;
        }

        public static int Soma(int p1, int p2)
        {
            var result = p1 + p2;
            AoEfeturarOperacao.Invoke(MethodBase.GetCurrentMethod().Name, result);
            return result;
        }

        public static int Subtracao(int p1, int p2)
        {
            var result = p1 - p2;
            AoEfeturarOperacao.Invoke(MethodBase.GetCurrentMethod().Name, result);
            return result;
        }

        public static int Multiplicacao(int p1, int p2)
        {
            var result = p1 * p2;
            AoEfeturarOperacao.Invoke(MethodBase.GetCurrentMethod().Name, result);
            return result;
        }

        public static int Divisao(int p1, int p2)
        {
            var result = p1 / p2;
            AoEfeturarOperacao.Invoke(MethodBase.GetCurrentMethod().Name, result);
            return result;
        }

        public void ResultadoNaTela(string operacao, int resultado)
        {
            Console.WriteLine($"{operacao} Resultado: {resultado}");
        }

        public void SeparadorNaTela(string operacao, int resultado)
        {
            Console.WriteLine(new string('*', 20));
        }


    }

}