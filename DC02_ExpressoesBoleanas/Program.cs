using DC02_ExpressoesBoleanas;

Console.Clear();

Parte01_DesafioProposto();
Parte02_OutraForma();

Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();

static void Parte01_DesafioProposto()
{
	string permissao = "Admin_Manager";
	int level = 55;

	if (permissao.Contains("Admin"))
	{
		if (level > 55)
			Console.WriteLine($"Welcome, Super Admin user.");
		else
		{
			Console.WriteLine($"Welcome, Admin user.");
		}
	}
	else if (permissao.Contains("Manager"))
	{

		if (level >= 20)
			Console.WriteLine($"Contact an Admin for acces.");
		else
			Console.WriteLine($"You do not have sufficient privileges.");
	}
	else
	{
		Console.WriteLine($"You do not have sufficient privileges.");
	}
}

static void Parte02_OutraForma()
{
	Permissoes permissao = Permissoes.Manager;

	Random random = new Random();
	int level = random.Next(15, 61);

	Console.WriteLine($"{permissao} Level {level}");

	string[] mensagens = { "Welcome, Super Admin user.",
						"Welcome, Admin user.",
						"Contact an Admin for access.",
						"You do not have sufficient privileges." };

	string mensagem = mensagens[3];

	if (permissao.ToString().Contains("Admin"))
	{
		if (level >= 55)
			mensagem = mensagens[(int)Respostas.LiberadoSuperAdmin];
		else
			mensagem = mensagens[(int)Respostas.LiberadoAdmin];
	}
	else if (permissao.ToString().Contains("Manager"))
	{
		if (level >= 40)
			mensagem = mensagens[(int)Respostas.RequerLiberacao];
	}

	Console.WriteLine($"{mensagem}");
}