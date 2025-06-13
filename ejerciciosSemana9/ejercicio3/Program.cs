namespace ejercicio3
{/*3) Crear la clase abstracta Vehiculo con método abstracto Arrancar() y un método no abstracto que sea acelerar(). Crear las clases hijas Auto, Moto y Camion que implementen Arrancar().
En el Main, crear un arreglo de Vehículos y que ejecuten el método arrancar y acelerar.

Código de ejemplo del main:
        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Auto();
        vehiculos[1] = new Moto();
        vehiculos[2] = new Camion();
        foreach (Vehiculo v in vehiculos)
        {
            v.MostrarTipo();
            v.Arrancar();
            Console.WriteLine();
        }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo[] vehiculos = new Vehiculo[3];
            vehiculos[0] = new Auto();
            vehiculos[1] =  new Moto();
            vehiculos[2] = new Camion();

            foreach (var item in vehiculos)
            {
                item.MostrarTipo();
                item.Arrancar();
                item.Acelerar();
                Console.WriteLine();
            }
        }
    }
}
