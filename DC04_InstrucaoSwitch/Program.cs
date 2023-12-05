Console.Clear();
// Início do Código

string[] tipos = new string[] { "01", "02", "03", "04", "05", "06", "07", "08" };
string[] cores = new string[] { "PT", "BR", "RS", "MR", "VD", "AZ", "CL" };
string[] tamanhos = new string[] { "P", "M", "G", "U" };

string[] codigos = new string[25];

Random random = new Random();

for (int i = 0; i < codigos.Length; i++)
{
	int[] indices = {
		random.Next(0, tipos.Length),
		random.Next(0, cores.Length),
		random.Next(0, tamanhos.Length)
		};
	
	string[] codigo = { tipos[indices[0]], cores[indices[1]], tamanhos[indices[2]] };

	codigos[i] = String.Join('-', codigo);
}

Console.WriteLine($"CÓDIGO\t\tPRODUTO\t\t\tCOR\t\tTAMANHO\n");
foreach (string codigo in codigos)
{
	
	string[] produtos = codigo.Split('-');

	string tipo = "";
	string cor = "";
	string tamanho = "";

	switch (produtos[0])
	{
		case "01":
			tipo = "Blusa de Moletom";
			break;
		case "02":
			tipo = "Camiseta";
			break;
		case "03":
			tipo = "Calça de Moletom";
			break;
		case "04":
			tipo = "Pantufa";
			break;
		case "05":
			tipo = "Pijama";
			break;
		case "07":
			tipo = "Camisola";
			break;
		case "08":
			tipo = "Luvas";
			break;
		default:
			tipo = "Outro";
			break;
	}

	switch (produtos[1])
	{
		case "PT":
			cor = "preto(a)";
			break;
		case "MR":
			cor = "marrom";
			break;
		case "BR":
			cor = "branco(a)";
			break;
		case "RS":
			cor = "rosa";
			break;
		case "VD":
			cor = "verde";
			break;
		case "AZ":
			cor = "azul";
			break;
		default:
			cor = "colorido(a)";
			break;
	}

	switch (produtos[2])
	{
		case "P":
			tamanho = "pequeno(a)";
			break;
		case "M":
			tamanho = "médio(a)";
			break;
		case "G":
			tamanho = "grande";
			break;
		default:
			tamanho = "único";
			break;
	}
	
	Console.WriteLine($"[{codigo}]\t{tipo.PadRight(16)}\t{cor.PadRight(8)}\t{tamanho}");
}


// Final do Código
Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();
