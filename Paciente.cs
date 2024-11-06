using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Paciente
    {
        private string nome;
        private double peso;
        private double altura;

        
        public Paciente()
        {
            string nome = "Desconhecido";
            double peso = 0.0;
            double altura = 0.0;
        }

        public string getNome()
        {
            return nome;
        }

        public double getPeso()
        {
            return peso;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setDados(string nome, double peso, double altura)
        {
            this.nome = nome;

            if (peso > 20.0 && peso < 180.0)
            {
                this.peso = peso;
            }

            if (altura > 0.6 && altura < 2.5)
            {
                this.altura = altura;
            }

        }

        public double calcularIMC()
        {
            double imc = peso / (altura * altura);
            return imc;
        }

        public string avaliacaoIMC()
        {
            if (calcularIMC() < 17.0)
            {
                return "Muito abaixo do peso";
            }

            if (calcularIMC() >= 17 && calcularIMC() <= 18.49)
            {
                return "Abaixo do peso";
            }

            if (calcularIMC() >= 18.5 && calcularIMC() <= 24.99)
            {
                return "Peso Normal";
            }

            if (calcularIMC() >= 25 && calcularIMC() <= 29.99)
            {
                return "Acima do peso";
            }

            if (calcularIMC() >= 30 && calcularIMC() <= 34.99)
            {
                return "Obesidade I";
            }

            if (calcularIMC() >= 35 && calcularIMC() <= 39.99)
            {
                return "Obesidade II (severa)";
            }

            if (calcularIMC() >= 40)
            {
                return "Obesidade III (mórbida)";
            }

            else
            {
                return null;
            }
        }

        public void gerarRelatorio()
        {
            Console.WriteLine("Nome: {0}", getNome());
            Console.WriteLine("Peso: {0}", getPeso());
            Console.WriteLine("Altura: {0}", getAltura());
            Console.WriteLine("IMC: {0}", calcularIMC());
            Console.WriteLine("Avaliação: {0}", avaliacaoIMC());
        }

    }
}
