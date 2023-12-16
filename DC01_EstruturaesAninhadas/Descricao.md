# :dart: Desafio de Projeto: Desenvolver estruturas foreach e if-elseif-else para processar dados de matriz em C#

Imagine que você é assistente de um professor em uma escola e desenvolveu um aplicativo para automatizar o processo de avaliação. O aplicativo usa matrizes para armazenar os nomes dos alunos e as tarefas que valem nota. Ele também implementa uma combinação de instruções de iteração e seleção para calcular e relatar a nota final de cada aluno. Além disso, ele diferencia entre tarefas de exame e tarefas de crédito extra ao calcular as notas dos alunos. Embora o aplicativo faça tudo o que o professor pediu, você recebeu uma solicitação de novos recursos. O professor solicitou que você atualizasse o relatório de notas para mostrar as pontuações dos exames e das tarefas de créditos extra separadamente da pontuação numérica final e da nota com formato de letra.

____

## Especificação do projeto :books: 


###  <font color=hotpink> O [projeto de código Starter](https://github.com/MicrosoftLearning/Challenge-project-foreach-if-array-CSharp/archive/refs/heads/main.zip) deste módulo é um aplicativo de console em C# que implementa os seguintes recursos de código: </font>

:heavy_check_mark: Usa matrizes para armazenar nomes de alunos e pontuações de tarefas.

:heavy_check_mark: Usa uma instrução foreach para fazer a iteração pelos nomes dos alunos como um loop de programa externo.

:heavy_check_mark: Usa uma instrução if no loop externo para identificar o nome do aluno atual e acessar as pontuações das tarefas dele.

:heavy_check_mark: Usa uma instrução foreach no loop externo para fazer a iteração pela matriz de pontuações de tarefas e somar os valores.

:heavy_check_mark: Usa um algoritmo no loop externo a fim de calcular a pontuação média de exame para cada aluno.

:heavy_check_mark: Usa um constructo if-elseif-else no loop externo para avaliar a pontuação média de exame e atribuir automaticamente uma nota em formato de letra.

:heavy_check_mark: Integra as pontuações de crédito extra ao calcular a pontuação final e a nota em formato de letra do aluno da seguinte maneira:
- Detecta tarefas de crédito extra com base no número de elementos na matriz de pontuações do aluno.
- Aplica um fator de ponderação de 10% às tarefas de crédito extra antes de adicionar pontuações de crédito extra à soma das pontuações de exame.

###  <font color=hotpink> Sua meta neste desafio é implementar as atualizações de codificação necessárias para produzir o relatório de pontuações solicitado pelo professor. </font>

:memo: O relatório de pontuações atual lista o nome do aluno, a nota geral calculada e a nota em formato de letra. Veja o seguinte formato de relatório existente:

Output:
```csharp
Student         Grade   Letter Grade

Sophia          95.6    A
Andrew          91.6    A-
Emma            89.2    B+
Logan           93      A
```

:memo: Além da pontuação numérica final do aluno e da nota em formato de letra, o professor quer que o relatório atualizado inclua a pontuação do exame e o impacto que os trabalhos de crédito extra têm na nota final do aluno. O formato do relatório de pontuação atualizado deve aparecer da seguinte maneira:

Output:
```csharp
Student         Exam Score      Overall Grade   Extra Credit

Sophia          92.2            95.88   A       92 (3.68 pts)
Andrew          89.6            91.38   A-      89 (1.78 pts)
Emma            85.6            90.94   A-      89 (5.34 pts)
Logan           91.2            93.12   A       96 (1.92 pts)
```