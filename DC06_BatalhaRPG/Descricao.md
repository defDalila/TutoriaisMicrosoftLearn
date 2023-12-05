# :dart: Desafio de código: Desafio de batalha em RPG

Neste desafio,  um herói e um monstro começam com a mesma pontuação de integridade. Durante a rodada do herói, ele gerará um valor aleatório que será subtraído da integridade do monstro. Se a integridade do monstro for maior que zero, ela terá sua rodada e atacará o herói. Desde que tanto o herói quanto o monstro tenham integridade maior que zero, a batalha continuará. O Objetivo é escrever um código para implementar as regras de jogo


___

## Visão geral do Desafio :books: 

###  <font color=hotpink> As regras para o jogo de batalha que você precisa implementar em seu projeto de código:</font>

:memo: Você deve usar a instrução do-while ou a instrução while como um loop de jogo externo.

:memo: O herói e o monstro começarão com 15 pontos de integridade.

:memo: Todos os ataques serão um valor entre 1 e 10.

:memo: O herói atacará primeiro.

:memo: Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.

:memo: Se a integridade do monstro for maior que zero, ele poderá atacar o herói.

:memo: Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.

:memo: Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.

:memo: Imprima quem foi o vencedor.


###  <font color=hotpink> O código deverá produzir uma saída semelhante:</font>


Output:
```csharp
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
```
