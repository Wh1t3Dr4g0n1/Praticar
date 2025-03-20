using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
        
        double a, b, c;
        Console.WriteLine("Digite os 3 lados do triÃ¢ngulo");
        Console.WriteLine("-----------------");
        Console.Write("Digite o lado a: ");
        a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o lado b: ");
        b = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Digite o lado c: ");
        c = Convert.ToDouble(Console.ReadLine());
        
        if (a == b && b == c)
        {
            Console.WriteLine("Triangulo Equilatero");
        }
        
        else if (a != b && b != c && a != c)
        {
            Console.WriteLine("Triangulo Escaleno");
        }
        
        else
        {
            Console.WriteLine("Triangulo isosceles");
        }
        
        Console.ReadKey();
    }
}
