using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.controllers
{
    internal class NotificacionController
    {
        public List<Notificacion> notificaciones = new List<Notificacion>();
        public NotificacionController(string mensaje, string destinatario) {
            notificaciones.Add(new SmsNotificacion(mensaje,destinatario));
            notificaciones.Add(new EmailNotificacion(mensaje, destinatario));
            notificaciones.Add(new NotificacionInterna(mensaje, destinatario));
        }

        public void EnvioMasivo()
        {
            foreach (var notificacion in notificaciones)
            {
                notificacion.Enviar();
            }
        }
    }
}
