using Clase1.Ejercicio;

// 1. Elegimos los bonos
var bonoP = new BonoA(); 
var bonoR = new BonoResultadoEstandar();

// 2. Creamos un empleado (por ejemplo, un Administrativo)
// El sueldo base de Administrativo es 40000 según tu código
Administrativo admin = new Administrativo(bonoP, bonoR);

// 3. Calculamos: 0 faltas y 100% de objetivo
// BonoA con 0 faltas = 1000
// BonoResultado con 100% objetivo = 10% del neto (4000)
double total = admin.CalcularSueldoNeto(0, 100);

Console.WriteLine($"\nSueldo base: {admin.SueldoNeto}");
Console.WriteLine($"Sueldo total con bonos: {total}");
Console.WriteLine("");