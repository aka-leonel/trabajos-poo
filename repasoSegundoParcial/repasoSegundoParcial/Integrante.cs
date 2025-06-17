using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoSegundoParcial
{
    abstract class Integrante : IMotivador
    {
        int Id { get; set; }
        public string? Nombre {  get; set; }
        public string? Apellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        private int nextId = 0;
        public DateOnly FechaIngreso { get; set; }

        public Integrante()
        {
            Id = nextId++;
            var hoy = DateOnly.FromDateTime(DateTime.Now);           
            FechaIngreso = hoy;            
        }
        public Integrante(string nombre, string apellido,  DateOnly fechaNacimiento)
        {
            Id = nextId++;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            var hoy = DateOnly.FromDateTime(DateTime.Now);
            FechaIngreso = hoy;
        }
        public int CalcularEdad()
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int edad = hoy.Year - FechaNacimiento.Year - (FechaNacimiento.DayOfYear < hoy.DayOfYear ? 0 : 1);
            return edad;
        }
        public int CalcularAntiguedad()
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int antiguedad = hoy.Year - FechaIngreso.Year - (FechaIngreso.DayOfYear < hoy.DayOfYear ? 0 : 1);
            return antiguedad;
        }
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Id: {Id} Nombre y Apellido: {Nombre} {Apellido}.");
        }
    }
}
