Console.Clear();

int totalTarefas = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// Parte 1 – Calcular a soma das notas de tarefa de cada aluno

int somaSophia = 0;
int somaNicolas = 0;
int somaZahirah = 0;
int somaJeong = 0;

somaSophia = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
somaNicolas = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
somaZahirah = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
somaJeong = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;


// Console.WriteLine("\nNotas das Tarefas somadas Por aluno");
// Console.WriteLine($"Sophia: {somaSophia}");
// Console.WriteLine($"Nicolas: {somaNicolas}");
// Console.WriteLine($"Zahirah: {somaZahirah}");
// Console.WriteLine($"Jeong: {somaJeong}");



// Parte 2 - Calcular a média das pontuações das tarefas do aluno

decimal mediaSophia = somaSophia / (decimal)totalTarefas;
decimal mediaNicolas = somaNicolas / (decimal)totalTarefas;
decimal mediaZahirah = somaZahirah / (decimal)totalTarefas;
decimal mediaJeong = somaJeong / (decimal)totalTarefas;

Console.WriteLine($"\nTotal de Atividades: {totalTarefas}\n");

// Console.WriteLine("\nNOTA FINAL\n");
// Console.WriteLine($"Aluno       Grade");
// Console.WriteLine($"Sophia:     {mediaSophia}  A");
// Console.WriteLine($"Nicolas:    {mediaNicolas}  B");
// Console.WriteLine($"Zahirah:    {mediaZahirah}  B");
// Console.WriteLine($"Jeong:      {mediaJeong}  A");



// Parte 3 - Formatar a saída usando sequências de caracteres de escape

Console.WriteLine("\n MÉDIA FINAL\n");
Console.WriteLine($"Aluno\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t{mediaSophia}\tA");
Console.WriteLine($"Nicolas:\t{mediaNicolas}\tB");
Console.WriteLine($"Zahirah:\t{mediaZahirah}\tB");
Console.WriteLine($"Jeong:\t\t{mediaJeong}\tA");

Console.Write("\nPressione uma tecla para sair\t");
Console.ReadKey();
Console.Clear();