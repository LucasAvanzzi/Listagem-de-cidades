using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cidades = new ArrayList();
            cidades.Add("1-Atibaia");
            cidades.Add("2-Bragança Paulista");
            cidades.Add("3-Mairiporã");
            cidades.Add("4-Nazaré");
            cidades.Add("5-São Paulo");
            cidades.Add("6-Piracaia");
            cidades.Add("7-Bom Jesus dos Perdões");

            ArrayList codCidade = new ArrayList();
            codCidade.Add("1");
            codCidade.Add("2");
            codCidade.Add("3");
            codCidade.Add("4");
            codCidade.Add("5");
            codCidade.Add("6");
            codCidade.Add("7");

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.WriteLine("\n" + "Digite o Codigo da cidade");
            var codDigitado = Console.ReadLine();

            Console.WriteLine("\n" + "Digite a data");
            var dataDigitado = Console.ReadLine();

            if (codDigitado == "1")
            {
                Console.WriteLine("\n" + cidades[0] + " " + dataDigitado);


            }
            else if (codDigitado == "2")
            {
                Console.WriteLine("\n" + cidades[1] + " " + dataDigitado);
            }
            else if (codDigitado == "3")
            {
                Console.WriteLine("\n" + cidades[2] + " " + dataDigitado);
            }
            else if (codDigitado == "4")
            {
                Console.WriteLine("\n" + cidades[3] + " " + dataDigitado);
            }
            else if (codDigitado == "5")
            {
                Console.WriteLine("\n" + cidades[4] + " " + dataDigitado);
            }
            else if (codDigitado == "6")
            {
                Console.WriteLine("\n" + cidades[5] + " " + dataDigitado);
            }
            else
            {
                Console.WriteLine("\n" + cidades[6] + " " + dataDigitado);
            }

            Console.ReadKey();

        }
    }
}
       