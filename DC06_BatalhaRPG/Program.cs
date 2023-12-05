Console.Clear();
// Início do Código

Console.WriteLine(@"

█▀▄▀█ █▀█ █▄░█ █▀ ▀█▀ █▀█ █▀█ █▀   █░█ █▀   ▄▀█ █░░ █ █▀▀ █▄░█ █▀
█░▀░█ █▄█ █░▀█ ▄█ ░█░ █▀▄ █▄█ ▄█   ▀▄▀ ▄█   █▀█ █▄▄ █ ██▄ █░▀█ ▄█
");
Console.WriteLine($"");

Random ataque = new Random();
int vidaMonstro = 15, vidaAlien = 15;
bool continuar = true;
int rodada = 0;
string[] personagens = { "\U0001F47E", "\U0001F47D" };
string personagemAtacado = "", atacante = "";

Console.WriteLine($"Bem-Vindo ao Jogo!\n");
Console.WriteLine($"Pontos de Vida Monstro: \U0001F50B {vidaMonstro} pts \t\t Pontos de Vida Alien: \U0001F50B {vidaAlien} pts\n");
Console.WriteLine("\nQuando quiser, pressione qualquer tecla para atacar...\n\n");


do
{
	Console.ReadKey();
	var pontosPerdidos = ataque.Next(1, 11);
	rodada++;
	Thread.Sleep(200);

	
	int vidaAtual;
	if (rodada % 2 != 0)
	{
		personagemAtacado = personagens[0];
		atacante = personagens[1];
		vidaMonstro -= pontosPerdidos;
		vidaAtual = vidaMonstro;
	}
	else
	{
		personagemAtacado = personagens[1];
		atacante = personagens[0];
		vidaAlien -= pontosPerdidos;
		vidaAtual = vidaAlien;

	}
	
	string sinalVida = "";
	if (vidaAtual > 0) sinalVida = "\U0001F494";
	else
	{
		sinalVida = "\U0001F480";
		vidaAtual = 0;
		continuar = false;
	}

	string mensagem = $"Ataque {rodada}: {atacante} \U0001F52A\U0001F52A\U0001F52A {personagemAtacado}\n\n" +
					  $"\tO {personagemAtacado} foi atacado " + 
					  $"perdendo \U0001F53B {pontosPerdidos} pts de vida!\t" +
					  $"Pontos Restantes:  {vidaAtual} {sinalVida}";
	Console.WriteLine($"{mensagem}\n");

	
} while (continuar);

Console.WriteLine($"Fim de Jogo!");

Console.WriteLine($"O Vencedor é:  {atacante} \U0001F3C6 ");
Console.WriteLine($"\U0001F44F\U0001F44F\U0001F44F");







// Final do Código
Console.WriteLine("\n\nPressione qualquer tecla para encerrar...");
Console.ReadKey();
Console.Clear();