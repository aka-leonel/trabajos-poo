namespace repasoSegundoParcial
{        /*
    1) Se necesita desarrollar una aplicación para administrar la información de los integrantes de un club de futbol. 
    Hay tres tipos de integrantes: jugadores, entrenadores y administrativos. 
    De todos ellos se necesita registrar su nombre, apellido y edad. 
    Además, para los jugadores se requiere ingresar la posición (entero) y la categoría (string).
    Para los entrenadores se debe registrar los años de experiencia.
    Para los administrativos la profesión y el puesto que ocupa. 
    Los jugadores y los entrenadores tienen la posibilidad de motivar a sus compañeros en la cancha, por lo que deberían tener que agregar ese método.
    Como detalle extra, necesitamos almacenar los datos de los Integrantes dentro de una estructura para poder recorrerla y mostrar la información de cada elemento.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaro una lista de integrantes
            List<Integrante> integrantes = new List<Integrante>();

            //precargo datos
            CargarDatos(integrantes);

            //recorro y muestro
            MostrarListado(integrantes);

            //jugadores y entrenadores motivan()
            Alentar(integrantes);

        }

        //esta función hardcodea datos en el listado
        public static void CargarDatos(List<Integrante> integrantes)
        {
            Integrante jugador1 = new Jugador("Homero", "Simpson", new DateOnly(1956, 5, 12), 5, "Mediocampista");
            integrantes.Add(jugador1);

            Integrante jugador2 = new Jugador("Carl", "Carlson", new DateOnly(1957, 9, 7), 9, "Delantero");
            integrantes.Add(jugador2);

            Entrenador entrenador1 = new Entrenador("Willie", "El Escocés", new DateOnly(1958, 3, 1), 10);
            integrantes.Add(entrenador1);

            Entrenador entrenador2 = new Entrenador("Seymour", "Skinner", new DateOnly(1953, 7, 5), 20);
            integrantes.Add(entrenador2);

            Administrativo administrativo1 = new Administrativo("Waylon", "Smithers", new DateOnly(1950, 12, 9), "Abogado", "Asistente legal");
            integrantes.Add(administrativo1);

            Administrativo administrativo2 = new Administrativo("Marge", "Bouvier", new DateOnly(1958, 3, 19), "Contadora", "Asistente de pagos");
            integrantes.Add(administrativo2);
            Console.WriteLine("*** Se han cargado los datos en el listado ***\n ");
        }
        public static void MostrarListado(List<Integrante> integrantes)
        {
            foreach (var item in integrantes)
            {
                item.MostrarInfo();
            }Console.WriteLine();
        }

        public static void Alentar(List<Integrante> integrantes)
        {
            foreach (var item in integrantes)
            {
                if (item is Jugador) Jugador.Motivar();
                if (item is Entrenador) Entrenador.Motivar();

            }
        }
    }


}
