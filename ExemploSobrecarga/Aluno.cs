using System;
namespace ExemploSobrecarga
{
    public class Aluno
    {
        private string nome;
        private double p1;
        private double p2;

        public Aluno(string nome, double p1, double p2)
        {
            this.nome = nome;
            this.p1 = p1;
            this.p2 = p2;
        }

        public Aluno(String nome) : this(nome, 0, 0)
        {
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetP1(double p1)
        {
            this.p1 = p1;
        }

        public void SetP2(double p2)
        {
            this.p2 = p2;
        }

        public double GetMedia()
        {
            return (p1 + p2) / 2;
        }

        public bool GetAprovado()
        {
            double media = GetMedia();
            return GetAprovado(media);
        }

        public bool GetAprovado(double media)
        {
            return media >= 6;
        }
    }
}
