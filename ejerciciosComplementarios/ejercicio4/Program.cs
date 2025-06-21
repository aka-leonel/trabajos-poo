using ejercicio4.controllers;

namespace ejercicio4
{
    /*4) Gestión de Notificaciones 

En nuestro sistema, hay distintas formas de enviar notificaciones: por Email, por SMS, o internas en la app. Una clase abstracta Notificacion tiene el método Enviar(), y cada implementación lo resuelve a su manera.

Estructura:
Modelos:
Notificacion (abstracta): Mensaje, Destinatario, método Enviar()
Clases: EmailNotificacion, SmsNotificacion, NotificacionInterna

Controlador:
Lista de notificaciones
Envío masivo*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // hardcodeamos un mensaje y un destinatario
            string mensaje = "Tu saldo está por agotarse.";
            string destinatario = "Juancito";
            NotificacionController notificacionController = new NotificacionController(mensaje, destinatario);
            notificacionController.EnvioMasivo();
        }
    }
}
