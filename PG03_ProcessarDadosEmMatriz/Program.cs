
using PG03_ProcessarDadosEmMatriz;

Console.Clear();

// Parte 1 -  crie as matrizes que armazenam as notas de tarefa de cada aluno e nomes.

Notas notas = new Notas();
int[] notasSophia = { notas.sophia1, notas.sophia2, notas.sophia3, notas.sophia4, notas.sophia5 };
int[] notasAndrew = { notas.andrew1, notas.andrew2, notas.andrew3, notas.andrew4, notas.andrew5 };
int[] notasEmma = { notas.emma1, notas.emma2, notas.emma3, notas.emma4, notas.emma5 };
int[] notasLogan = { notas.logan1, notas.logan2, notas.logan3, notas.logan4, notas.logan5 };


int[] extraSophia = { 94, 90 };
int[] extraAndrew = { 89 };
int[] extraEmma = { 89, 89, 89 };
int[] extraLogan = { 96 };

string[] nomesAlunos = { "Sophia", "Andrew", "Emma", "Logan" };
int totalDeProvas = 5;


Console.WriteLine($"Student\t\tGrade\n");
foreach (string nomeAluno in nomesAlunos)
{
	string alunoAtual = nomeAluno;
	string grade = "";
	decimal totalPontosExtras = 0.0M;
	decimal notaFinal = 0.0M;
	int[] notasAlunoAtual = new int[10];
	int[] pontosExtras = new int[10];

	if (alunoAtual == "Sophia")
	{
		notasAlunoAtual = notasSophia;
		pontosExtras = extraSophia;
	}
	else if (alunoAtual == "Andrew")
	{
		notasAlunoAtual = notasAndrew;
		pontosExtras = extraAndrew;
	}
	else if (alunoAtual == "Emma")
	{
		notasAlunoAtual = notasEmma;
		pontosExtras = extraEmma;
	}
	else if (alunoAtual == "Logan")
	{
		notasAlunoAtual = notasLogan;
		pontosExtras = extraLogan;
	}


	foreach (int ponto in pontosExtras)
	{
		totalPontosExtras += ponto / 10;
	}

	notaFinal += totalPontosExtras / totalDeProvas;

	foreach (int nota in notasAlunoAtual)
	{
		notaFinal += nota / (decimal)totalDeProvas;
	}
	grade = Grade.Definir(notaFinal);

	Console.WriteLine($"{alunoAtual}:\t\t{notaFinal:F1}\t{grade}");
}

Console.WriteLine("\n\nPressione qualquer tecla...");
Console.ReadKey();
Console.Clear();





