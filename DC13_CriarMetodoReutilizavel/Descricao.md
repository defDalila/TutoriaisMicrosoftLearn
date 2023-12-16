# :dart: Desafio: Dizer a sorte nas cartas

Você está ajudando a desenvolver um jogo de RPG multijogador de grande porte. Cada jogador tem uma estatística de sorte que pode afetar suas chances de encontrar tesouros raros. Todos os dias, um jogador pode falar com um cartomante no jogo que revelará se sua estatística de sorte é alta, baixa ou neutra.

No momento, o jogo tem código para gerar a sorte de um jogador, mas não é reutilizável. Sua tarefa é criar um método `tellFortune` que pode ser chamado a qualquer momento e substituir a lógica existente por uma chamada ao seu método.

Neste desafio, você recebe um código para iniciar. Você deve decidir como criar e chamar o método `tellFortune`.

O foco desse desafio é modificar o código para que ele seja reutilizável e possa ser executado a qualquer momento.
___

## Visão geral do Desafio :books: 

###  <font color=hotpink> Criar um método reutilizável: </font>

&nbsp;&nbsp;&nbsp;&nbsp; :memo: Criar um método reutilizável que imprimirá a sorte de um jogador a qualquer momento. O método deve conter a lógica que já está presente no código:

```csharp
    Random random = new Random();
    int luck = random.Next(100);

    string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
    string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
    string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
    string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

    Console.WriteLine("A fortune teller whispers the following words:");
        string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
```

&nbsp;&nbsp;&nbsp;&nbsp; :memo: Atualize o código para usar um método para exibir a sorte.

&nbsp;&nbsp;&nbsp;&nbsp; :memo: Teste seu código alterando o valor de luck e chamando o método novamente.

&nbsp;&nbsp;&nbsp;&nbsp; :memo: Verifique se o código produz uma das seguintes mensagens:


```
Uma vidente sussurra as seguintes palavras:
Você tem muito pelo que esperar. Hoje é um dia para experimentar coisas novas! Qualquer trabalho que você faça tem grandes chances de sucesso. Este é o momento ideal para realizar seus sonhos!
```

```
Uma vidente sussurra as seguintes palavras:
Você tem muito pelo que agradecer. Hoje é um dia para aproveitar o tempo com amigos. Qualquer trabalho que você faça deve estar alinhado com seus valores. Este é o momento ideal para se sintonizar com a natureza.

```

```
Uma vidente sussurra as seguintes palavras:
Você tem muito pelo que temer. Hoje é um dia para evitar decisões importantes. Qualquer trabalho que você faça pode ter resultados inesperados. Este é o momento ideal para reavaliar sua vida.

```
