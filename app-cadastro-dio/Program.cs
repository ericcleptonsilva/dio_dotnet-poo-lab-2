using System;

namespace app_cadastro_dio
{
    class Program
    {


        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        EntradaFilmes.EntradaFilmesUser();
                        break;
                    case "2":
                        EntradaSeries.EntradaSeriesUser();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Media Center a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Filmes");
            Console.WriteLine("2- Series");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }


    }
}

