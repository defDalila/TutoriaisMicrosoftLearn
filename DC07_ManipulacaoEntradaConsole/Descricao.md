# :dart: Desafio: Validação da Entrada do Usuário


## Descrição do Desafio 1:books: 

###  <font color=hotpink> Escrever o código que valida a entrada de inteiro </font>

:memo: A solução deve incluir uma iteração do-while ou while.

:memo:  Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.

:memo: Dentro do bloco de iteração:

 > :pushpin: A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
 >
 > :pushpin: A solução deve garantir que a entrada seja uma representação válida de um inteiro.
 >
> :pushpin: Se o valor inteiro não estiver entre 5 e 10, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário um valor inteiro entre 5 e 10.
>
 > :pushpin: A solução deve garantir que o valor inteiro esteja entre 5 e 10 antes de sair da iteração.

:memo: Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

Output:
```csharp
Enter an integer value between 5 and 10
two
Sorry, you entered an invalid number, please try again
2
You entered 2. Please enter a number between 5 and 10.
7
Your input value (7) has been accepted.
```

## Descrição do Desafio 2 :books: 

###  <font color=hotpink> Escrever o código que valida a entrada de cadeia de caracteres </font> 

:memo: A solução deve incluir uma iteração do-while ou while.

:memo: Antes do bloco de iteração: a solução deve usar uma instrução Console.WriteLine() para solicitar ao usuário um dos três nomes de função: Administrador, Gerente ou Usuário.

:memo: Dentro do bloco de iteração:

> :pushpin: A solução deve usar uma instrução Console.ReadLine() para obter uma entrada do usuário.
>
> :pushpin: A solução deve garantir que o valor inserido corresponda a uma das três opções de função.
>
> :pushpin: A solução deve usar o método Trim() no valor de entrada para ignorar caracteres de espaço à direita e à esquerda.
>
> :pushpin: A solução deve usar o método ToLower() no valor de entrada para ignorar maiúsculas e minúsculas.
> 
> :pushpin: Se o valor inserido não corresponder a uma das opções de função, o código deverá usar uma instrução Console.WriteLine() para solicitar ao usuário uma entrada válida.

:memo:  Abaixo (depois) do bloco de código de iteração: a solução deve usar uma instrução Console.WriteLine() para informar ao usuário que o valor de entrada foi aceito.

Output:
```csharp
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
```

## Descrição do Desafio 3 :books: 

###  <font color=hotpink> Escrever o código que processe o conteúdo de uma matriz de caracteres</font> 

:memo: A solução deve usar a seguinte matriz de cadeia de caracteres para representar a entrada para a lógica de codificação:

```csharp
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
```

:memo: A solução deve declarar uma variável inteira chamada `periodLocation` que pode ser usada para manter o local do caractere de ponto dentro de uma cadeia de caracteres.

:memo: A solução deve incluir um loop `foreach` ou for externo que possa ser usado para processar cada elemento da cadeia de caracteres na matriz. A variável da cadeia de caracteres que será processada dentro dos loops deve ser chamada de `myString`.

:memo: No loop externo, a solução deve usar o método `IndexOf()` da classe String para obter a localização do primeiro caractere de ponto na variável `myString`. A chamada de método deve ser semelhante a: `myString.IndexOf(".")`. Se não houver nenhum caractere de ponto na cadeia de caracteres, um valor de `-1` será retornado.

:memo: A solução deve incluir um loop `do-while` ou `while` interno que possa ser usado para processar a variável `myString`.

:memo: No loop interno, a solução deve extrair e exibir (gravar no console) cada frase contida em cada uma das cadeias de caracteres processadas.

:memo: No loop interno, a solução não deve exibir o caractere de ponto.

:memo: No loop interno, a solução deve usar os métodos `Remove()`, `Substring() `e `TrimStart()` para processar as informações da cadeia de caracteres.

output:
```csharp
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
```


