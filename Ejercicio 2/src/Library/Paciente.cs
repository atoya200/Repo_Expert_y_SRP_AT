using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string Nombre {get; set;}
        public string NumeroCelular {get; set;}
        public string Edad {get; set;}

        /* 
        La edad debería de calcularse mediante la fecha de nacimiento
        pero por esta ocasión será un valor que se pueda modificar a elección,
        sin fijarse en el año de nacimiento. 
        */
        


        public Paciente(string name,  string phoneNumber, string edad)
        {
            StringBuilder stringBuilder = new StringBuilder("Registrando paciente...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("No se puede registrar al paciente, ingrese el nombre del paciente\n");
                isValid = false;
            }
            else 
            {
                this.Nombre = name;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("No se puede registrar al paciente, se necesita el número de celular\n");
                isValid = false;
            }
             else 
            {
                this.NumeroCelular = phoneNumber;
            }

             if (string.IsNullOrEmpty(edad))
            {
                stringBuilder.Append("No se puede registrar al paciente, se necesita su edad\n");
                isValid = false;
            }
            else{
                this.Edad = edad;
            }

              if (isValid)
            {
                stringBuilder.Append("Paciente ingresado con exito");

            }
         

            Console.WriteLine(stringBuilder.ToString());
        }


    }
}