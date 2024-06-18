using GestionUsuarios.Entidades;

internal class Program
{
    private static void Main(string[] args)
    {
        EmpleadoContrato empleadoContrato = new EmpleadoContrato(1, "Pepe",0, TipoEmpleado.EmpleadoContrato ,240, 11);
        EmpleadoRegular empleadoRegular = new EmpleadoRegular(2, "Marcos", 1800, TipoEmpleado.EmpleadoRegular, 2000);

        Console.WriteLine($"{empleadoRegular.GetName()} Total Salary: {empleadoRegular.GetSalario()}");
        Console.WriteLine($"{empleadoContrato.GetName()} Total Salary: {empleadoContrato.GetSalario()}");
    }
}