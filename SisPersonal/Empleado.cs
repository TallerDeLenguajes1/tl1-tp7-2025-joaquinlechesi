using System.Runtime.CompilerServices;

namespace empleado;

class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private string estadoCivil;
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
    public Empleado(string Nombre, string Apellido, DateTime FechaNacimiento, string EstadoCivil, DateTime FechaIngresoEmpresa, double SueldoBasico, int Cargo)
    {
        this.nombre = Nombre;
        this.apellido = Apellido;
        this.fechaNacimiento = FechaNacimiento;
        this.estadoCivil = EstadoCivil;
        this.fechaIngresoEmpresa = FechaIngresoEmpresa;
        this.sueldoBasico = SueldoBasico;
        this.cargo = (Cargos)Cargo;
    }
    public int Antiguedad() // Metodo
    {
        return (DateTime.Now.Year - fechaIngresoEmpresa.Year);
    }
    public int Edad() // Metodo
    {
        return (fechaNacimiento.Year);
    }
    public int Jublilacion() // Metodo
    {
        return (65 - Antiguedad());
    }
    public double Salario()
    {
        return (sueldoBasico + Adicional());
    }
    public double Adicional()
    {
        double adicional = 0;
        if (Antiguedad() <= 20)
        {
            adicional = adicional + (sueldoBasico * 0.15 * Antiguedad());
        }
        else
        {
            adicional = adicional + (sueldoBasico * 0.15 * 20) + (sueldoBasico * 0.25 * (Antiguedad() - 20));
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista) // Se trabaja con el enum
        {
            adicional = adicional + (adicional * 0.50);
        }
        if (estadoCivil == "C") // comillas simples para char
        {
            adicional = adicional + 150.00;
        }
        return adicional;
    }

}