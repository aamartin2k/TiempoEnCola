using System;

namespace ConnApp
{
    class SolucionBasica
    {
        // Funciones para determinar ocupacion de cajero 
        // en dependencia del minuto.
        static bool CajeroAAOcupado(int minuto)
        {
            //Pares. Mod 2 es cero.
            if (0 == (minuto % 2))
                return true;
            else
                return false;
        }

        static bool CajeroBBOcupado(int minuto)
        {
            // Multiplo de 3. Mod 3 es cero.
            if (0 == (minuto % 3))
                return true;
            else
                return false;
        }

        static bool CajeroCCOcupado(int minuto)
        {
            // Multiplo de 5. Mod 5 es cero.
            if (0 == (minuto % 5))
                return true;
            else
                return false;
        }

        static bool CajeroDDOcupado(int minuto)
        {
            // Multiplo de 9. Mod 9 es cero.
            if (0 == (minuto % 9))
                return true;
            else
                return false;
        }

        // Funcion que determina cantidad de cajeros desocupados 
        //en dependencia del minuto.
        static int CajerosLibresEnMinuto(int minuto)
        {
            int libres = 0;

            if (CajeroAAOcupado(minuto))
                libres++;
            if (CajeroBBOcupado(minuto))
                libres++;
            if (CajeroCCOcupado(minuto))
                libres++;
            if (CajeroDDOcupado(minuto))
                libres++;

            return libres;
        }

        static void GenerarSecuencia()
        {
            int libres;

            // Generacion de secuencia de cajeros libres para 
            // los primeros 15 minutos.
            Console.WriteLine("Cajeros libres para los primeros 15 minutos");

            for (int i = 1; i < 16; i++)
            {
                libres = CajerosLibresEnMinuto(i);
                Console.WriteLine(string.Format("Minuto: {0}, cajeros libres: {1}", i, libres));
            }

            Console.WriteLine();
        }

        static void HallarSolucion()
        {
            int minuto, libres, posicion;

            // Entrada de dato posicion.
            Console.WriteLine("Introduzca número de posición en la fila");
            posicion = Convert.ToInt32(Console.ReadLine());

            // Inicializando minuto.
            minuto = 1;

            while (posicion > 0)
            {
                libres = CajerosLibresEnMinuto(minuto);
                posicion = posicion - libres;

                // Informacion adicional.
                Console.WriteLine(string.Format("Minuto: {0}, cajeros libres: {1}, posición: {2}", minuto, libres, posicion));

                // Indicando respuesta.
                if (posicion <= 0)
                    Console.WriteLine(string.Format("Debe esperar {0} minutos.", minuto));
                
                // Incrementando minuto
                minuto++;
            }

        }

        static void Main(string[] args)
        {
            // Test
            GenerarSecuencia();

            // Solucion
            HallarSolucion();

            Console.ReadLine();
        }
    }
}
