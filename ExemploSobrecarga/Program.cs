using System;

namespace ExemploSobrecarga
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("P1: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.Write("P2: ");
            double p2 = double.Parse(Console.ReadLine());

            // possibilidade 1
            {
                Aluno aluno = new Aluno(nome, p1, p2);

                double media = aluno.Media;
                bool aprovado = aluno.GetAprovado();

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.Nome, aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 2
            {
                Aluno aluno = new Aluno(nome);
                aluno.P1 = p1;
                aluno.P2 = p2;

                double media = aluno.Media;
                bool aprovado = aluno.GetAprovado();

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.Nome, aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 3
            {
                Aluno aluno = new Aluno(nome, p1, p2);

                double media = aluno.Media;
                bool aprovado = aluno.GetAprovado(media);

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.Nome, aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 4
            {
                Aluno aluno = new Aluno(nome);
                aluno.P1 = p1;
                aluno.P2 = p2;

                double media = aluno.Media;
                bool aprovado = aluno.GetAprovado(media);

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.Nome, aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 5 - usando a propriedade Aprovado
            {
                Aluno aluno = new Aluno(nome, p1, p2);

                double media = aluno.Media;
                bool aprovado = aluno.Aprovado;

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.Nome, aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 6 - usando a propriedade Aprovado
            {
                Aluno aluno = new Aluno(nome);
                aluno.P1 = p1;
                aluno.P2 = p2;

                double media = aluno.Media;
                bool aprovado = aluno.Aprovado;

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.Nome, aprovado ? "aprovado" : "reprovado", media);
            }
        }
    }
}
