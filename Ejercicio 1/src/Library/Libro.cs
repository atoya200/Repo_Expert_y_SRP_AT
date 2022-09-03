using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    /* 
        Si cambia la forma en la que se almacenan los libros, hay que registrar donde estan ahora, 
        en que biblioteca estan. Si estan en físico o digital. Entonces hay que cambiar. 
     */
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    /* 
        Si se quiere guardar en otro momento o dejar una orden para guardar, es decir
        dejar anotado que se quiere guardar o se debe guardar. No hay un seguimiento de la 
        acción en sí. Se guarda y listo, pero en una biblioteca grande como la es la de la UCU, puede
        digitarse el guardado del libro el día de hoy pero hacerse realmente en 3 días. Entonces, si se quiere
        dejar esa orden debería haber una clase que lo haga. 

        Si se quisiera saber que funcionario de la biblioteca fue el que guardo el libro, habría que crear 
        una clase exclusiva para almacenar, teniendo en cuenta el nombre o código de funcionario.
   */
    }


   // public class ShelveBook:

}
