using System;
using System.Collections;

namespace SRP
{
    public class MostrarLibros
    {
        public static void ImprmirLibrosDigitales(ArrayList almacenado)
        {
            foreach (ElectronicoalAlmacenado libro in almacenado)
            {
                Console.WriteLine(libro.MostrarAlmacenado());
            }
        }

        public static void ImprimirLibrosFisicos(ArrayList almacenado)
        {
            foreach (FisicoAlmacenado libro in almacenado)
            {
                Console.WriteLine(libro.MostrarAlmacenado());
            }
        }
        
    }
}