using System;
using System.Text;

namespace Library
{
    /*
    El código original no respeta el principio SRP pues la clase AppointmentService se encarga de manejar todos
    los datos del paciente, la ubicación y del doctor, así como también de imprimir un aviso que diga si se pudo
    crear la cita exitosamente. Todas estas son razones de cambio, y como por el principio SRP una clase debe
    tener sólo una razón de cambio, se separan en clases distintas.
    */
    public class AppointmentService
    {
        public static StringBuilder stringBuilder { get; } = new StringBuilder();
        public static string CreateAppointment(Person person, string id, DateTime date, AppointmentLocation appointmentPlace, Doctor doctorName)
        {
            bool IsValid = true;
            AppointmentService.stringBuilder.Clear();
            AppointmentService.stringBuilder.Append("Scheduling appointment...\n");

            if (string.IsNullOrEmpty(person.Name))
            {
                AppointmentService.stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                IsValid = false;
            }

            if (string.IsNullOrEmpty(person.PhoneNumber))
            {
                AppointmentService.stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                IsValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                AppointmentService.stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                IsValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace.AppointmentPlace))
            {
                AppointmentService.stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                IsValid = false;
            }

            if (string.IsNullOrEmpty(doctorName.DoctorName))
            {
                AppointmentService.stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                IsValid = false;
            }

            if (IsValid)
            {
                AppointmentService.stringBuilder.Append("Appoinment scheduled\n");
            }

            return stringBuilder.ToString();
        }
    }

    //Creo una clase para el paciente ya que se pueden agregar más datos en el futuro como edad, sexo, etc.
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
    }

    //Creo una clase para la ubicación porque si se decide agregar más datos como por ejemplo sucursal, piso, sala, etc.
    public class AppointmentLocation
    {
        public string AppointmentPlace { get; set; }

        public AppointmentLocation(string appointmentPlace)
        {
            this.AppointmentPlace = appointmentPlace;
        }
    }

    //Creo una clase para el doctor porque se pueden agregar datos en el futuro como la especialidad.
    public class Doctor
    {
        public string DoctorName { get; set; }

        public Doctor(string doctorName)
        {
            this.DoctorName = doctorName;
        }
    }
}