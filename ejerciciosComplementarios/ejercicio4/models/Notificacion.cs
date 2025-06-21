using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4.controllers
{/*4) Gestión de Notificaciones 

En nuestro sistema, hay distintas formas de enviar notificaciones: por Email, por SMS, o internas en la app. Una clase abstracta Notificacion tiene el método Enviar(), y cada implementación lo resuelve a su manera.

Estructura:
Modelos:
Notificacion (abstracta): Mensaje, Destinatario, método Enviar()
Clases: EmailNotificacion, SmsNotificacion, NotificacionInterna

Controlador:
Lista de notificaciones
Envío masivo*/
    abstract class Notificacion
    {
        public  string Mensaje {  get; set; }
        public  string Destinatario{ get; set; }
        public Notificacion(string mensaje, string destinatario) {
            Mensaje = mensaje;
            Destinatario = destinatario;
        }
        public abstract void Enviar();
    }
}
