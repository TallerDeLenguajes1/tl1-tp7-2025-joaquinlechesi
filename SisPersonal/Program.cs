using empleado;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 2");
string nombre, apellido;
DateTime fechaNac, fechaIng;
string estado;
double sueldo;
int dia, mes, anio, cargo;
List<Empleado> lista;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Empleado numero: " + (i + 1));
    Empleado nuevoEmpleado;
    Console.WriteLine("Ingrese el nombre del empleado:");
    nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido del empleado");
    apellido = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha de nacimiento:\nDia:");
    int.TryParse(Console.ReadLine(), out dia);
    Console.WriteLine("Mes:");
    int.TryParse(Console.ReadLine(), out mes);
    Console.WriteLine("Año:");
    int.TryParse(Console.ReadLine(), out anio);
    fechaNac = new DateTime(anio, mes, dia);
    Console.WriteLine("Ingrese el estado civil del empleado:\nS para SOLTERO\nC para CASADO.");
    estado = Console.ReadLine().ToUpper();
    Console.WriteLine("Fecha de ingreso del empleado:\nDia:");
    int.TryParse(Console.ReadLine(), out dia);
    Console.WriteLine("Mes:");
    int.TryParse(Console.ReadLine(), out mes);
    Console.WriteLine("Año:");
    int.TryParse(Console.ReadLine(), out anio);
}
