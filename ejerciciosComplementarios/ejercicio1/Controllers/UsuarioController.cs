using ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1.Controllers
{
    internal class UsuarioController
    {
        public List<Usuario> listaUsuarios;// = new List<Usuario>();
        public UsuarioController()
        {
            listaUsuarios = new List<Usuario>{
            new Admin("juan", "juan@gmail.com"),
            new Editor("maria", "maria@yahoo.com"),
            new Lector("leo", "leo@aol.com") };
            Console.WriteLine("Se creó la lista usuarios y se añadieron 3 usuarios de ejemplo.");
        }
        public void MostrarTodos()
        {
            foreach (var usuario in listaUsuarios)
            {
                Console.WriteLine(usuario.ToString());
            }
        }
        public void AddUsuario(Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }

    }
}
