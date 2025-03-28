using System;

string blu, cont;
int numi, nume, adi, sub, multi, divi;

do

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
    Console.Clear();
    Console.WriteLine("===========================================================");
    Console.WriteLine("(caso diga não, pressione ENTER após a resposta..)");
    Console.Write("Quer fazer outro cálculo (S/N)?: ");
    cont = Console.ReadLine();
}
while (cont == "s" || cont == "S" || cont == "sim" || cont == "Sim");
Console.ReadKey();
