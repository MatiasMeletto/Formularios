using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Participante
    {
        private string _nombre;
        public string Nombre { get => _nombre; set => _nombre = value.ToUpper(); }
        private string _apellido;
        public string Apellido { get => _apellido; set => _apellido = value.ToUpper(); }
        public int Numero { get; set; }
        public int Altura { get; set; }
        public int Puesto { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Participante(int numero, string nombre, string apellido, DateTime fechaNacimiento, int altura, int puesto)
        {
            Numero = numero;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            Puesto = puesto;
        }

        public string Imprimir()
        {
            return $@"Nombre: {Nombre}
            Apellido: {Apellido}
            Altura: {Altura} CM.";
        }
    }
}
