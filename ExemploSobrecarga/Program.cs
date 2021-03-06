﻿using System;

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

                double media = aluno.GetMedia();
                bool aprovado = aluno.GetAprovado();

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.GetNome(), aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 2
            {
                Aluno aluno = new Aluno(nome);
                aluno.SetP1(p1);
                aluno.SetP2(p2);

                double media = aluno.GetMedia();
                bool aprovado = aluno.GetAprovado();

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.GetNome(), aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 3
            {
                Aluno aluno = new Aluno(nome, p1, p2);

                double media = aluno.GetMedia();
                bool aprovado = aluno.GetAprovado(media);

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.GetNome(), aprovado ? "aprovado" : "reprovado", media);
            }

            // possibilidade 4
            {
                Aluno aluno = new Aluno(nome);
                aluno.SetP1(p1);
                aluno.SetP2(p2);

                double media = aluno.GetMedia();
                bool aprovado = aluno.GetAprovado(media);

                Console.WriteLine("O Aluno {0} está {1} com média {2}", aluno.GetNome(), aprovado ? "aprovado" : "reprovado", media);
            }
        }
    }
}
