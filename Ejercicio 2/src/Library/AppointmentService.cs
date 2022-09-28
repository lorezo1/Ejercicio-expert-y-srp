using System;
using System.Text;


//No se cumple con el principio de SRP porque la clase no solo está validando los datos sino que tambien esta 
//enviando mensajes de respuesta



namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
 //           StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            Mensaje texto = new Mensaje();

            if (string.IsNullOrEmpty(name))
            {
 //               stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                texto.Error("name");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
//             stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                texto.Error("id");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
//                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                texto.Error("phone number");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
//              stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                texto.Error("appointment place");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
//                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                texto.Error("doctor name");
                isValid = false;
            }

            if (isValid)
            {
//                stringBuilder.Append("Appoinment scheduled");
                texto.Completo();
            }

//            return stringBuilder.ToString();
            string resultado = texto.getMensaje();
            return resultado;
        }

    }
}
