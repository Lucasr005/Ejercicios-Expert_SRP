using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);
        }
    }
}
/*En base al principio SRP, la clase Appointment no cumple con el, ya 
que tiene varias responsabilidades para cumplir, entre ellas: validar los datos y crear un mensaje sobra la consulta.*/

/*En base al patrón Expert, lo ideal en esta clase es dividirla en dos, separando la responsabilidad de
validar los datos en una propia clase separada.*/

/* realizado con Nicolas Ferreira y Fransico Lima*/