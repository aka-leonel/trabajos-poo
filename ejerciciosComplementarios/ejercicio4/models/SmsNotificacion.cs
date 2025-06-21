using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.controllers
{
    internal class SmsNotificacion : Notificacion
    {
        public SmsNotificacion(string mensaje, string destinatario) : base(mensaje, destinatario) { }

        public override void Enviar()
        {
            Console.WriteLine($" Se envió a {Destinatario} vía SMS el mensaje: {Mensaje}.");
        }
    }
}
