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
}