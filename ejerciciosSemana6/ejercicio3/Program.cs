namespace ejercicio3
{
    /*3) Crear la clase Integrante que posea nombre, edad, antigüedad y un único método constructor que
almacene los datos de las variables nombradas.
    Crear dos clases hijas:
Jugador.
Tecnico.
Jugador debe tener posicion.
Tecnico debe tener especialidad.
Crear el método sumarAntiguedad(int cantidad) que incremente el valor de la antigüedad siempre
que el valor por parametro sea superior al existente.
Crear el método sumarAntiguedad(int cantidad, string motivo) para los casos en los que se
incremente la antigüedad con un mótivo especifico. El motivo solamente debe imprimirse en
pantalla.
Instanciar en el Main al menos dos objetos de la clase Jugador y dos objetos de la clase Tecnico,
ejecutar los métodos descriptos para cada tipo de Integrante y mostrar la información final por
pantalla con un método de MostrarInformación().*/

    /* Nota: A diferencia de lo que pide la consigna, el metodo SumarAntiguedad(int cantidad) no verifica que el parametro recibido sea superior al valor actual de antiguedad. Pensemos en el caso hipotetico de un mienbro con 5 años de antiguedad: si le quisera sumar 1(un) año de antiguedad dicha función no lo permitiría.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("Juan", 22, 0, "Defensor");
            Jugador j2 = new("Macarena", 33, 0, "Pivote");
            Tecnico t1 = new("Coco", 55, 25, "Estrategia");
            Tecnico t2 = new("Sofia", 40, 20, "Entrenamiento");

            // se muestra info de los jugadores antes y despues de sumar antiguedad.
            Console.WriteLine("Info de jugadores:");
            j1.MostrarInfo();
            j2.MostrarInfo();

            Console.WriteLine("\nSe le sumará antiguedad a los jugadores.");
            j1.SumarAntiguedad(2);
            j2.SumarAntiguedad(3, "Tercer aniversario de su ingreso");
            
            Console.WriteLine("\nNueva info de jugadores:");
            j2.MostrarInfo();
            j1.MostrarInfo();
            
            //se muestra info de los tecnicos antes y despues de sumar antiguedad
            Console.WriteLine("\nInfo de técnicos:");
            t1.MostrarInfo();
            t2.MostrarInfo();

            Console.WriteLine("\nSe le sumará antigüedad a los técnicos.");
            t1.SumarAntiguedad(1);
            t2.SumarAntiguedad(5, "Reconocimiento de sus años en ligas menores.");
            Console.WriteLine("\nNueva info de técnicos:");
            t1.MostrarInfo();
            t2.MostrarInfo();
        }
    }
}
