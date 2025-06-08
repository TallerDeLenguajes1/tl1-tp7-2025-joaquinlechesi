using System.Runtime.CompilerServices;

namespace empleado;

class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngresoEmpresa;
    private double sueldoBasico;
    private Cargos cargo;
    enum Cargos
    {
        Auxiliar = 1,
        Administrativo = 2,
        Ingeniero = 3,
        Especialista = 4,
        Investigado = 5
    }
    public Empleado(string Nombre, string Apellido, DateTime FechaNacimiento, char EstadoCivil, DateTime FechaIngresoEmpresa, double SueldoBasico)
    {
        this.nombre = Nombre;
        this.apellido = Apellido;
        this.fechaNacimiento = FechaNacimiento;
        this.estadoCivil = EstadoCivil;
        this.fechaIngresoEmpresa = FechaIngresoEmpresa;
        this.sueldoBasico = SueldoBasico;
        //this.cargo = CargoTrabajo; // Consultar como usar el enum con el metodo constructor.
    }
    // public int Antiguedad() // Metodo
    // {
        // return (DateTime.Now.Year - fechaIngresoEmpresa.Year);
    // }
    // public int Edad() // Metodo
    // {
        // return (fechaNacimiento.Year);
    // }
    // public int Jublilacion() // Metodo
    // {
        // return (65 - Antiguedad());
    // }
}