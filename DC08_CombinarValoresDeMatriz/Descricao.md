# :dart: Desafio: Combinar valores de matriz de cadeia de caracteres como cadeias de caracteres e inteiros

Este módulo apresentará dois desafios de código. O primeiro deles força você a dividir os dados dependendo do seu tipo e a concatenar ou adicionar os dados de forma adequada.
___

## Visão geral do Desafio :books: 

###  <font color=hotpink> Para instanciar uma matriz de cadeia de caracteres, insira o seguinte código "starter": </font>

```csharp
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

```
:memo: Crie uma estrutura de loop a ser usada na iteração por cada valor de cadeia de caracteres na matriz `values`.

:memo: Conclua o código necessário, colocando-o dentro do bloco de código da estrutura de loop da matriz.

###  <font color=hotpink> É necessário implementar as seguintes regras de negócio na lógica do código: </font>

:warning: Regra 1: Se o valor for alfabético, concatene-o para formar uma mensagem.

:warning: Regra 2: se o valor for numérico, adicione-o ao total.

:warning: Regra 3: o resultado deve corresponder à seguinte saída:


```
output

Message: ABCDEF
Total: 68.3
```

#### <font color=turquoise>  :bulb:  Dica:

> ___
>
> Se você quiser executar um programa usando a configuração de cultura "en-US", adicione o código a seguir à parte superior do programa using System.Globalization; e, após quaisquer instruções using, adicione CultureInfo.CurrentCulture = new CultureInfo("en-US");.
>
> ___
