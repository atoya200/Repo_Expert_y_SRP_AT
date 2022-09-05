using System;
using System.Text;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public string MostrarInformacion()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append($"Tiulo: {this.Title}\n");
            datos.Append($"Autor: {this.Author}\n");
            datos.Append($"Codigo: {this.Code}\n");
            return datos.ToString();
        }

    /* 
    Esta clase no cumple con el principo SRP debido a que hay varias razones de cambio, como si 
    además de haber libros físicos como en este caso, hubiesen libros digitales, entonces al haber
    de dos tipos habrían dos formas de almacenar, por ende habría que cambiar la forma de almacenar. 

    Por otro lado, si quisiese verse la información de los libros almacenados hay datos que estan 
    en un libro y no en el otro, además si se cambia la forma de hacer esto habrán más motivos de cambio. 
    Por ende se debería hacer una clase para cada tipo de libro, una para cada tipo de almacenaje y una 
    para imprimir los datos de los libros almacenados. 
   */
    }
    



}
