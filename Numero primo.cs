using System;

namespace numeroprimo
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Ingrese Un Número:\n");
            int num;
            num = int.Parse(Console.ReadLine());


            if (EsPrimo(num))
            {
                Console.WriteLine(num + " es un numero primo");

            }
            else
            {
                Console.WriteLine(num + " no es un numero primo");


                
            }

        }

        // Aqui se hace un bucle para verificar si es un numero primo
        static bool EsPrimo(int num)
        {
            if (num <= 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;

            int maxDivisor = (int)Math.Sqrt(num);
            for (int i = 3; i <= maxDivisor; i += 2)
		
            
                if (num % i == 0)
                    return false;
            

            return true;
        }


    }


}




