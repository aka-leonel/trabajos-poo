using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/* 5) Definir la clase Ambiente y generar los objetos: “Desarrollo”, “Testing”, “Preproduccion” y
“Produccion” que posea un método que sea verificarDespliegue y comprobar que la información del Ambiente sea igual a: “sistema_operativo: linux, ram:4, base_datos: postgresql, app: openjdk”, si es correcto mostrar por pantalla que el despliegue se puede realizar, de lo contrario, mostrar que no será posible realizar el despliegue. */
namespace ejercicio5
{
    internal class Ambiente
    {
        public string SistemaOperativo { get; set; }
        public int Ram {  get; set; }
        public string BaseDatos { get; set; }
        public string App {  get; set; }

        public Ambiente(string sitemaOperativo,  int ram, string baseDatos, string app)
        {
            SistemaOperativo = sitemaOperativo;
            Ram = ram;
            BaseDatos = baseDatos;
            App = app;
        }
        
        public void VerificarDespligue()
        {
            bool flag = false;
            //“sistema_operativo: linux, ram:4, base_datos: postgresql, app: openjdk”
            if(SistemaOperativo.ToLower() == "linux")
            {
                if (Ram >= 4)
                {
                    if(BaseDatos == "postgresql")
                    {
                        if (App == "openjdk")
                        {

                            flag = true;
                        }
                        else Console.WriteLine("La app debe ser openjdk.");
                    }
                    else { Console.WriteLine("La BBDD debe ser postgresql."); }
                }
                else Console.WriteLine("La ram debe ser almenos igual a 4Gb.");
            }
            else { Console.WriteLine("El S.O. debe ser linux."); }
            //variable = (condition) ? expressionTrue : expressionFalse;
            string resultado = (flag) ? ("Se puede desplegar.") : ("No se podrá desplegar.");
            Console.WriteLine(resultado);

        }

    }
}
