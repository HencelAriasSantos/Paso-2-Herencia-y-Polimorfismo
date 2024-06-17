using System.Reflection;
using System.Text.RegularExpressions;

using static System.Runtime.InteropServices.JavaScript.JSType;

public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public Vehiculo(string marca, string modelo, int año)
    {
     Marca = marca;
     Modelo = modelo;
     Año = año;
    }
    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca},Modelo: {Modelo}, Año: {Año}");
    }
}


public class Automovil : Vehiculo
{
    public int PasajerosMax { get; set; }

    public Automovil(string marca, string modelo, int año, int pasajerosMax)
        : base(marca, modelo, año)
    {
        PasajerosMax = pasajerosMax;
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Camioneta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Cantidad de pasajeros maximos: {PasajerosMax}");
    }

}
public class Motocicleta : Vehiculo
{
    public int Canastas { get; set; }

    public Motocicleta(string marca, string modelo, int año, int canastas)
        : base(marca, modelo, año)
    {
        Canastas = canastas;
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine($"Camioneta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Canastas: {Canastas}");
    }
}

public class Camioneta : Vehiculo
{
    public int Caja { get; set; }

    public Camioneta(string marca, string modelo, int año, int caja)
        : base(marca, modelo, año)
    {
        Caja = caja;
    }
    public override void MostrarInformacion()
    {

        Console.WriteLine($"Camioneta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Caja: {Caja}");
    }

}
public class Programa
{
    static void Main(string[] arg)
    {
        Vehiculo vehiculo1 = new Automovil("Toyota", "Corolla", 2022, 4);
        Console.WriteLine("Información del Vehículo 1:");
        vehiculo1.MostrarInformacion();
        Vehiculo vehiculo2 = new Motocicleta("Honda", "CBR500R", 2023, 3);
        Console.WriteLine("Información del Vehículo 2:");
        vehiculo2.MostrarInformacion();
        Vehiculo vehiculo3 = new Camioneta("Ford", "Ranger", 2021, 1);
        Console.WriteLine("Información del Vehículo 3:");
        vehiculo3.MostrarInformacion();
    }
}