using System;
using System.Collections;
using System.Text;


namespace SRP
{

    class Program
    {
        private static ArrayList LibrosAlmacenadosDigitales = new ArrayList();
        private static ArrayList LibrosAlmacenadosFisicos = new ArrayList();
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            LibroDigital book3 = new LibroDigital("Caperucita Roja", "Charles Perrault","001-036", "C:/Documentos/Libros/CaperucitaRoja.pdf","PDF","2.5Mb");
            LibroDigital book4 = new LibroDigital("El Arte de la Guerra", "Sun Tzu","001-037", "C:/Documentos/Libros/ArteDeLaGuerra.pdf","PDF","2.1Mb");
            AgregarRegistroDigitales(new ElectronicoalAlmacenado(book3, "/OneDrive/BibliotecaUCU/Ficción/", "José Perez"));
            AgregarRegistroDigitales(new ElectronicoalAlmacenado(book4, "/OneDrive/BibliotecaUCU/Reflexión/", "José Perez"));
            AgregarRegistroDigitales(new ElectronicoalAlmacenado(book4, "/OneDrive/BibliotecaUCU/Reflexión/", "José Perez"));
            AgregarRegistroFisicos(new FisicoAlmacenado(book1, "UCU Central", "A", "7", "Roberto"));
            AgregarRegistroFisicos(new FisicoAlmacenado(book2, "UCU Mullin", "B", "3", "José"));
            MostrarTodosLosGuardados();
           // Impresora.LibrosDigitales(almacen1);

        }

        public static void AgregarRegistroDigitales(ElectronicoalAlmacenado libroElectronicoalAlmacenado)
        {
            LibrosAlmacenadosDigitales.Add(libroElectronicoalAlmacenado);
        }

        public static void QuitarRegistroDigitales(ElectronicoalAlmacenado libroElectronicoalAlmacenado)
        {
            LibrosAlmacenadosDigitales.Remove(libroElectronicoalAlmacenado);
        }

         public static void AgregarRegistroFisicos(FisicoAlmacenado libroFisicoAlmacenado)
        {
            LibrosAlmacenadosFisicos.Add(libroFisicoAlmacenado);
        }

        public static void QuitarRegistroFisicos(FisicoAlmacenado libroFisicoAlmacenado)
        {
            LibrosAlmacenadosFisicos.Remove(libroFisicoAlmacenado);
        }

        public static void MostrarTodosLosGuardados()
        {
            MostrarLibros.ImprmirLibrosDigitales(LibrosAlmacenadosDigitales);
            MostrarLibros.ImprimirLibrosFisicos(LibrosAlmacenadosFisicos);
        }

     






    }
}