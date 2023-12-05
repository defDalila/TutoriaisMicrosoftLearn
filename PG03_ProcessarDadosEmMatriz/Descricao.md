# :dart: Projeto Guiado: Desenvolver estruturas foreach e if-else para processar dados de matriz em C# 

Suponha que você seja assistente de um professor em uma escola. Você tem trabalhado com o professor para criar um aplicativo que automatiza o processo de cálculo das notas. Suas habilidades de programação em C# se aprimoraram desde que você concluiu a versão inicial do aplicativo. O professor solicitou uma atualização no aplicativo. A atualização se concentra no uso de matrizes, instruções foreach e instruções if. O professor também deseja que você inclua atribuições de créditos adicionais no cálculo da nota final de cada aluno.

_______



## Visão geral do Projeto :books: 


###  <font color=hotpink> Você está desenvolvendo um aplicativo de notas de alunos que automatiza o cálculo das notas de cada aluno em uma turma. Veja os seguintes parâmetros para o aplicativo: </font>


\
:ballot_box_with_check: Crie um aplicativo de console C#.

:ballot_box_with_check: Comece com quatro alunos. Cada aluno tem cinco pontuações de exame.

:ballot_box_with_check: Cada pontuação de exame é um valor inteiro, de 0 a 100, em que 100 representa 100% de respostas corretas.

:ballot_box_with_check: A pontuação de exame geral de um aluno é a média de suas cinco pontuações de exame.

:ballot_box_with_check: Critérios para tarefas de créditos extra:

- Inclua as pontuações de tarefas de crédito extra na matriz de pontuações do aluno.
- As tarefas de crédito extra valem 10% da pontuação do exame (ao calcular a nota numérica final).
    - Sophia: 94, 90
    - Andrew: 89
    - Emma: 89, 89, 89
    - Logan: 96
- Adicione as pontuações de tarefas de crédito extra à pontuação de exame total do aluno antes de calcular a nota numérica final.

:ballot_box_with_check: O aplicativo precisa atribuir notas com formato de letra automaticamente com base na pontuação final calculada de cada aluno.

:ballot_box_with_check: O aplicativo precisa gerar/exibir o nome de cada aluno e a nota formatada.

:ballot_box_with_check: O aplicativo precisa dar suporte à adição de outros alunos e pontuações com impacto mínimo no código.



### <font color=hotpink> Você já concluiu uma versão inicial do aplicativo. O projeto de código Starter deste módulo de projeto guiado inclui um arquivo Program.cs, que fornece os seguintes recursos de código: </font>


\
:heavy_check_mark: [Projeto Inicial - Starter](https://github.com/MicrosoftLearning/Guided-project-foreach-if-array-CSharp/archive/refs/heads/main.zip)

:heavy_check_mark: O código declara variáveis usadas para definir os nomes dos alunos e as pontuações de exames individuais de cada um deles.

:heavy_check_mark: O código inclui as variáveis e os algoritmos usados para somar as pontuações de exames e calcular a pontuação de exame média de cada aluno.

:heavy_check_mark: O código inclui uma nota codificada em formato de letra que o desenvolvedor deve aplicar manualmente.

:heavy_check_mark: O código inclui instruções Console.WriteLine() para exibir o relatório de notas do aluno.



### <font color=hotpink>  Seu objetivo é atualizar o código existente para incluir os seguintes recursos: </font>


\
:memo: Use matrizes para armazenar os nomes dos alunos e as pontuações das tarefas.

:memo: Use uma instrução foreach para fazer a iteração pelos nomes dos alunos como um loop de programa externo.

:memo: Use uma instrução if dentro do loop externo para identificar o nome do aluno atual e acessar as pontuações das tarefas dele.

:memo: Use uma instrução foreach dentro do loop externo para fazer a iteração pela matriz de pontuações de tarefas e somar os valores.

:memo: Use um algoritmo atualizado dentro do loop externo para calcular a pontuação de exame média de cada aluno.

:memo: Use um constructo if-elseif-else dentro do loop externo para avaliar a pontuação de exame média e atribuir automaticamente uma nota em formato de letra.

:memo: Integre as pontuações de crédito extra ao calcular a pontuação final do aluno e a nota em formato de letra da seguinte forma:

- O código precisa detectar tarefas de crédito extra com base no número de elementos na matriz de pontuações do aluno.
- O código precisa aplicar o fator de ponderação de 10% às tarefas de crédito extra antes de adicionar as pontuações de crédito extra à soma das pontuações de exames.

### <font color=hotpink> A lista a seguir mostra a nota em formato de letra que corresponde às pontuações numéricas: </font>


\
Output:
```csharp
97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F
```

###  <font color=hotpink> O aplicativo atualizado precisa produzir um relatório de notas do aluno formatado semelhante ao seguinte: </font>


\
Output:
```csharp
Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-
```

###  <font color=hotpink> Considerando os Pontos extras valendo 10% da nota </font>

\
Output:
```csharp
Student         Grade

Sophia:         95.8    A
Andrew:         91.2    A- 
Emma:           90.4    A- 
Logan:          93.0    A  

```

<font color=turquoise>

___
####   Projeto Inicial

 </font>

```csharp
using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

```