interface IDispositivo
{
    void Encebder();
    void Apagar();
    string Obtener();
}

class Telefono : IDispositivo
{
    string Modelo { get; set; }
    string Marca { get; set; }

    public Telefono(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }

    public void Encebder()
    {
        Console.WriteLine($"Encendiendo el teléfono {Marca}");
    }
    public void Apagar()
    {
        Console.WriteLine($"Apagando el teléfono {Marca}");
    }
    public string Obtener()
    {
        return $"Modelo: {Modelo}, Marca: {Marca}";
    }

}

public class Computadora : IDispositivo
{

    string Modelo { get; set; }
    string Marca { get; set; }
    public Computadora(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }

    public void Encebder()
    {
        Console.WriteLine($"Encendiendo la computadora {Marca}");
    }
    public void Apagar()
    {
        Console.WriteLine($"Apagando la computadora {Marca}");
    }
    public string Obtener()
    {
        return $"Modelo: {Modelo}, Marca: {Marca}";
    }
}



public class Tableta : IDispositivo
{

    string Modelo { get; set; }
    string Marca { get; set; }
    public Tableta(string modelo, string marca)
    {
        Modelo = modelo;
        Marca = marca;
    }

    public void Encebder()
    {
        Console.WriteLine($"Encendiendo la Tableta {Marca}");
    }
    public void Apagar()
    {
        Console.WriteLine($"Apagando la Tableta {Marca}");
    }
    public string Obtener()
    {
        return $"Modelo: {Modelo}, Marca: {Marca}";
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<IDispositivo> dispositivos = new List<IDispositivo>
        {
          new Telefono("Modelo19", "Marca1x"),
          new Computadora("Modelo29", "Marca2x"),
          new Tableta("Modelo39", "Marca3x")
        };


        foreach (IDispositivo dispositivo in dispositivos)
        {
            Console.WriteLine($"Tipo de de dispositivo: {dispositivo.GetType().Name}");
            dispositivo.Encebder();
            Console.WriteLine($" El dipositivo: {dispositivo.GetType()} y el Modelo ");
            dispositivo.Apagar();
            Console.WriteLine("-------------------");
        }


    }
}