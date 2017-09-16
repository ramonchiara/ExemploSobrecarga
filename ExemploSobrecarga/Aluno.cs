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

        public string Nome
        {
            get
            {
                {
                    return nome;
                }
            }
        }

        public double P1
        {
            set
            {
                this.p1 = value;
            }
        }

        public double P2
        {
            set
            {
                this.p2 = value;
            }
        }

        public double Media
        {
            get
            {
                return (p1 + p2) / 2;
            }
        }

        // ATENÇÃO: não podemos sobrecarregar propriedades!

        public bool GetAprovado()
        {
            double media = Media;
            return GetAprovado(media);
        }

        public bool GetAprovado(double media)
        {
            return media >= 6;
        }

        // Podemos até manter a propriedade abaixo, mas não é uma sobrecarga!

        public bool Aprovado
        {
            get
            {
                return Media >= 6.0;
            }
        }
    }
}
