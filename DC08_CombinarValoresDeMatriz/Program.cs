using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

Console.Clear();

string[] valores = { "12.3", "45", "ABC", "11", "DEF" };

string frase = "";
float soma = 0.0F;

foreach (var valor in valores)
{
	if (float.TryParse(valor, out float valorFloat))
	{
		soma += valorFloat;
	}
	else
	{
		frase += valor;
	}
}
Console.WriteLine($"Mensagem: {frase}");
Console.WriteLine($"Total: {soma}");


Console.WriteLine("\n\nPressione qualquer tecla para fechar...");
Console.ReadKey();
Thread.Sleep(100);
Thread.Sleep(150);
Console.Write($"\n\nSaindo ");
Thread.Sleep(50);
Console.Write($"da ");
Thread.Sleep(150);
Console.Write($"aplicação ");
Carregando();
Console.Write("Close");
Thread.Sleep(50);
Console.Clear();

static void Carregando()
{
	Thread.Sleep(300);
	Console.Write($" .");
	Thread.Sleep(300);
	Console.Write($" .");
	Thread.Sleep(300);
	Console.WriteLine($" .");
	Thread.Sleep(300);
}