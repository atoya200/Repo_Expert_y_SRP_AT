using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Nombre {get; set;}
        public string Especialidad {get; set;}

        public Doctor(string name, string especialidad)
        {
            StringBuilder stringBuilder = new StringBuilder("Registrando doctor en el sistema...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("No se puede registrar al doctor, ingrese su nombre\n");
                isValid = false;
            }
            else
            {
                this.Nombre = name;
            }

            if (string.IsNullOrEmpty(especialidad))
            {
                stringBuilder.Append("No se puede registrar al doctor, se necesita la especialidad\n");
                isValid = false;
            }
            else
            {
                this.Especialidad = especialidad;
            }

            if (isValid)
            {
                stringBuilder.Append("Doctor ingresado con exito");

            }
          
            Console.WriteLine(stringBuilder.ToString());
        }

    }

}