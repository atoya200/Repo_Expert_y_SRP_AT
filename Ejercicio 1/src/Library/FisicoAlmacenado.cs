using System;
using System.Text;

namespace SRP
{
    public class FisicoAlmacenado
    {
        public string Edificio { get ; set; }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public string Funcionario { get ; set; }
        public Book LibroGuardado {get; set;}

         public  FisicoAlmacenado(Book libro, String edificio, String sector, String estanteria, String funcionario)
        {
            this.Edificio = edificio;
            this.LibrarySector = sector;
            this.LibraryShelve = estanteria;
            this.Funcionario = funcionario;
            this.LibroGuardado = libro;
         
        }

        public string MostrarAlmacenado()
        {
            StringBuilder descripcion = new StringBuilder();
            descripcion.Append(this.LibroGuardado.MostrarInformacion());
            descripcion.Append($"Esta en el edificio {this.Edificio}\n");
            descripcion.Append($"Esta en el sector {this.LibrarySector}\n");
            descripcion.Append($"Esta en la estanteria {this.LibraryShelve}\n");
            descripcion.Append($"El funcionario que lo almaceno fue {this.Funcionario}\n");
            return descripcion.ToString();
        }


    }
}