using System;
using System.Text;


namespace Library
{
      public class Mensaje
      {

           private StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

           public void Error (string Falla)
           {
            this.stringBuilder.Append($"Unable to schedule appointment, '{Falla}' is required\n");

           }

            public void Completo()
            {

                this.stringBuilder.Append("Appoinment scheduled");
            }

            public string getMensaje()
            {

                return this.stringBuilder.ToString();
            }



      }



}