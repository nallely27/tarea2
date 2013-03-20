using System;

namespace tarea2
{
	class Prueba
    {
        static void Main(string[] args)
        {
            suma suma1 = new suma();
            suma1.Valor1 = 10;
            suma1.Valor2 = 7;
            suma1.Operar();
            Console.WriteLine("La suma: " + suma1.Valor1 + " y " + suma1.Valor2 + " = " + suma1.Resultado);

            resta resta1 = new resta();
            resta1.Valor1 = 8;
            resta1.Valor2 = 4;
            resta1.Operar();
            Console.WriteLine("La diferencia: " + resta1.Valor1 + " y " + resta1.Valor2 + " = " + resta1.Resultado);

            Console.ReadKey();
        }
    }
}