using System;
namespace TerceiraAtividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*1: Salário do Funcionário*/
            
            /*
            int numFuncionario;
            int horasTrabalhadas;
            double salarioPorHora;

            Console.WriteLine("Insira o número do funcionário:");
            numFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de horas trabalhadas pelo funcionário:");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o salário deste funcionário por hora:");
            salarioPorHora = double.Parse(Console.ReadLine());

            double salarioFinal = horasTrabalhadas * salarioPorHora;

            Console.WriteLine("O salário final do funcionário " + numFuncionario + " é igual à: R$" + salarioFinal.ToString("F2"));
            */
            
            
            
            /*2: Custo da Peça*/
            
            /*
            int codigoPeca1 = 101;
            int codigoPeca2 = 404;

            Console.WriteLine("Insira o código da peça");
            int codigoPecaInserido = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de peças: ");
            int numeroPecas = int.Parse(Console.ReadLine());

            if (codigoPecaInserido == codigoPeca1)
            {
            Console.WriteLine("Insira o valor da peça 1");
                double valorUnitario = double.Parse(Console.ReadLine());

                double valorPagar = valorUnitario * numeroPecas;
                Console.WriteLine("O valor à pagar referente às: " + numeroPecas + " peças do tipo: Peça - 1 é igual à: R$" + valorPagar);
            } else if (codigoPecaInserido == codigoPeca2)
            {
                Console.WriteLine("Insira o valor da peça 2");
                double valorUnitario = double.Parse(Console.ReadLine());

                double valorPagar = valorUnitario * numeroPecas;
                Console.WriteLine("O valor à pagar referente às: " + numeroPecas + " peças do tipo: Peça - 2 é igual à: R$" + valorPagar);
            }
            */
            
            
            
            /*3 Calculo das Fórmulas*/
            
            /*
            Console.WriteLine("Insira o valor A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor C:");
            double C = double.Parse(Console.ReadLine());

            double areaTriangulo = A * C / 2.0;
            Console.WriteLine("\nÁrea do triângulo usando A * C / 2.0: " + areaTriangulo.ToString("F2"));

            double areaCirculo = 3.14159 * C * C;
            Console.WriteLine("\nÁrea do círculo usando PI * C * C: " + areaCirculo.ToString("F2"));

            double areaTrapezio = (A + B) / 2.0 * C;
            Console.WriteLine("\nÁrea do trapézio usando (A + B) / 2.0 * C: " + areaTrapezio.ToString("F2"));

            double areaQuadrado = B * B;
            Console.WriteLine("\nÁrea do quadrado usando B * B: " + areaQuadrado.ToString("F2"));

            double areaRetangulo = A * B;
            Console.WriteLine("\nÁrea do retângulo usando A * B: " + areaRetangulo.ToString("F2"));
            */
        }
    }
}