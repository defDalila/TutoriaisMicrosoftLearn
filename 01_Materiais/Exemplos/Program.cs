Console.Clear();



//Parte01();
// Parte02();

// Parte03();
// Parte04();

static void Parte01()
{
	Console.Write("Valor da Compra: ");
	var valorCompra = double.Parse(Console.ReadLine());

	int desconto = valorCompra >= 1000 ? 100 : 50;

	Console.WriteLine($"Desconto: {desconto:c}\nTotal: {valorCompra - desconto:c}");

	Console.WriteLine("Pressione qualquer tecla...");
	Console.ReadKey();
	Console.Clear();
}

static void Parte02()
{
	string mensagem = "Find what is (inside the parentheses)";


	int indiceAbertura = mensagem.IndexOf('(');
	int indiceFechamento = mensagem.IndexOf(')');

	indiceAbertura++;

	int tamanhoTextoParenteses = indiceFechamento - indiceAbertura;

	string textoParenteses = mensagem.Substring(indiceAbertura, tamanhoTextoParenteses);

	Console.WriteLine(textoParenteses);
}

static void Parte03()
{
	int[] times = { 800, 1200, 1600, 2000 };
	int diff = 0;

	Console.WriteLine("Enter current GMT");
	int currentGMT = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Current Medicine Schedule:");

	/* Format and display medicine times */
	ExibirHorario(times);

	Console.WriteLine();

	Console.WriteLine("Enter new GMT");
	int newGMT = Convert.ToInt32(Console.ReadLine());

	if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
	{
		Console.WriteLine("Invalid GMT");
	}
	else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
	{
		diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

		/* Adjust the times by adding the difference, keeping the value within 24 hours */
		AjustarHorario(times, diff);
	}
	else
	{
		diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

		/* Adjust the times by adding the difference, keeping the value within 24 hours */
		AjustarHorario(times, diff);
	}

	Console.WriteLine("New Medicine Schedule:");

	/* Format and display medicine times */
	ExibirHorario(times);

	Console.WriteLine();

	static void ExibirHorario(int[] times)
	{
		foreach (int val in times)
		{
			string time = val.ToString();
			int len = time.Length;

			if (len >= 3)
			{
				time = time.Insert(len - 2, ":");
			}
			else if (len == 2)
			{
				time = time.Insert(0, "0:");
			}
			else
			{
				time = time.Insert(0, "0:0");
			}

			Console.Write($"{time} ");
		}
	}
	static void AjustarHorario(int[] times, int diff)
	{
		for (int i = 0; i < times.Length; i++)
		{
			times[i] = ((times[i] + diff)) % 2400;
		}
	}
}

static void Parte04()
{
	int[] times = { 800, 1200, 1600, 2000 };
	int diff = 0;

	Console.WriteLine("Enter current GMT");
	int currentGMT = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Current Medicine Schedule:");
	DisplayTimes();

	Console.WriteLine("Enter new GMT");
	int newGMT = Convert.ToInt32(Console.ReadLine());

	if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
	{
		Console.WriteLine("Invalid GMT");
	}
	else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
	{
		diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
		AdjustTimes();
	}
	else
	{
		diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
		AdjustTimes();
	}

	Console.WriteLine("New Medicine Schedule:");
	DisplayTimes();

	void DisplayTimes()
	{
		/* Format and display medicine times */
		foreach (int val in times)
		{
			string time = val.ToString();
			int len = time.Length;

			if (len >= 3)
			{
				time = time.Insert(len - 2, ":");
			}
			else if (len == 2)
			{
				time = time.Insert(0, "0:");
			}
			else
			{
				time = time.Insert(0, "0:0");
			}

			Console.Write($"{time} ");
		}
		Console.WriteLine();
	}

	void AdjustTimes()
	{
		/* Adjust the times by adding the difference, keeping the value within 24 hours */
		for (int i = 0; i < times.Length; i++)
		{
			times[i] = ((times[i] + diff)) % 2400;
		}
	}
}