namespace ejercicio5

/* 5) Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y
“Produccion” que posea un método que sea verificarDespliegue y comprobar que la información
del Ambiente sea igual a: “sistema_operativo: linux, ram:4, base_datos: postgresql, app: openjdk”, si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que no será posible realizar el despliegue. */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // el objeto produccion es el unico que cumple con los datos
            // para permitir el despliegue
            Ambiente desarrollo = new Ambiente("linux", 2, "postgresql", "openjdk");
            Ambiente testing = new Ambiente("windows", 4, "postgresql", "openjdk");
            Ambiente produccion = new Ambiente("linux", 4, "postgresql", "openjdk");

            desarrollo.VerificarDespligue();
            testing.VerificarDespligue();
            produccion.VerificarDespligue();
        }
    }
}
