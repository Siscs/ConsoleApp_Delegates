using System;

namespace NetCoreConsole
{   
    public class Program
    {
        public delegate void MostrarAno(int valor);

        public delegate string DelegatePessoa(string valor);

        public static void Main(string[] args)
        {

            // DelegadoSimples1();
            DelegadoSimples2();

        }

        private static void DelegadoSimples1()
        {
            Carro carro = new Carro();
            Moto moto = new Moto();

            MostrarAno mostrarAno = new MostrarAno(carro.AnoCarro);

            mostrarAno(2011);

            mostrarAno = new MostrarAno(moto.AnoMoto);

            mostrarAno(2014);
        }

        private static void DelegadoSimples2()
        {
            PessoaFisica pf =new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();

            DelegatePessoa delegatePessoa = new DelegatePessoa(pf.MostrarSimples);

            delegatePessoa.Invoke("Cesar Silva");

            delegatePessoa = new DelegatePessoa(pj.MostrarNomeCompleto);

            delegatePessoa.Invoke("Cesar Silva PJ");

        }

    }

    public class Carro
    {
        public Carro() {}

        public void AnoCarro(int ano)
        {
            Console.WriteLine($"Ano do Carro: {ano}" );
        }
    }

    public class Moto
    {
        public Moto() {}

        public void AnoMoto(int ano)
        {
            Console.WriteLine($"Ano da Moto: {ano}" );
        }
    }


}
