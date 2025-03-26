using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Hamburguesa clasica = new Hamburguesa("Blanco", "Res", 5.00);
        clasica.AgregarIngrediente("Lechuga", 0.50);
        clasica.AgregarIngrediente("Tomate", 0.75);
        clasica.MostrarDetalles();

        Hamburguesa_Saludable saludable = new Hamburguesa_Saludable("Pollo", 6.00);
        saludable.AgregarIngrediente("Aguacate", 1.00);
        saludable.AgregarIngrediente("Espinaca", 0.80);
        saludable.MostrarDetalles();

        Hamburguesa_Premium premium = new Hamburguesa_Premium("Res Angus", 8.00);
        premium.AgregarIngrediente("Queso", 1.50);
        premium.MostrarDetalles();
    }
}

class Hamburguesa
{
    public string Pan { get; set; }
    public string Carne { get; set; }
    public double PrecioBase { get; set; }
    public List<Tuple<string, double>> Ingredientes { get; set; }

    public Hamburguesa(string pan, string carne, double precioBase)
    {
        Pan = pan;
        Carne = carne;
        PrecioBase = precioBase;
        Ingredientes = new List<Tuple<string, double>>();
    }

    public void AgregarIngrediente(string nombre, double precio)
    {
        Ingredientes.Add(new Tuple<string, double>(nombre, precio));
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Hamburguesa con pan {Pan}, carne de {Carne}, precio base {PrecioBase:C}");
        foreach (var ingrediente in Ingredientes)
        {
            Console.WriteLine($"Ingrediente: {ingrediente.Item1}, Precio: {ingrediente.Item2:C}");
        }
        double precioTotal = PrecioBase + Ingredientes.Sum(i => i.Item2);
        Console.WriteLine($"Precio total: {precioTotal:C}");
    }
}

class Hamburguesa_Saludable : Hamburguesa
{
    public Hamburguesa_Saludable(string carne, double precioBase)
        : base("Integral", carne, precioBase)
    {
    }
}

class Hamburguesa_Premium : Hamburguesa
{
    public Hamburguesa_Premium(string carne, double precioBase)
        : base("Blanco", carne, precioBase)
    {
    }
}


