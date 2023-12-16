# :dart: Desafio: Minijogo de dados

O foco desse desafio é criar métodos corretos com os parâmetros adequados e tipos de retorno.
___

## Visão geral do Desafio :books: 

Seu desafio é criar um minijogo. 
&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: O jogo deve selecionar um número alvo que seja um número aleatório entre um e cinco (inclusive). 
&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: O jogador deve rolar um dado de seis lados. 
&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: Para vencer, o jogador deve rolar um número maior que o número alvo.
&nbsp;&nbsp;&nbsp;&nbsp; :pushpin:  No final de cada rodada, o jogador deve ser perguntado se gostaria de jogar novamente, e o jogo deve continuar ou terminar de acordo com a resposta.

###  <font color=hotpink> Desafio de código: adicionar métodos para tornar o jogo viável </font>

&nbsp;:memo: No código com o qual você começa, há dois métodos indisponíveis referenciados:

&nbsp;&nbsp;&nbsp;:bookmark: ShouldPlay: esse método deve recuperar a entrada do usuário e determinar se o usuário deseja jogar novamente 
&nbsp;&nbsp;&nbsp;:bookmark: WinOrLose: esse método deve determinar se o jogador ganhou ou perdeu

&nbsp;:memo: Também há duas variáveis não inicializadas:

&nbsp;&nbsp;&nbsp;:bookmark: `target`: o número alvo aleatório entre 1 e 5 
&nbsp;&nbsp;&nbsp;:bookmark: `roll`: o resultado da rolagem de dado de seis lados aleatória


:beginner: Seu desafio é criar os métodos ShouldPlay e WinOrLose e criar métodos que definem target e roll para valores aleatórios no intervalo correto. Quando todos os métodos forem concluídos, o jogo deverá ser executado com êxito.


###  <font color=hotpink> Código Starter: </font>

```csharp
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay()) 
        {
            PlayGame();

        }

        void PlayGame() 
        {
            var play = true;

            while (play) 
            {
                var target;
                var roll;

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose());
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

```

```
output:

Would you like to play? (Y/N)
Y
Roll a number greater than 1 to win!
You rolled a 2
You win!

Play again? (Y/N)
Y
Roll a number greater than 4 to win!
You rolled a 6
You win!

Play again? (Y/N)
Y
Roll a number greater than 1 to win!
You rolled a 1
You lose!

Play again? (Y/N)
N

```
