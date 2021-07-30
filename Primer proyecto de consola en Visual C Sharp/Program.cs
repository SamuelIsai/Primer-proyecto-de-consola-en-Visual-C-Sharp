using System;

namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            //Declare las variables y luego inicialice a cero.
            int num1 = 0; int num2 = 0;

            // Muestra el título como la aplicación de calculadora de la consola de C #.
            Console.WriteLine("Calculadora de consola en C#/r");
            Console.WriteLine("------------------------------");

            //Pidale al usuario que escriba el primer numero.
            Console.WriteLine("Escriba un numero y luego presione Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Pídale al usuario que escriba el segundo número.
            Console.WriteLine("Escriba otro numero y luego presione enter");

            //Pide a la usuaria que elija una opción.
            Console.WriteLine("Elija una opcion de la siguiente lista:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("/ta - Add");
            Console.WriteLine("/ts - Subtract");
            Console.WriteLine("/tm - Multiply");
            Console.WriteLine("/td - Divide");
            Console.WriteLine("Your option? ");

            //Usa una sentencia de cambio para hacer los cálculos.
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado es: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado es {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado es: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado es: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Espere a que el usuario responda antes de cerrar.
            Console.Write("Presione cualquier tecla para cerrar la aplicacion de la calculadora...");
            Console.ReadKey();
        }
    }
}