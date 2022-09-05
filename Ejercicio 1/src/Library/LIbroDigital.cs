using System;
using System.Text;

namespace SRP
{
    public class LibroDigital
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string Direccion { get ; }
        public string TipoArchivo { get ; }
        public string Tamaño { get ;  }
        public string UbicacionActual { get ; set; }

        public LibroDigital(String title, String author, String code, String direccion, String tipoArchivo, String tamaño)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
            this.Direccion = direccion;
            this.TipoArchivo = tipoArchivo;
            this.Tamaño = tamaño;
            this.UbicacionActual = "";
        }

        public string MostrarInformacion()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append($"Tiulo: {this.Title}\n");
            datos.Append($"Autor: {this.Author}\n");
            datos.Append($"Codigo: {this.Code}\n");
            datos.Append($"Ubicación local: {this.Direccion}\n");
            datos.Append($"Tipo de archivo: {this.TipoArchivo}\n");
            datos.Append($"Tamaño: {this.Tamaño}\n");
            datos.Append($"Alojamiento actual: {this.UbicacionActual}\n");
            return datos.ToString();

        }
    }
}