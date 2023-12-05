# :dart: Desafio de código: atualizar um código problemático no editor de código

Neste desafio, você usará o que aprendeu sobre blocos de código e escopo de variável para corrigir o exemplo de código mal escrito fornecido. Há muitas melhorias que você pode fazer. 
___

## Visão geral do Desafio :books: 

###  <font color=hotpink> Código Inicial</font>

:memo: Digite o código de exemplo a seguir no Editor:

```csharp
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
```

:memo: ***Examinar a saída desejada:*** Depois que você concluir as edições de código necessárias, o aplicativo produzirá a seguinte saída:

```csharp
Set contains 42
Total: 108
```

:memo: ***Concluir as atualizações de código necessárias para que as instruções Console.WriteLine() existentes produzam a saída desejada:*** O escopo variável pode precisar ser ajustado.

:memo: ***Otimize o código para facilitar a leitura:*** De acordo com a quantidade de espaço em branco incluída e de alguns outros fatores, é adequado ter cerca de 17 linhas de código.

