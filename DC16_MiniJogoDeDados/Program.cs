Console.WriteLine(@"

███████████████████████████████████████████████▀███████████████████████████████████████████████████
█▄─▀█▀─▄█▄─▄█▄─▀█▄─▄█▄─▄█▀▀▀▀▀████▄─▄█─▄▄─█─▄▄▄▄█─▄▄─███▄─▄▄▀█▄─▄▄─███▄─▄▄▀██▀▄─██▄─▄▄▀█─▄▄─█─▄▄▄▄█
██─█▄█─███─███─█▄▀─███─█████████─▄█─██─██─█─██▄─█─██─████─██─██─▄█▀████─██─██─▀─███─██─█─██─█▄▄▄▄─█
▀▄▄▄▀▄▄▄▀▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▀▀▀▀▀▀▀▀▄▄▄▀▀▀▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▄▄▄▄▄▀
");


Random random = new Random();

Console.WriteLine("Você gostaria de Jogar?");

if (Continuar())
{
	Jogar();
}



void Jogar()
{
	int objetivo;
	int faceSorteada;

	do
	{
		objetivo = SortearObjetivo();
		Console.WriteLine($"Objetivo Definido!");
		Console.WriteLine($"Você precisa tirar um número maior que {objetivo} para vencer!");
		Thread.Sleep(2000);

		faceSorteada = LancarDado();
		Console.WriteLine($"Você sorteou {faceSorteada}");
		Console.WriteLine(IsPlayerVencedor());
		Console.WriteLine("\nDeseja Continuar Jogando? ");


	} while (Continuar());

	string IsPlayerVencedor()
	{
		if (faceSorteada > objetivo)
			return "Você venceu!";
		else
			return "Você Perdeu!";
	}

}

int SortearObjetivo()
{
	Console.WriteLine("\nPressione uma tecla para sortear o objetivo... ");
	Console.ReadKey();
	return random.Next(1, 6);
}

int LancarDado()
{
	Console.WriteLine("\nPressione uma tecla para lançar o dado... ");
	Console.ReadKey();
	return random.Next(1, 7);
}


bool Continuar()
{
	do
	{
		Console.Write("Entre com [S/N]: ");
		string? continuar = Console.ReadLine();

		if (!string.IsNullOrEmpty(continuar))
		{
			continuar = continuar.ToUpper();
			if (continuar == "N" || continuar == "S")
			{
				return continuar == "S";
			}
		}
		else
		{
			Console.WriteLine($"Opção Inválida, tente novamente!");
		}
	} while (true);
}

Console.WriteLine("Encerrando o Jogo! Até mais");
Thread.Sleep(2000);
Console.Clear();