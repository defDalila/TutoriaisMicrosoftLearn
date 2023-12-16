
int[] moedas = [5, 5, 50, 25, 25, 10, 5];
int troco = 80;
int[,] resultado = DuasMoedas(moedas, troco);

if (resultado.Length == 0)
{
	Console.WriteLine($"Nenhuma combinação de duas moedas gera o troco necessario.");
}
else
{
	Console.WriteLine($"Moedas para o troco foram encontradas nas posições: ");
	
	for (int i = 0; i < resultado.GetLength(0); i++)
	{
		if (resultado[i, 0] == -1)
		{
			break;
		}
		Console.WriteLine($"{resultado[i, 0]}, {resultado[i, 1]}");
	}
}

Console.Write("\nTecle enter para fechar ... ");
Console.ReadKey();
Console.Clear();


int[,] DuasMoedas(int[] moedas, int troco)
{
	int[,] resultado = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
	int count = 0;

	for (int atual = 0; atual < moedas.Length; atual++)
	{
		for (int proxima = atual + 1; proxima < moedas.Length; proxima++)
		{
			if (moedas[atual] + moedas[proxima] == troco && count < resultado.GetLength(0))
			{
				resultado[count, 0] = atual;
				resultado[count, 1] = proxima;
				count++;
			}
			
		}
	}

	return (count == 0) ? new int[0,0] : resultado;
}