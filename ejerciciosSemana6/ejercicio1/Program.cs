/*1) Crear la clase Vehiculo que contenga marca, modelo y anio.
Debe tener los métodos:
CambiarMarcha() (simplemente un texto que informe el cambio de marcha)
MostrarInformacion()
Luego, crear tres clases que hereden de Vehiculo
Auto
Camioneta
Moto
Agregar propiedades específicas:
Auto: CantidadPuertas, esAutomatico (booleano)
Moto: TipoManubrio
Camioneta: cantidadPuertas, es4x4 (booleano)
Se deben instanciar en el Main, creando un objeto de cada clase hija y llamar a sus métodos.*/
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Volkswagen", "Gol", 2020, 4, false);
            Moto moto1 = new Moto("Honda", "Titan", 2025, "Curvo");
            Camioneta camioneta1 = new Camioneta("Toyota", "Hilux", 2020, 4, true);

            auto1.CambiarMarcha();
            auto1.MostrarInformacion();

            moto1.CambiarMarcha();
            moto1.MostrarInformacion();

            camioneta1.CambiarMarcha();
            camioneta1.MostrarInformacion();

        }
    }
}
