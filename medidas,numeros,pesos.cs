using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wadawodnbqwifbnqw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora que calcula.
            // Medidas, números, pesos. 

            // medidas
            string blu, blue, med1, med2;
            double total, num;
            // numeros
            double numi, nume, adi, sub, multi, divi;
            // pesos


            Console.WriteLine("===================================");
            Console.WriteLine("Essa é uma calculadora que calcula.");
            Console.Write("medidas / numeros / pesos: ");
            blue = Console.ReadLine();

            // MEDIDASd

            if (blue == "medidas")
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("Escolha a medida atual.");
                Console.Write("mm / cm / dm / m / dam / hm / km: ");
                med1 = Console.ReadLine();
                Console.WriteLine("===================================");
                Console.WriteLine("Escolha para qual deseja converter:");
                Console.Write("mm / cm / dm / m / dam / hm / km: ");
                med2 = Console.ReadLine();
                Console.Write("me dê o número: ");
                num = int.Parse(Console.ReadLine());
                
                // Milimetro

                if (med1 == "mm" && med2 == "cm")
                {
                    Console.Clear();
                    total = num * 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "mm" && med2 == "dm")
                {
                    Console.Clear();
                    total = num * 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "mm" && med2 == "m")
                {
                    Console.Clear();
                    total = num * 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "mm" && med2 == "dam")
                {
                    Console.Clear();
                    total = num * 10000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "mm" && med2 == "hm")
                {
                    Console.Clear();
                    total = num * 100000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "mm" && med2 == "km")
                {
                    Console.Clear();
                    total = num * 1000000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Centimetro

                if (med1 == "cm" && med2 == "dm")
                {
                    Console.Clear();
                    total = num * 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "cm" && med2 == "m")
                {
                    Console.Clear();
                    total = num * 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "cm" && med2 == "dam")
                {
                    Console.Clear();
                    total = num * 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "cm" && med2 == "hm")
                {
                    Console.Clear();
                    total = num * 10000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "cm" && med2 == "km")
                {
                    Console.Clear();
                    total = num * 100000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Decametro

                if (med1 == "dm" && med2 == "m")
                {
                    Console.Clear();
                    total = num * 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dm" && med2 == "dam")
                {
                    Console.Clear();
                    total = num * 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dm" && med2 == "hm")
                {
                    Console.Clear();
                    total = num * 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dm" && med2 == "km")
                {
                    Console.Clear();
                    total = num * 10000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Metro

                if (med1 == "m" && med2 == "dam")
                {
                    Console.Clear();
                    total = num * 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "m" && med2 == "hm")
                {
                    Console.Clear();
                    total = num * 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "m" && med2 == "km")
                {
                    Console.Clear();
                    total = num * 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Decametro

                if (med1 == "dam" && med2 == "hm")
                {
                    Console.Clear();
                    total = num * 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dam" && med2 == "km")
                {
                    Console.Clear();
                    total = num * 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Hectômetro

                if (med1 == "hm" && med2 == "km")
                {
                    Console.Clear();
                    total = num * 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Quilometro (ao contrário)

                if (med1 == "km" && med2 == "hm")
                {
                    Console.Clear();
                    total = num / 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "km" && med2 == "dam")
                {
                    Console.Clear();
                    total = num / 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "km" && med2 == "m")
                {
                    Console.Clear();
                    total = num / 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "km" && med2 == "dm")
                {
                    Console.Clear();
                    total = num / 10000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "km" && med2 == "cm")
                {
                    Console.Clear();
                    total = num / 100000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "km" && med2 == "mm")
                {
                    Console.Clear();
                    total = num / 1000000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Hectômetro (ao contrário)

                if (med1 == "hm" && med2 == "dam")
                {
                    Console.Clear();
                    total = num / 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "hm" && med2 == "m")
                {
                    Console.Clear();
                    total = num / 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "hm" && med2 == "dm")
                {
                    Console.Clear();
                    total = num / 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "hm" && med2 == "cm")
                {
                    Console.Clear();
                    total = num / 10000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "hm" && med2 == "mm")
                {
                    Console.Clear();
                    total = num / 100000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Decametro (ao contrário)

                if (med1 == "dam" && med2 == "m")
                {
                    Console.Clear();
                    total = num / 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dam" && med2 == "dm")
                {
                    Console.Clear();
                    total = num / 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dam" && med2 == "cm")
                {
                    Console.Clear();
                    total = num / 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dam" && med2 == "mm")
                {
                    Console.Clear();
                    total = num / 10000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Metro (ao contrário)

                if (med1 == "m" && med2 == "dm")
                {
                    Console.Clear();
                    total = num / 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "m" && med2 == "cm")
                {
                    Console.Clear();
                    total = num / 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "m" && med2 == "mm")
                {
                    Console.Clear();
                    total = num / 1000;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Decimetro (ao contrário)

                if (med1 == "dm" && med2 == "cm")
                {
                    Console.Clear();
                    total = num / 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }
                if (med1 == "dm" && med2 == "mm")
                {
                    Console.Clear();
                    total = num / 100;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // Centimetro (ao contrário)

                if (med1 == "cm" && med2 == "mm")
                {
                    Console.Clear();
                    total = num / 10;
                    Console.WriteLine("Resultado: " + total + med2);
                }

                // NUMEROS

                if (blue == "numeros" || blue == "numero")
                {
                    Console.Clear();
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("Irei lhe proporcionar um tipo de calculadora para você.");
                    Console.WriteLine("dito isso, me diga, o que deseja");
                    Console.WriteLine("===========================================================");
                    Console.Write("adição, subtração, multiplicação ou divisão: ");
                    blu = Console.ReadLine();

                    if (blu == "adição" || blu == "soma" || blu == "adiçao" || blu == "Adição" || blu == "Soma" || blu == "Adiçao")
                    {
                        Console.Clear();
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("Digite dois numeros a serem somados");
                        Console.Write("Primeiro número: ");
                        numi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Segundo número: ");
                        nume = Convert.ToInt32(Console.ReadLine());
                        adi = numi + nume;
                        Console.WriteLine("seu resultado é: " + adi);
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("(clique em qualquer tecla para continuar..)");
                        Console.ReadKey();
                    }
                    if (blu == "subtração" || blu == "menos" || blu == "subtraçao" || blu == "Subtração" || blu == "Menos" || blu == "Subtraçao")
                    {
                        Console.Clear();
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("Digite dois numeros a serem subtraídos");
                        Console.Write("Primeiro número: ");
                        numi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Segundo número: ");
                        nume = Convert.ToInt32(Console.ReadLine());
                        sub = numi - nume;
                        Console.WriteLine("seu resultado é: " + sub);
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("(clique em qualquer tecla para continuar..)");
                        Console.ReadKey();
                    }
                    if (blu == "divisão" || blu == "dividir" || blu == "divisao" || blu == "Divisão" || blu == "Dividir" || blu == "Divisao")
                    {
                        Console.Clear();
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("Digite dois numeros a serem divididos");
                        Console.Write("Primeiro número: ");
                        numi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Segundo número: ");
                        nume = Convert.ToInt32(Console.ReadLine());
                        divi = numi / nume;
                        Console.WriteLine("seu resultado é: " + divi);
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("(clique em qualquer tecla para continuar..)");
                        Console.ReadKey();
                    }
                    if (blu == "multiplicação" || blu == "multiplicar" || blu == "multiplicaçao" || blu == "Multiplicação" || blu == "Multiplicar" || blu == "Multiplicaçao")
                    {
                        Console.Clear();
                        Console.WriteLine("===========================================================");
                        Console.WriteLine("Digite dois numeros a serem multiplicados");
                        Console.Write("Primeiro número: ");
                        numi = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Segundo número: ");
                        nume = Convert.ToInt32(Console.ReadLine());
                        multi = numi * nume;
                        Console.WriteLine("seu resultado é: " + multi);
                        Console.WriteLine("===========================================================");
                        Console.ReadKey();
                        Console.WriteLine("(clique em qualquer tecla para continuar..)");
                    }
                }
                    if (blue == "pesos")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                    }
                
            }
        }
    }
}
