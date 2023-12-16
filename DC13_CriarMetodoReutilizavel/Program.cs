Console.Clear();

do
{
	Console.Clear();
	ObterSorte();
	Console.WriteLine("\n\nDeseja Ler a sorte novamente? ");
	Console.Write($"Responda com [s/n]: ");
	var resposta = Console.ReadLine();
	 
	if (resposta.ToLower() == "s")
		continue;
	else
	{
		break;
	}
	
} while (true);





Console.Write($"\n\n\nPressione qlquer tecla para fechar ... ");
Console.ReadKey();
Console.Clear();

void ObterSorte()
{
	Random random = new Random();
	int sorte = random.Next(100);

	string[] texto = { "Você tem muito pelo que", "Hoje é um dia para", "Qualquer trabalho que você faça", "Este é o momento ideal para" };

	string[] bom = { "esperar.", "experimentar coisas novas.", "tem grandes chances de sucesso.", "realizar seus sonhos" };

	string[] neutro = { "agradecer.", "aproveitar o tempo com seus amigos.", "deve estar alinhado com seus valores.", "se sintonizar com a natureza." };

	string[] ruim = { "temer.", "evitar decisões importantes.", "pode ter resultados inesperados.", "reavaliar sua vida" };

	Console.WriteLine("A vidente sussurra as seguintes palavras?");

	string[] destino = sorte > 75 ? bom : (sorte < 25 ? ruim : neutro);

	for (var i = 0; i < 4; i++)
	{
		Console.WriteLine($"{texto[i]} {destino[i]} ");

	}
}