using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.controllers
{
    internal class NotificacionInterna : Notificacion
    {
        public NotificacionInterna(string mensaje, string destinatario) : base(mensaje, destinatario) { }
        public override void Enviar()
        {
            Console.WriteLine($" Se envió a {Destinatario} vía APP el mensaje: {Mensaje}.");
        }
    }
}
