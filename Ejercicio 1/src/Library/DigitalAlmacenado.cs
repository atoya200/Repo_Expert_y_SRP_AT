using System;
using System.Text;

namespace SRP
{
    public class ElectronicoalAlmacenado
    {
        public string Funcionario { get ; set; }

        public LibroDigital LibroGuardado {get; set;}

         public   ElectronicoalAlmacenado (LibroDigital libro, String destino, String funcionario)
        {
            libro.UbicacionActual = destino;
            this.Funcionario = funcionario;
            this.LibroGuardado = libro;
          
        }

         public string MostrarAlmacenado()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.Append(this.LibroGuardado.MostrarInformacion());
            descripcion.Append($"El funcionario que lo almaceno fue {this.Funcionario}\n");
            return descripcion.ToString();
        }
    }
}