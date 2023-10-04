using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Program
{
    internal class Program
    {
        static float resultado;
        static float IVA = 0.13f;
        static float num1,num2;
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Digite un numero");
            num1= float.Parse(Console.ReadLine());
            Console.WriteLine("Digite un numero");
            num2= float.Parse(Console.ReadLine());
            suma(num1, num2,"Steve");

            resta(num1, num2);

            Console.WriteLine(CalculoAguinaldo(1000f, 10));

            for (int i = 0; i 100;i++)

         
                Console.Read();
        }

        static void suma(float n1, float n2, String nombre)

        {
           

            static void suma()
        {
            int num1=5, num2=7;

   
         resultado = Program.num1 + Program.num2;
            Console.WriteLine($"Suma:{resultado}");

        }
        static void resta()

        {
            int num1 = 10, num2 = 3;
            resultado= num1 + num2;
            Console.WriteLine($"Resta:{resultado}");

        }
    }
}
