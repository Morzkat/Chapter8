using System;

namespace Chapter8
{
    class Program
    {
        public Program()
        {
            int exercise = 50;
            do
            {
                Console.WriteLine("Elige un ejercicio");
                exercise = Int32.Parse(Console.ReadLine());

                switch (exercise)
                {
                    case 45:
                        Exercise45();
                        break;

                    case 46:
                        Exercise46();
                        break;

                    case 47:
                        Exercise47();
                        break;

                    default:
                        Console.WriteLine("La opcion introducida no esta disponible");
                        break;
                }

            } while (exercise > 45 && exercise < 50) ;
        }

        //Chapter 8
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private void Exercise45()
        {
            int factorial = 1;
            Console.WriteLine("Introduce un numero");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {   factorial = factorial *  i;    }

            Console.WriteLine("El factorial es: " + factorial);

        }

        private void Exercise46()
        {
            int factorial = 1;
            Console.WriteLine("Introduce un numero");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {   factorial = factorial * i;  }

            Console.WriteLine("El factorial es " + factorial);
            Console.WriteLine("El promedio es " + (factorial / (number - 1)));
        }

        private void Exercise47()
        {
            int factorial = 1;
            int sumFactorial = 0;

            Console.WriteLine("Introduce un numero");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {   factorial = factorial * i;  }

            sumFactorial = factorial + sumFactorial;
            Console.WriteLine("El factorial es " + factorial);
            Console.WriteLine("La suma de los factoriales es: " + sumFactorial);
        }


    }
}
