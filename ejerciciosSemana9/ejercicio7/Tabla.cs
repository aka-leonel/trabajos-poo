using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Tabla : IHTTPMethods
    {
        public string Titulo { get; set; }
        public List<Registro> Registros { get; set; }

        public Tabla(string titulo)
        {
            Titulo = titulo;
            Registros = new List<Registro>();
            Console.WriteLine($"Tabla {titulo} creada.");
        }
        
        // definicion de metodos HTTP
        public void GET(int id)
        {
            bool encontrado = false;
            foreach (var reg in Registros)
            {
                if (reg.Id == id)
                {
                    reg.MostrarInfo();
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Console.WriteLine("*** No se halló el id.");
        }
        public void POST(string nuevo)
        {
            Registros.Add(new Registro(nuevo));
        }
        public void PUT(int id, string cambio)
        {
            //buscar el id
            bool existeID = false;
            foreach (var reg in Registros)
            {
                if (reg.Id == id)
                {
                    //actualizo contenido
                    reg.Contenido = cambio;
                    existeID = true;
                    break;
                }
            }
            if (!existeID)
            {
                //add new reg
                Registros.Add(new Registro(cambio));
            }
            string mensaje = (existeID) ? "*** Registro actualizado." : "*** Nuevo registro creado.";
            Console.WriteLine(mensaje);
        }
        public void DELETE(int id)
        {
            bool registroBorrado = false;
            foreach (var reg in Registros)
            {
                if (reg.Id == id)
                {
                    reg.Borrar();
                    registroBorrado = true;
                    break;
                }
            }
            string mensaje = (registroBorrado) ? "*** Registro borrado." : "*** No se halló el id.";
            Console.WriteLine(mensaje);
        }

        //menu de opciones
        public void MostrarMenu()
        {
            bool salir = false;
            int opcion = 0;
            while (!salir)
            {
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("MÉTODOS HTTP");
                Console.WriteLine("1. GET");
                Console.WriteLine("2. POST");
                Console.WriteLine("3. PUT");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Mostrar toda la tabla");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Ingrese opcion: ");
                string aux0 = Console.ReadLine();
                while (!Int32.TryParse(aux0, out opcion))
                {
                    Console.WriteLine("Ingrese opcion: ");
                    aux0 = Console.ReadLine();
                }
                switch (opcion)
                {
                    case 1://GET
                        Console.WriteLine("Ingrese id: ");
                        string aux = Console.ReadLine();
                        int id1 = 0;
                        if (Int32.TryParse(aux, out id1))
                        {
                            GET(id1);
                        }
                        else Console.WriteLine("Ingrese un id numérico.");
                        break;
                    case 2://post
                        Console.WriteLine("Ingrese el nuevo contenido: ");
                        string cont = Console.ReadLine();
                        if (cont != null)
                        {
                            Registros.Add(new Registro(cont));
                            Console.WriteLine("Nuevo contenido agregado a la tabla.");
                        }
                        else Console.WriteLine("*** Nada agregado.");
                        break;
                    case 3://PUT
                        Console.WriteLine("Ingrese Id: ");
                        string aux2 = Console.ReadLine();
                        int id3;
                        if (Int32.TryParse(aux2, out id3))
                        {
                            Console.WriteLine("Ingrese contenido: ");
                            aux = Console.ReadLine();
                            PUT(id3, aux);
                        }
                        else Console.WriteLine("*** Id inválido.");
                        break;

                    case 4://delete
                        Console.WriteLine("Ingrese Id: ");
                        string aux4 = Console.ReadLine();
                        int id4 = 0;
                        if (Int32.TryParse(aux4, out id4))
                        {
                            DELETE(id4);
                        }
                        break;
                    case 5://mostrar todo
                        Console.WriteLine("*** Listado completo ***");
                        foreach (var item in Registros)
                        {
                            if (!item.Borrado)
                            {
                                item.MostrarInfo();
                            }
                        }
                        Console.WriteLine("*** Fin listado ***");
                        break;
                    case 6://exit
                        Console.WriteLine("*** SALIR ***");
                        salir = true;
                        break;
                    case -1://debugg option
                        Console.WriteLine("**Solo para testing**");
                        Console.WriteLine("*** Listado completo -eliminados incluidos- ***");
                        foreach (var item in Registros)
                        {
                            
                            {
                                item.MostrarInfo();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("*** Opcion incorrecta.");
                        break;
                }
            }
        }

    }

}
