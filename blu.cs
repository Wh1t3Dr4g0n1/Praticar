// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {



        int num;
        string brasil;
        string morse;
        string cont;

        do
        {
            Console.WriteLine("=================================================================================");
            Console.WriteLine("Vamos criar um questionário para saber se você consegue entrar para nossa escola.");
            Console.WriteLine("=================================================================================");
            Console.Write("me responda, qual o resultado de 4 x 4: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 16)
            {
                Console.WriteLine("Você acertou! Vamos para o próximo.+1");
            }
            else
            {
                Console.WriteLine("Você errou! vamos para o próximo. +0");
            }
            Console.WriteLine("=================================================================================");
            Console.Write("Quem descobriu o Brasil: ");
            brasil = Console.ReadLine();

            if (brasil == "Pedro Álvares Cabral" || brasil == "Pedro Alvares Cabral" || brasil == "pedro alvares cabral" || brasil == "pedro álvares cabral")
            {
                Console.WriteLine("Você acertou! Vamos para o próximo.+1");
            }
            else
            {
                Console.WriteLine("Você errou! vamos para o próximo. +0");
            }
            Console.WriteLine("=================================================================================");
            Console.Write("Quem criou o morse: ");
            morse = Console.ReadLine();

            if (morse == "Samuel Morse" || morse == "samuel morse")
        {
            Console.WriteLine("Você acertou! Vamos para o próximo.+1");
        }
        else
        {
            Console.WriteLine("Você errou! vamos para o próximo. +0");
        }
        Console.WriteLine("Some os pontos se veja se chegou a 3. Se sim, você passou no teste!");
            Console.WriteLine("=================================================================================");
            Console.WriteLine("Quer recomeçar(S/N)?: ");
        cont = Console.ReadLine();
        }
            while (cont == "s" || cont == "S" || cont == "sim" || cont == "Sim");
            Console.ReadKey();
    }
}
