using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadArgumentos = 3;
            if(args.Length == cantidadArgumentos)
            {
                string returnValue = "No es triangulo";
                if (int.Parse(args[0]) < int.Parse(args[1])+ int.Parse(args[2]) ||
                    int.Parse(args[1]) < int.Parse(args[0]) + int.Parse(args[2]) ||
                    int.Parse(args[2]) < int.Parse(args[0]) + int.Parse(args[1]))
                {
                    if (int.Parse(args[0]) == int.Parse(args[1]) && int.Parse(args[1]) == int.Parse(args[2]))
                        returnValue = "Equilatero";
                    if (int.Parse(args[0]) == int.Parse(args[1])
                        || int.Parse(args[0]) == int.Parse(args[2])
                        || int.Parse(args[1]) == int.Parse(args[2]))
                        returnValue = "Isoceles";
                    if (int.Parse(args[0]) != int.Parse(args[1])
                        && int.Parse(args[1]) != int.Parse(args[2]))
                        returnValue = "Escaleno";
                }
                Console.WriteLine(returnValue);
            }
            Console.ReadKey();
        }
    }
}