namespace EspacioCalculadora;
class Calculadora
{
    private double dato = 0;
    // public int numero2;
    public double Dato
    {
        get => dato;
        set => dato = value;
    }
    public void Sumar(double termino)
    {
        dato = dato + termino;
    }
    public void Restar(double termino)
    {
        dato = dato - termino;
    }
    public void Multiplicar(double termino)
    {
        dato = dato * termino;
    }
    public void Dividir(double termino)
    {
        dato = dato / termino;
        // if (termino == 0)
        // {
        //     dato = 0;
        // }else
        // {
        // }
    }
    public void Limpiar()
    {
        dato = 0;
    }
    public double Resultado
    {
        get => dato;
    }
}