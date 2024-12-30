interface IVehiculo
{
    void Arrancar();
    void Detener();
    string TipoCombustible { get; set; }
}

class Coche : IVehiculo
{
    public string TipoVehiculo { get; set; }
    public string TipoCombustible { get; set; }

    public Coche(string tipoVehiculo, string tipoCombustible)
    {
        TipoVehiculo = tipoVehiculo;
        TipoCombustible = tipoCombustible;
    }

    public void Arrancar()
    {
        Console.WriteLine("El coche arranca");
    }

    public void Detener()
    {
        Console.WriteLine("El coche se detiene");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coche coche = new Coche("Coche", "Gasolina");
        Console.WriteLine($"Tipo de vehículo: {coche.GetType().Name}, Combustible: {coche.TipoCombustible}");
        coche.Arrancar();
        coche.Detener();
    }
}
