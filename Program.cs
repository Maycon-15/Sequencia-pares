using System;

namespace Sequencia_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NumDigitado;
            int inicio = 0;
            int NumeroCerto;
            bool terminar = false;

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("-----Sequência Pares-----");
                Console.ResetColor();

                Console.WriteLine("Números pares entre 0 e ?");
                NumDigitado = Int32.TryParse(Console.ReadLine(), out NumeroCerto);
                

             while (! terminar)
            {
                if (NumeroCerto > 0)
                {
                    Console.Write($"{inicio} ");

                    inicio = inicio +2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Valor digitado invalido");
                    Console.ResetColor();

                    terminar = true;
                }

                if (inicio > NumeroCerto)
                {
                    terminar = true;
                }


            }

            Console.WriteLine();

            Console.WriteLine("FIM");
        }
    }
}
