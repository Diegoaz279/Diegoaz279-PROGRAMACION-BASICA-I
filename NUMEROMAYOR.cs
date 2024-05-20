using System;

namespace NumeroMayor
{

    class Program
    {

        static void Main(string[] arg)
        {
            //Definicion de variables
            int num1, num2, num3, mayor, menor;

            //Pide al usuario que Ingrese los Numeros
            Console.WriteLine("Ingrese el Primer Número:\n");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Número:\n");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Tercer Número:\n");
            num3 = int.Parse(Console.ReadLine());


            //Aquí se iguala la variable mayor a la variable num1
            mayor = num1;

            //Se verifica si num2 es Mayor a mayor si es asi se iguala la mayor a num2
            if (num2 > mayor)
                mayor = num2;

            //Se verifica si num3 es Mayor a mayor si es asi se iguala la mayor a num3
            if (num3 > mayor)
                mayor = num3;


            //Se iguala la variable menor a la variable num1   
            menor = num1;

            //si num2 es menor a la variable menor, se iguala a la variable num2
            if (num2 < menor)
                menor = num2;

            //si num3 es menor a la variable menor, se iguala a la variable num3
            if (num3 < menor)
                menor = num3;


            //Salta un mensaje al usuario diciendole cual es el numero mayor y el numero menor 
            Console.WriteLine(" ");
            Console.WriteLine(mayor + " " + "Es el Número Mayor");
            Console.WriteLine(" ");
            Console.WriteLine(menor + " " + "Es el Número Menor");

        }

    }

}
