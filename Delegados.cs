using System;

namespace NetCoreConsole
{
    public class Delegados
    {
        delegate int delegaTeste(int a, int b);
        delegate TR delegaGenerico<in T1, in T2, out TR>(T1 param1, T2 param2);

        // delegates prontos
        // ACTION recebe parâmetros mas só pode retornar void
        Action<string> action = ImprimeString;

        // PREDICATE recebe somente um parâmetro e só pode retornar boolean
        Predicate<int> predicate = NumeroPar;

        // FUNCTION recebe até 16parametros e o retorno será sempre o tipo do ultimo parâmetro
        Func<int, int, int> exFunc = CalculaMedia;

        public Delegados() 
        {
            Iniciar();
        }

        private void Iniciar()
        {
            delegaTeste del1 = CalculaMedia;
            delegaGenerico<int,int,int> delGen = CalculaMedia;

            //delegaGenerico<int, int, int> delCalcula = Calcula;
            del1(1, 1);


            // delegates prontos
            action("teste");
            predicate(2);
            exFunc(1,2);

        }

        private static int CalculaMedia(int a, int b)
        {
            var result = Soma(a,b);

            int Soma(int a, int b)
            {
                return a+b;
            }

            return result;
        }

        private static bool NumeroPar(int numero)
        {
            return (numero % 2) == 0;
        }

        private static void ImprimeString(string message)
        {
            Console.WriteLine(message);
        }


    }



    
}