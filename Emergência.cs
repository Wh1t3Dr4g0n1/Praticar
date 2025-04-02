// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Fazer um sistema de ajuda
// emergencia
string policia, desejop, enderecop;
string ambulancia, desejoa, enderecoa;
string mecanico, desejom, enderecom;
string escolha;


Consele.WriteLine ("Bem-vindo ao sistema de emergência, como posso ajudar?");
Console.WriteLine ("Polícia/Ambulância/Mecânico");
Console.Write ("digite: ");
escolha = Console.ReadLine();


if (escolha == "policia")

 Console.Clear();
 Console.WriteLine ("Do que você precisa");
 Console.Write ("digite: ");
 desejop = Console.ReadLine();
 Console.Write ("Digite seu endereço: ");
 enderecop = Console.ReadLine();
 Console.Clear();
 Console.WriteLine ("Já enviamos uma viatura para o seu endereço. Qualquer dúvida, ligue para 190.");
 


if (escolha == ambulancia)

Console.WriteLine ("Do que você precisa");
 Console.Write ("digite: ");
 desejoa = Console.ReadLine();
 Console.Write ("Digite seu endereço: ");
 enderecoa = Console.ReadLine();
 Console.Clear();
 Console.WriteLine ("Já enviamos uma viatura para o seu endereço. Qualquer dúvida, ligue para 191.");

if (escolha == Mecânico)

Console.WriteLine ("Do que você precisa");
 Console.Write ("digite: ");
 desejoa = Console.ReadLine();
 Console.Write ("Digite seu endereço: ");
 enderecoa = Console.ReadLine();
 Console.Clear();
 Console.WriteLine ("Já enviamos uma viatura para o seu endereço");
    }
    Console.ReadKey()
