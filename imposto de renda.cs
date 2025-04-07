// Imposto de Renda

// Linha de raciocínio
// 
// 1. Início 
// 2. var impostoDeRenda, entrada, aliquotaEfetiva = double
// 3. Mostrar "mensagem pedindo o rendimento mensal"
// 4. Se o imposto for == 0 a 2259,20 --> isento
// 5. Mostrar "está isento"
// 6. Se o imposto for de 2259,20 a 2826,65 --> impostoDeRenda * 0.075 - 169.44
// 7. Mostrar "imposto de renda (resultado)"
// 8. Se o imposto for de 2826,65 a 3751,05 --> impostoDeRenda * 0.15 = 381.44
// 9. Mostrar "imposto de renda (resultado)"
// 10. Se o imposto for de 3751,05 a 4664,68 --> impostoDeRenda * 0.225 - 662.77
// 11. Mostrar "imposto de renda (resultado)"
// 12. Se o imposto for de 4664,68 a acima --> impostoDeRenda * 0.275 - 896.00
// 13. Mostrar "imposto de renda (resultado)"
// 14. Se entrada for maior que 0, calcular alíquota --> impostoDeRenda / entrada * 100
// 15. Mostrar "Alíquota Efetiva"
// 16. Fim


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

            string refazer;
            double impostoDeRenda = 0, entrada, aliquotaEfetiva;

            do
            {
                Console.Clear();
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
                    impostoDeRenda = entrada * 0.075 - 169.44;
                    Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
                }

                else if (entrada <= 3751.05)
                {
                    Console.Clear();
                    Console.WriteLine("============================");
                    impostoDeRenda = entrada * 0.15 - 381.44;
                    Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
                }

                else if (entrada <= 4664.68)
                {
                    Console.Clear();
                    Console.WriteLine("============================");
                    impostoDeRenda = entrada * 0.225 - 662.77;
                    Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
                }

                else

                {
                    Console.Clear();
                    Console.WriteLine("============================");
                    impostoDeRenda = entrada * 0.275 - 896.00;
                    Console.WriteLine($"Imposto devido: {impostoDeRenda:F2}");
                }

                if (entrada > 0)
                {
                    Console.WriteLine("============================");
                    aliquotaEfetiva = impostoDeRenda / entrada * 100;
                    Console.WriteLine($"Alíquota Efetiva: {aliquotaEfetiva:F2}%");
                    Console.WriteLine("============================");
                    Console.WriteLine("(aperta enter até sair...)");
                    Console.ReadKey();
                }

                //Foi Utilizado Interpolação de string para facilitar a leitura do código e garantindo a formatação adequada dos números e porcentagens. 
                //https://learn.microsoft.com/pt-br/dotnet/csharp/tutorials/string-interpolation
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("deseja refazer o cálculo (S/N)?: ");
                refazer = Console.ReadLine();
            }
            while (refazer == "s" || refazer == "S" || refazer == "sim" || refazer == "Sim");
            Console.ReadKey();
        }
    }
}
