/*Consigna:
  Crear 2 (dos) clases  con C# (visual studio o vs code) de alguna entidad del mundo real (pueden ser personas, casas, instituciones, etc..) definiendo al menos 3 atributos y 2 métodos que sean propios de la clase.
 
 * Se han creado dos clases: Automovil y Carrera -la cual recibe dos automoviles y elije de ganador al más veloz.
 * 
 */
namespace ActividadN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo dos instancias de la clase Automovil
            Automovil golcito = new Automovil("Volkswagen", "Gol", 140);
            Automovil fitito = new Automovil("Fiat", "Fiat 600", 100);

            //la clase carrera "juega" una carrera entre ambos autos 
            //y muestra al ganador
            Carrera carrera = new Carrera(golcito, fitito);
        }
    }

    public class Automovil
    {
        public string Marca { get; set; }
        public string NombreModelo { get; set; }
        public bool EstaEncendido { get; set; }
        public int VelocidadMaxima { get; set; }

        public Automovil(string marca, string nombreModelo, int velocidadMaxima)
        {
            Marca = marca;
            NombreModelo = nombreModelo;
            EstaEncendido = false;
            VelocidadMaxima = velocidadMaxima;
            Console.WriteLine("Auto creado: " + marca + " " + nombreModelo + " Vel.Max: " + velocidadMaxima + "km/h");

        }

        public void EncenderMotor()
        {
            if (!EstaEncendido)
            {
                EstaEncendido = true;
                Console.WriteLine("Rum Rum! Se enciende el motor");
            }
            else
            {
                Console.WriteLine("El motor ya estaba en marcha.");
            }
        }
        public void ApagarMotor()
        {
            if (EstaEncendido)
            {
                Console.WriteLine("Se apaga el motor.");
            }
            else
            {
                Console.WriteLine("El motor ya estaba apagado.");
            }
        }
        public void Acelerar()
        {
            if (EstaEncendido)
            {
                Console.WriteLine("El auto acelera!");
            }
            else
            {
                Console.WriteLine("Motor apagado, enciéndalo para acelerar.");
            }
        }

    }

    public class Carrera
    {
        public Carrera(Automovil auto1, Automovil auto2)
        {
            Console.WriteLine("\nSe realizara una carrera entre " + auto1.NombreModelo + " y " + auto2.NombreModelo);
            if (auto1.VelocidadMaxima > auto2.VelocidadMaxima)
            {
                Console.WriteLine(auto1.Marca + " " + auto1.NombreModelo + " ha ganado!");
            }
            else if (auto1.VelocidadMaxima < auto2.VelocidadMaxima)
            {
                Console.WriteLine(auto2.Marca + " " + auto2.NombreModelo + " ha ganado!");
            }
            else { Console.WriteLine("Ha sido un empate!"); }
        }
    }
}
