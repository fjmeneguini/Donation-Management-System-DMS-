using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente();
            Paciente paciente2 = new Paciente();

            paciente1.setDados("Rafaela", 60, 1.64);
            paciente1.gerarRelatorio();

            Console.WriteLine("\n");

            paciente2.setDados("Fê", 80, 1.75);
            paciente2.gerarRelatorio();



        }
    }
}
