Console.Clear();

ExercicioSolicitado();

ExercicioAdicional();

Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();



static void ExercicioSolicitado()
{
	Random moeda1 = new Random();
	int faceSorteada = moeda1.Next(0, 2);
	Console.WriteLine($"Face Sorteada: {(faceSorteada == 0 ? "Cara" : "Coroa")}\n\n");

}

static void ExercicioAdicional()
{
	Random moeda = new Random();
	int totalCara = 0;
	int totalCoroa = 0;

	for (int i = 0; i < 10000; i++)
	{
		int faceSorteada = moeda.Next(0, 2);

		if (faceSorteada == 0)
		{
			totalCara++;
		}
		else
		{
			totalCoroa++;
		}
	}
	int totalDeLancamentos = totalCara + totalCoroa;
	Console.WriteLine($"Lançando a Moeda {totalDeLancamentos} vezes...");
	Console.WriteLine($"Total Cara: {totalCara} ({(double)totalCara / totalDeLancamentos:P2})");
	Console.WriteLine($"Total Coroa: {totalCoroa} ({(double)totalCoroa / totalDeLancamentos:P2})");
}