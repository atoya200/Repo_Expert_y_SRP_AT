using System;
using System.Collections;
using Library;


namespace Program
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Paciente ralf = new Paciente("Ralf Manson", "5555-5555", "54");
            Paciente steve = new Paciente("Steven Jhonson", "5555-5555", "41");
            Paciente erick = new Paciente("Erick Walls", "5555-5555", "14");
            Doctor alfred = new Doctor ("Erick Walls", "Cardiologo");
            Doctor mark = new Doctor ("", "Cardiologo");
            Doctor jose = new Doctor("", "");
            AppointmentService service = new AppointmentService();
            string appointmentResult = service.CreateAppointment(steve, "986782342", DateTime.Now, "Wall Street", alfred);
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = service.CreateAppointment(ralf, "", DateTime.Now, "Queen Street", mark);
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = service.CreateAppointment(ralf, "986782342", DateTime.Now, "Wall Street", alfred);
            Console.WriteLine(appointmentResult3);

            string appointmentResult4 = service.CreateAppointment(erick, "986782311", DateTime.Now, "Queen Street", alfred);
            Console.WriteLine(appointmentResult4);
        }


    }
}
