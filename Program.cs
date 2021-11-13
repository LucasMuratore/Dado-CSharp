using System;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            Dado dado = new Dado();
            dado.NumeroMayorDado = 10;
            Random random = new Random();
            int numeroActual = random.Next(1, dado.NumeroMayorDado);
            int misPuntos = 0;
            String eleccion = "";
            bool estaBien = false;
            do
            {
                dado.Tirar();

                Console.WriteLine($"Elegís mayor o menor que {numeroActual}?");
                eleccion = Console.ReadLine().ToUpper();

                bool salioMayor = dado.Numero >= numeroActual;
                bool salioMenor = dado.Numero <= numeroActual;
                bool eligioMayor = eleccion == "MAYOR";
                bool eligioMenor = eleccion == "MENOR";
                estaBien = (salioMayor && eligioMayor) || (salioMenor && eligioMenor);

                if (estaBien)
                    misPuntos++;

                numeroActual = dado.Numero;
            } while (estaBien);

            Console.WriteLine($"Usted perdió, salió {numeroActual}");
            Console.WriteLine($"Hiciste {misPuntos} puntos");
            Console.ReadKey();
        }
    }
}