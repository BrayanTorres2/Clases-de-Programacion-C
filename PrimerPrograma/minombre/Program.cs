using System;
namespace PrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            metodos obj= new metodos();
            Console.WriteLine(obj.suma(2,4));
            Console.WriteLine(obj.resta(2,4));
        }
    }
}
