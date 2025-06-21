using ejercicio2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2.controllers
{
    internal class UsuarioController
    {
        private List<IUsuarioModulo> usuarios = new List<IUsuarioModulo>();

        public UsuarioController() {
            PrecargarUsuarios();
        }

        public void PrecargarUsuarios()
        {
            usuarios.Add(new Dedu("decano"));
            usuarios.Add(new UA("contabilidad"));
            usuarios.Add(new Estudiante("ana maría"));
            Console.WriteLine("Se precargaron tres usuarios.");
        }
        public void ListarTodo()
        {
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"IUsuarioModulo con acceso a los siguientes modulos:");
                foreach (var item in usuario.ListarModulos())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
    }
}
