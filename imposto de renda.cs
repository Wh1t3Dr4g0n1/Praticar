// Imposto de Renda
//
//
//
//
//
//
//
//
//
//



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static void Main(string[] args)
        {
            //variáveis para entrada(rendimentos), imposto de renda e alíquota efetiva.
            //inicar a variavel impostoDeRenda com 0 para evitar o erro CS0165.
            //Foi utilizado https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/compiler-messages/cs0165 para resolver o erro.
            double impostoDeRenda = 0, entrada, aliquotaEfetiva;

            Console.WriteLine("======================================================================");
            Console.WriteLine("Diga seus rendimentos mensais para que eu calcule seu imposto de renda");
            Console.Write("Rendimentos Mensais: ");
            entrada = Convert.ToDouble(Console.ReadLine());

            //Dados retirados de https://www.gov.br/receitafederal/pt-br/assuntos/meu-imposto-de-renda/tabelas/copy_of_2024.

            if (entrada <= 2259.20)
            {
                Console.Clear();
                impostoDeRenda = 0;
                Console.WriteLine("==========================");
                Console.WriteLine("    Você está insento.    ");
                Console.WriteLine("==========================");
                Console.WriteLine("(aperta enter até sair...)");
            }

            else if (entrada <= 2826.65)
            {
                Console.Clear();
                Console.WriteLine("============================");
                impostoDeRenda = (entrada - 2259.20) * 0.075 - 169.44;
                Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
            }

            else if (entrada <= 3751.05)
            {
                Console.Clear();
                Console.WriteLine("============================");
                impostoDeRenda = (entrada - 2826.65) * 0.15 - 381.44;
                Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
            }

            else if (entrada <= 4664.68)
            {
                Console.Clear();
                Console.WriteLine("============================");
                impostoDeRenda = (entrada - 3751.05) * 0.225 - 662.77;
                Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
            }

            else

            {
                Console.Clear();
                Console.WriteLine("============================");
                impostoDeRenda = (entrada - 4664.68) * 0.275 - 896.00;
                Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
            }

            if (entrada > 0)
            {
                Console.WriteLine("============================");
                aliquotaEfetiva = impostoDeRenda / entrada * 100;
                Console.WriteLine($"Alíquota Efetiva: {aliquotaEfetiva:F2}%");
                Console.WriteLine("==========================");
                Console.WriteLine("(aperta enter até sair...)");
            }
            //Foi Utilizado Interpolação de string para facilitar a leitura do código e garantindo a formatação adequada dos números e porcentagens. 
            //https://learn.microsoft.com/pt-br/dotnet/csharp/tutorials/string-interpolation

            Console.ReadKey();
        }
    }
}
