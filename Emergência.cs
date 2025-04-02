using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um sistema de ajuda
            // emergencia
            string desejop, enderecop;
            string desejoa, enderecoa;
            string desejom, enderecom;
            string escolha;

            Console.WriteLine("======================================================");
            Console.WriteLine("Bem-vindo ao sistema de emergência, como posso ajudar?");
            Console.WriteLine("Polícia/Ambulância/Mecânico");
            Console.Write("digite: ");
            escolha = Console.ReadLine();
            Console.WriteLine("======================================================");
            {

                if (escolha == "policia" || escolha == "Policia" || escolha == "Polícia" || escolha == "polícia")
                {
                    Console.Clear();
                    Console.WriteLine("===================");
                    Console.WriteLine("Do que você precisa");
                    Console.Write("digite: ");
                    desejop = Console.ReadLine();
                    Console.WriteLine("=====================");
                    Console.Write("Digite seu endereço: ");
                    enderecop = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("Já enviamos uma viatura para " + enderecop + ". Qualquer dúvida, ligue para 190.");
                    Console.WriteLine("=====================================================================================");
                }

                if (escolha == "ambulancia" || escolha == "Ambulancia" || escolha == "ambulância" || escolha == "Ambulância")
                {
                    Console.Clear();
                    Console.WriteLine("====================");
                    Console.WriteLine("Do que você precisa.");
                    Console.Write("digite: ");
                    desejoa = Console.ReadLine();
                    Console.WriteLine("=====================");
                    Console.Write("Digite seu endereço: ");
                    enderecoa = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("=====================================================================================");
                    Console.WriteLine("Já enviamos uma viatura para" + enderecoa + "Qualquer dúvida, ligue para 191.");
                    Console.WriteLine("=====================================================================================");
                }

                if (escolha == "Mecânico" || escolha == "Mecanico" || escolha == "mecânico" || escolha == "mecanico")
                {
                    Console.Clear();
                    Console.WriteLine("===================");
                    Console.WriteLine("Do que você precisa");
                    Console.Write("digite: ");
                    desejom = Console.ReadLine();
                    Console.WriteLine("=====================");
                    Console.Write("Digite seu endereço: ");
                    enderecom = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("============================================");
                    Console.WriteLine("Já enviamos uma viatura para" + enderecom);
                    Console.WriteLine("============================================");
                }
            }
            Console.ReadKey();
        }
        
    }
    
}
