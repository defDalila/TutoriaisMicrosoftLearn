using D01_EstruturaesAninhadas.Utilities;

Console.Clear();

// Parte 1 -  crie as matrizes que armazenam as notas de tarefa de cada aluno e nomes.


int[] notasSophia = { 90, 86, 87, 98, 100 };
int[] notasAndrew = { 92, 89, 81, 96, 90 };
int[] notasEmma = { 90, 85, 87, 98, 68 };
int[] notasLogan = { 90, 95, 87, 88, 96 };


int[] notasExtraSophia = { 94, 90 };
int[] notasExtraAndrew = { 89 };
int[] notasExtraEmma = { 89, 89, 89 };
int[] notasExtraLogan = { 96 };

string[] nomesAlunos = { "Sophia", "Andrew", "Emma", "Logan" };
int totalDeProvas = 5;


Console.WriteLine($"Student\t\tNota Prova\tMedia Final\tGrade\t\tPontosExtras\n");
foreach (string nomeAluno in nomesAlunos)
{
	string alunoAtual = nomeAluno;
	string grade = "";
	decimal mediaPontosExtras = 0.0M;
	double totalPontosExtras = 0.0;
	decimal notaProva = 0.0M;
	double notaFinal = 0.0;
	int[] notasAlunoAtual = new int[10];
	int[] pontosExtras = new int[10];

	if (alunoAtual == "Sophia")
	{
		notasAlunoAtual = notasSophia;
		pontosExtras = notasExtraSophia;
	}
	else if (alunoAtual == "Andrew")
	{
		notasAlunoAtual = notasAndrew;
		pontosExtras = notasExtraAndrew;
	}
	else if (alunoAtual == "Emma")
	{
		notasAlunoAtual = notasEmma;
		pontosExtras = notasExtraEmma;
	}
	else if (alunoAtual == "Logan")
	{
		notasAlunoAtual = notasLogan;
		pontosExtras = notasExtraLogan;
	}


	foreach (int ponto in pontosExtras)
	{
		mediaPontosExtras += ponto / (decimal)pontosExtras.Length;
		totalPontosExtras += ponto / 10.0 / totalDeProvas;
	}

	
	foreach (int nota in notasAlunoAtual)
	{

		notaProva += nota / (decimal)totalDeProvas;
	}


	notaFinal += totalPontosExtras + (double)notaProva;

	grade = Grade.Definir(notaFinal);

	Console.WriteLine($"{alunoAtual}:\t\t{notaProva:F1}\t\t{notaFinal:F2}\t\t{grade}\t\t{mediaPontosExtras:F1} ({totalPontosExtras:F2} pts)");
}

Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();

