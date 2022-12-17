using System;
using System.Collections.Generic;

namespace ConnApp
{
    class SolucionMejorada
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

        // Funcion que retorna la lista de cajeros desocupados 
        //en dependencia del minuto.
        static List<string> CajerosLibresEnMinuto(int minuto)
        {
            List<string> libres = new List<string>();

            if (CajeroAAOcupado(minuto))
                libres.Add("1");
            if (CajeroBBOcupado(minuto))
                libres.Add("2");
            if (CajeroCCOcupado(minuto))
                libres.Add("3");
            if (CajeroDDOcupado(minuto))
                libres.Add("4");

            return libres;
        }


        static void HallarSolucion()
        {
            int minuto, posicion;

            // Entrada de dato posicion.
            Console.WriteLine("Introduzca número de posición en la fila");
            posicion = Convert.ToInt32(Console.ReadLine());

            // Inicializando minuto.
            minuto = 1;
            List<string> libres;

            while (posicion > 0)
            {
                libres = CajerosLibresEnMinuto(minuto);
                Console.WriteLine(string.Format("Minuto: {0}, cajeros libres: {1}", minuto, libres.Count));

                foreach (var item in libres)
                {
                    posicion--;

                    // Informacion adicional.
                    Console.WriteLine(string.Format("  Posicion: {0}", posicion));

                    // Indicando respuesta.
                    if (posicion == 0)
                    {
                        Console.WriteLine(string.Format("Debe esperar {0} minutos. Le corresponde el cajero: {1}", minuto, item));
                        break;
                    }
                }

                minuto++;
            }

        }

        static void Main(string[] args)
        {
            // Solucion
            HallarSolucion();

            Console.ReadLine();
        }

    }
}
