Console.Clear();

string[,] corporate =
{
	{"Robert", "Bavin"}, {"Simon", "Bright"},
	{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
	{"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
	{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
	{"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
	ExibirEmail(corporate[i, 0], corporate[i, 1]);
}

for (var i = 0; i < external.GetLength(0); i++)
{
	ExibirEmail(external[i, 0], external[i, 1], externalDomain);
}

void ExibirEmail(string nome, string sobrenome, string dominio = "contoso.com")

{
	string email = nome.ToLower().Substring(0, 2) + sobrenome.ToLower() + "@" + dominio;
	Console.WriteLine(email);
}


Console.Write($"Pressione qualquer tecla para encerrar o programa ... ");
Console.ReadKey();
Console.Clear();
