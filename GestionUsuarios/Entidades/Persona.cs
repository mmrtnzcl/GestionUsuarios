using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Entidades
{
    public abstract class Persona : IEmployer
    {

        protected string Nombre { get; set; }
        protected int Id { get; set; }
        protected decimal Salario { get; set; }

        public Persona(int id, string nombre, decimal salario)
        {
            Nombre = nombre;
            Id = id;
            Salario = salario;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Nombre;
        }

        public abstract decimal GetSalario();
     
    }
}
