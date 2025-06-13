namespace ejercicio2
{
    /*2) Crear una clase abstracta Empleado con los atributos Nombre, SueldoBase, y un método abstracto CalcularSueldo(). Se debe crear las clases hijas EmpleadoTiempoCompleto y EmpleadoMedioTiempo.
El empleado de tiempo completo calcula su sueldo según su sueldo base + bono de presentismo.
El empleado de medio tiempo calcula su sueldo según su sueldo base + un bono extra si supero las 20 horas semanales.
*/    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos dos instancias de cada tipo, para probar sueldos con y sin bonificacion
            EmpleadoMedioTiempo emt1 = new("Pablo", 1000);
            EmpleadoMedioTiempo emt2 = new("Marina", 1000);
            EmpleadoTiempoCompleto etc1 = new("Paula", 2200);
            EmpleadoTiempoCompleto etc2 = new("Robert", 2200);

            emt1.CalcularSueldo();
            emt2.CalcularSueldo();

            etc1.CalcularSueldo();
            etc2.CalcularSueldo();

        }
    }
}
