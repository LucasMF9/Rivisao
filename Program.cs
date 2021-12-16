using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }

               

                opcaoUsuario = ObterOpcaoUsuario();
            }

            static string ObterOpcaoUsuario()
            {
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Inserir novo aluno:");
                Console.WriteLine("2- listar alunos:");
                Console.WriteLine("3- Calcular média geral:");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
            }
        }
    }
}
