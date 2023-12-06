Console.Clear();

// Início do Código

Desafio1();
Desafio2();
Desafio3();
Desafio3B();




// Final do Código
Console.Write("\n\nPressione qualquer tecla para fechar... ");
Console.ReadKey();
Console.Clear();



static void Desafio1()
{
	int numero;
	bool ehValido = false;

	Console.Write($"Insira um número inteiro entre 5 e 10: ");

	do
	{
		ehValido = int.TryParse(Console.ReadLine(), out numero);
		Console.WriteLine($"");
		if (ehValido)
		{
			if (numero < 5 | numero > 10)
			{
				Console.Write($"O {numero} não é permitido pois o valor deve estar entre 5 e 10, tente novamente: ");
				ehValido = false;
			}
		}
		else Console.Write($"Entrada inválida, tente novamente: ");

	} while (!ehValido);

	Console.WriteLine($"\nVocê digitou {numero}: Valor de Entrada foi aceito.");
}

static void Desafio2()
{
	string? permissaoInserida;
	bool ehValido = false;

	string[] permissoes = { "administrador", "gerente", "usuario" };


	do
	{
		Console.Write("Entre com sua permissão (administrador, gerente, usuario):  ");
		permissaoInserida = Console.ReadLine().Trim();
		Console.WriteLine($"");

		switch (permissaoInserida.ToLower())
		{
			case "administrador":
			case "gerente":
			case "usuario":
				ehValido = true;
				break;
			default:
				Console.WriteLine($"A permissão inserida ({permissaoInserida}) não é valida.");
				break;
		}

	} while (!ehValido);
	Console.WriteLine($"\nPermissão ({permissaoInserida}) válida.");
}

static void Desafio3()
{
	string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

	int periodLocation;

	for (int i = 0; i < myStrings.Length; i++)
	{
		string myString = myStrings[i];
		string sentence;
		periodLocation = myString.IndexOf(".");

		while (periodLocation > 0)
		{
			sentence = myString.Remove(periodLocation);
			myString = myString.Substring(periodLocation + 1).Trim();
			periodLocation = myString.IndexOf(".");
			Console.WriteLine($"{sentence}");
		}
		sentence = myString.Trim();
		Console.WriteLine($"{sentence}");

	}
}

static void Desafio3B()
{
	string[] frases = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


	foreach (var frase in frases)
	{
		string fraseAtual = frase;
		int index = frase.IndexOf(".");

		if (index < 0) Console.WriteLine($"{fraseAtual}");
		else
		{
			do
			{
				string texto = fraseAtual.Remove(index);
				fraseAtual = fraseAtual.Substring(index + 1).Trim();
				index = fraseAtual.IndexOf(".");
				Console.WriteLine($"{texto}");
			} while (index > 0);

			Console.WriteLine($"{fraseAtual}");
		}

	}
}