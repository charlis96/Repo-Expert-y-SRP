using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static StringBuilder stringBuilder { get; } = new StringBuilder("Scheduling appointment...\n");
        public static string CreateAppointment(Person person, string id, DateTime date, AppointmentLocation appointmentPlace, Doctor doctorName)
        {
            bool IsValid = true;

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
                AppointmentService.stringBuilder.Append("Appoinment scheduled");
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