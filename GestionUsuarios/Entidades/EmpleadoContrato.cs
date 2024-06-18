using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUsuarios.Entidades
{
    public class EmpleadoContrato : Persona
    {
        private decimal HorasTrabajadas {  get; set; }
        private TipoEmpleado Tipo { get; set; }

        private decimal PrecioHoras {  get; set; }

        public EmpleadoContrato(int id, string nombre, decimal salario, TipoEmpleado tipo, decimal horasTrabajadas, decimal precioHoras) : base(id, nombre, salario)
        {
            HorasTrabajadas = horasTrabajadas;
            PrecioHoras = precioHoras;
        }

        public override decimal GetSalario()
        {
            decimal SalarioTotal = 0;

            SalarioTotal += HorasTrabajadas * PrecioHoras;

            return SalarioTotal;
        }
    }
}
