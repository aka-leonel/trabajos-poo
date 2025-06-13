namespace ejercicio6
{
    /*2) Crear una interfaz IVehiculo con el método Conducir().
Implementar las clases Auto, Moto y Bicicleta. Adaptar el método conducir para cada clase.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo[] vehiculos = new IVehiculo[3];
            vehiculos[0] = new Auto();
            vehiculos[1] = new Moto();
            vehiculos[2] = new Bicicleta();

            foreach (var item in vehiculos)
            {
                item.Conducir();
            }
        }
    }
}
