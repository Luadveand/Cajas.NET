// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text.Json;

Console.WriteLine("Hello, World!");
// JUGADOR
Console.WriteLine("Ingrese su nombre");
string? jugador = Console.ReadLine();
Console.WriteLine("Hola " + jugador);
// 
string json = File.ReadAllText(@"data.json");   
List<Objeto>? objetos = JsonSerializer.Deserialize<List<Objeto>>(json);
Console.WriteLine($"There are {objetos?.Count} objects");
//List<Objeto>? objeto1 = JsonSerializer.Deserialize<List<Objeto>>(json);


public class Objeto {
  public int id { get; set; }
  public string? nombre { get; set; }
  public string? descripcion { get; set; }
  public double? precio {get; set;}
}