namespace ejercicio1
{
    /*1) El supermercado “Eureka” posee un problema al vender productos que no se descuenta del stock existente. Se requiere realizar el modelado de las clases del stock de un supermercado, donde se detalle la clase Producto con sus dos clases hijas: Bebida y Alimento, que posean un método que haga referencia a la venta de un producto y descuente la cantidad vendida del stock existente.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /*creo dos productos*/
            Bebida coca = new Bebida("cocacola", false);
            Alimento pan = new Alimento("pan frances", true);
            /*sumo stock de cada producto*/
            coca.sumarStock(2);
            pan.sumarStock(5);
            pan.sumarStock(1);
            //muestro stock actual
            Console.WriteLine(coca.ToString());
            Console.WriteLine(pan.ToString());

            //realizo algunas ventas
            pan.vender(1);

            //intento vender más unidades que las disponibles
            coca.vender(3);
            //muestro stock actual
            Console.WriteLine(coca.ToString());
            Console.WriteLine(pan.ToString());
        }
    }
}
