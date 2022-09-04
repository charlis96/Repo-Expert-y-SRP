using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string appointmentResult = AppointmentService.CreateAppointment(new Person("Steven Jhonson", "5555-555-555"), "986782342", DateTime.Now, new AppointmentLocation("Wall Street"), new Doctor("Armand"));
            //Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment(new Person("Ralf Manson", "5555-555-555"), "", DateTime.Now, new AppointmentLocation("Queen Street"), new Doctor(""));
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = AppointmentService.CreateAppointment(new Person("Steven Jhonson", "5555-555-555"), "986782342", DateTime.Now, new AppointmentLocation("Wall Street"), new Doctor("Armand"));
            Console.WriteLine(appointmentResult3);
        }
    }
}