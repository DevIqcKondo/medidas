using System;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double m =0;
            double q =0;
            double c=0;
            Console.WriteLine("------------------");
            Console.WriteLine("Calculando medidas");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Convertendo metros em quilômetros e centímetros.");
            Console.Write("Digite um valor para metros: ");
            Console.ForegroundColor=ConsoleColor.Red;
            m=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();
            c=(m*100);
            q=(m/1000);
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Valor em centímetros= "+c+" cm.");
            Console.ResetColor();
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Valor em quilômetros = "+q+" km. ");
            Console.ResetColor();
            Console.Beep();
        }


    }
}
