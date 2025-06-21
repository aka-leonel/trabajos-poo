using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.controllers
{
    internal class EmailNotificacion : Notificacion
    {
        public EmailNotificacion(string mensaje, string destinatario) : base(mensaje, destinatario) { }
        public override void Enviar()
        {
            Console.WriteLine($" Se envió a {Destinatario} vía email el mensaje: {Mensaje}.");
        }
    }
}
