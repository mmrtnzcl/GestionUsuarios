using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Entidades
{
    public class EmpleadoRegular : Persona
    {

        private TipoEmpleado Tipo { get; set; }

        private int BonoAnual { get; set; }

        public EmpleadoRegular(int id, string nombre, decimal salario, TipoEmpleado tipo, int bonoAnual) : base(id, nombre, salario)
        {
            Tipo = tipo;
            BonoAnual = bonoAnual;
        }


        public override decimal GetSalario()
        {
            decimal SalarioTotal = Salario;

            SalarioTotal += BonoAnual/12;

            return SalarioTotal ;

        }
    }
}
