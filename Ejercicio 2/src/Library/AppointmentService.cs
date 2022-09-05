using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class AppointmentService
    {
        private static ArrayList AppointmentsID = new ArrayList();

        public AppointmentService()
        {
            AppointmentsID.Add("Inicio");

        }
        public string CreateAppointment(Paciente paciente, string id, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(paciente.Nombre))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }
            else
            {
                if(AppointmentsID.Contains(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is repeated\n");
                isValid = false;
            }
            }

            if (string.IsNullOrEmpty(paciente.NumeroCelular))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.Nombre))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctor.Especialidad))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor specialty' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
                AppointmentsID.Add(id);
            }

            return stringBuilder.ToString();
        }

        /* 
        La clase no contempla el que hayan más datos del paciente o del doctor que se quieran usar
        o más tarde se pidan. Por ejemplo, durante la emergencia sanitaria ciertos pacientes 
        tenían prioridad sobre otros, por ende habría que tener algo que los diferencie. 
        Entonces por SRP y por Expert los que tendrían que tener los datos para poder operar con 
        el paciente y el doctor, serían clases de igual nombre que colaboren con AppointmentService.
        
        Además esta clase no contempla la posibilidad de haber consultas con la misma id, ya que podrían 
        crearse dos objetos con el mismo id, entonces serían dos reservas con el mismo identificador. 
        Como esta clase conoce a los doctores y pacientes es la adecuada (por Expert), para llevar a 
        cabo la creación de citas, verificando que no se repitan sus identificadores y que los datos 
        sean validos. 
         */

    }
}
