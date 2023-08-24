// See https://aka.ms/new-console-template for more information
using PracticaUno;

Console.WriteLine("Hello, World!");

Console.WriteLine("Práctica 1 Programación III");

var ej1 = new Ejercicio1();
var ej2 = new Ejercicio2();
var ej3 = new Ejercicio3();
var ej4 = new Ejercicio4();
var ej5 = new Ejercicio5();
var ej6 = new Ejercicio6();
var ej7 = new Ejercicio7();
var ej8 = new Ejercicio8();
var ej9 = new Ejercicio9();
var ej10 = new Ejercicio10();

Console.WriteLine($" {ej1.GetType().Name}");
ej1.Ejecutar();

Console.WriteLine($" {ej2.GetType().Name}");
ej2.Ejecutar();

Console.WriteLine($" {ej3.GetType().Name}");
ej3.Ejecutar();

Console.WriteLine($" {ej4.GetType().Name}");
ej4.Ejecutar();

Console.WriteLine($" {ej5.GetType().Name}");
ej5.Ejecutar();

Console.WriteLine($" {ej6.GetType().Name}");
ej6.Ejecutar();

Console.WriteLine($" {ej7.GetType().Name}");
ej7.Ejecutar();

Console.WriteLine($" {ej8.GetType().Name}");
ej8.Ejecutar();

Console.WriteLine($" {ej9.GetType().Name}");
ej9.Ejecutar();

Console.WriteLine($" {ej10.GetType().Name}");
ej10.Ejecutar();
