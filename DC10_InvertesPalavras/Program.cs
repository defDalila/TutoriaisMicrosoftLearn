Console.Clear();


string pangrama = "The quick brown fox jumps over the lazy dog";
Console.WriteLine($"Pangrama Original:\n{pangrama}");


string[] palavrasDoPangrama = pangrama.Split(' ');
string[] palavrasInvertidas = new string[palavrasDoPangrama.Length];

for (var i = 0; i < palavrasDoPangrama.Length; i++)
{
	char[] letrasDaPalavra = palavrasDoPangrama[i].ToCharArray();
	Array.Reverse(letrasDaPalavra);
	
	palavrasInvertidas[i] = new string(letrasDaPalavra); 
}

string pangramaInvertido = String.Join(" ", palavrasInvertidas);

Console.WriteLine($"\nPangrama com palavras invertidas:\n{pangramaInvertido}");


// Final do Código
Console.WriteLine("\n\nPressione qualquer tecla para fechar...");
Console.ReadKey();
Console.Clear();






