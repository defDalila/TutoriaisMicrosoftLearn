Console.Clear();

// Inicio do Código

PrimeiraOpcao();
SegundaOpcao();

// Fim do Código
Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();


static void PrimeiraOpcao()
{
	for (int i = 1; i <= 100; i++)
	{
		string valor = "";
		Console.Write($"{i}");

		if (i % 3 == 0)
			valor += Valores.Fizz;
		if (i % 5 == 0)
			valor += Valores.Buzz;

		if (valor != "")
			Console.WriteLine($" - {valor}");
		else
			Console.WriteLine("");
	}
}

static void SegundaOpcao()
{
	for (int i = 1; i <= 100; i++)
	{
		string linha = $"{i}";

		if (i % 3 == 0 || i % 5 == 0)
			linha += " - ";
		if (i % 3 == 0)
			linha += Valores.Fizz;
		if (i % 5 == 0)
			linha += Valores.Buzz;

		Console.WriteLine(linha);
	}
}

public enum Valores { Fizz, Buzz };


/* Resolução da Plataforma

for (int i = 1; i < 101; i++)
{
	if ((i % 3 == 0) && (i % 5 == 0))
		Console.WriteLine($"{i} - FizzBuzz");
	else if (i % 3 == 0)
		Console.WriteLine($"{i} - Fizz");
	else if (i % 5 == 0)
		Console.WriteLine($"{i} - Buzz");
	else
		Console.WriteLine($"{i}");
}
*/