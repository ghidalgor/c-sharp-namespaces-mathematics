using System;
using plusNamespace;
using restaNamespace;
using multiplicacionNamespace;


namespace plusNamespace
{
    class plusClass
    {
        public int resultado = 0;

        public void calcular(int a, int b)
        {
            
            resultado = a + b;
            Console.WriteLine("Resultado de sumar "+a+ " + "+b+ " es: "+resultado);
        }
    }
}

/* Area de resta */
namespace restaNamespace
{
    class restaClass 
    {
        public int resultado = 0;
        public void calcular(int a, int b)
        {
            resultado = a - b;
            Console.WriteLine("Resultado de restar " + a + " - " + b + " es: " + resultado);
        }
    }

}

namespace multiplicacionNamespace
{
    class multiplicacionClass
    {
        public int resultado = 0;
        public void calcular(int a, int b)
        {
            resultado = a * b;
            Console.WriteLine("Resultado de multiplicar " + a + " * " + b + " es: " + resultado);

        }
    }
    
}

/* Area de Cálculos */
namespace matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            plusNamespace.plusClass     plusr = new plusClass();
            restaNamespace.restaClass   restar = new restaClass();
            multiplicacionNamespace.multiplicacionClass multiplicar = new multiplicacionClass();

            plusr.calcular(4,2);
            restar.calcular(4,2);
            multiplicar.calcular(4, 2);
            Console.ReadKey();
        }
    }
}