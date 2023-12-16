using System.Globalization;
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

Console.Clear();

int valor1 = 12;
decimal valor2 = 6.2m;
float valor3 = 4.3f;

int resultado1;
decimal resultado2;
float resultado3;

Console.WriteLine($"Utilizando a classe Convert:");
resultado1 = Convert.ToInt32(valor1 / valor2);
Console.WriteLine($"Dividir o valor1 ({valor1}) pelo valor2 ({valor2}) resulta em um int: {resultado1}");

resultado2 = valor2 / Convert.ToDecimal(valor3);
Console.WriteLine($"Dividir o valor2 ({valor2}) pelo valor3 ({valor3}) resulta em um decimal: {resultado2}");

resultado3 = Convert.ToSingle(valor3 / valor1);
Console.WriteLine($"Dividir o valor3 ({valor3}) pelo valor1 ({valor1}) resulta em um float: {resultado3}");
Console.WriteLine($"--------------------------------------------------------------\n\n");


Console.WriteLine($"Utilizando casting:");
resultado1 = (int)valor2 / valor1;
Console.WriteLine($"Dividir o valor2 ({valor2}) pelo valor1 ({valor1}) resulta em um int: {resultado1}");

resultado2 = valor2 / (decimal)valor3;
Console.WriteLine($"Dividir o valor2 ({valor2}) pelo valor3 ({valor3}) resulta em um decimal: {resultado2}");

resultado3 = valor3 / valor1;
Console.WriteLine($"Dividir o valor3 ({valor3}) pelo valor1 ({valor1}) resulta em um float: {resultado3}");


// Final do Código
Console.WriteLine("\n\nPressione qualquer tecla para fechar...");
Console.ReadKey();
Thread.Sleep(400);
Console.Clear();
Thread.Sleep(150);
Console.Write($"\nSaindo ");
Thread.Sleep(50);
Console.Write($"da ");
Thread.Sleep(150);
Console.Write($"aplicação ");
Thread.Sleep(400);
Console.Write($" .");
Thread.Sleep(400);
Console.Write($" .");
Thread.Sleep(400);
Console.Write($" .");
Thread.Sleep(400);
Console.Write($"\nClose");
Thread.Sleep(100);
Console.Clear();
