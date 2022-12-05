// See https://aka.ms/new-console-template for more information
using System;

// class public Objeto with id, nombre, descripcion, precio

Console.WriteLine("Hello, World!");
// JUGADOR
Console.WriteLine("Ingrese su nombre");
string? jugador = Console.ReadLine();
Console.WriteLine("Hola " + jugador);




string json = System.IO.File.ReadAllText("data.json");
//Console.WriteLine(json);
// agregar json a un arreglo
string[]? data = System.Text.Json.JsonSerializer.Deserialize<string[]>(json);
// mostrar data
Console.WriteLine(data[0]);

