# :dart: Desafio: Localizar moedas para fazer alterações

Ao desenvolver aplicativos, muitas vezes você precisará criar e modificar conjuntos de dados. Os métodos são úteis para executar operações de dados e são ferramentas especialmente poderosas para criar os próprios conjuntos de dados. Desenvolver métodos para criar matrizes que representam seu conjunto de dados ajuda a manter o código reutilizável, organizado e simplificado. Neste exercício, você praticará o retorno de matrizes a partir de métodos.
___

## Visão geral do Desafio :books: 

:memo: Suponha que você tenha várias moedas de valores diferentes. Você tem a tarefa de encontrar duas moedas cuja soma seja igual a um valor de destino. Neste exercício, as moedas disponíveis são representadas em uma matriz de inteiros. Você precisará retornar os índices das duas moedas em uma nova matriz.

###  <font color=hotpink> Primeira etapa: a seguinte abordagem será usada:  </font>

&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: Escolher um número da matriz
&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: Verificar outros números um de cada vez para ver se eles se somam ao valor de destino
&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: Retornar o resultado assim que uma correspondência for encontrada


###  <font color=hotpink> Segunda etapa: Localizar vários pares de moedas que dão troco:  </font>


&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: Para este exercício, você encontrará no máximo cinco pares. Isso significa que o tipo de retorno será uma matriz 2D em vez de uma matriz 1D, e você precisará modificar a maneira como seu código retorna os resultados.

####  ***Importante*** :heavy_exclamation_mark::heavy_exclamation_mark::heavy_exclamation_mark:

> ___
>
> A flexibilidade da palavra-chave return permite que você retorne o valor de uma expressão, desde que o resultado corresponda ao tipo de retorno especificado do método.
>
>___

###  <font color=hotpink> Terceira etapa: Capturar a nova matriz de retorno:  </font>

&nbsp;&nbsp;&nbsp;&nbsp; :pushpin:  Agora que seu método está retornando uma matriz 2D, você pode atualizar seu código para recuperar e imprimir os resultados. 

___