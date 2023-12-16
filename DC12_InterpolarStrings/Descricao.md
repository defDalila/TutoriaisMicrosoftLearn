# :dart: Desafio: Aplicar a interpolação de cadeias de caracteres a uma carta-modelo

Para promover os produtos de investimento mais recentes de uma empresa de marketing e vendas, você envia milhares de cartas personalizadas para os clientes existentes. Seu trabalho é escrever códigos em C# para mesclar informações personalizadas sobre o cliente. A carta conterá informações, como o portfólio existente, e comparará os retornos atuais com os projetados se o cliente investir no uso dos novos produtos.

___

## Visão geral do Desafio :books: 

###  <font color=hotpink> A saída desejada (usando dados fictícios da conta do cliente): </font>


<font color=turquoise>output:</font>

```cpp
Prezada Sra. Barros,

Como cliente de nossa oferta Magic Yield, estamos entusiasmados em informá-la sobre um novo produto financeiro que poderia aumentar dramaticamente o seu retorno.

Atualmente, você possui 2.975.000,00 ações com um retorno de 12,75 %.

Nosso novo produto, Glorious Future, oferece um retorno de 13,13 %. Dado o seu volume atual, seu lucro potencial seria de ¤63.000.000,00.

Aqui está uma rápida comparação:

Magic Yield         12.75 %   R$ 55,000,000.00
Glorious Future     13.13 %   R$ 63,000,000.00
```

:memo: Use o novo conhecimento que você adquiriu sobre formatação de cadeias de caracteres para criar um aplicativo que possa mesclar e formatar o conteúdo adequado considerando a saída de exemplo acima. 

:memo: Preste muita atenção no espaço em branco e represente com precisão esse formato exato usando o C#.

###  <font color=hotpink> adicione o seguinte código para obter os dados para o desafio: </font>

<font color=turquoise>C#</font>

```csharp
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);
```
:memo: Você não pode excluir nenhum código existente, exceto os comentários.

:memo: Verifique se o código gera a seguinte mensagem:

<font color=turquoise>output:</font>

```cpp
Prezada Sra. Barros,

Como cliente de nossa oferta Magic Yield, estamos entusiasmados em informá-la sobre um novo produto financeiro que poderia aumentar dramaticamente o seu retorno.

Atualmente, você possui 2.975.000,00 ações com um retorno de 12,75 %.

Nosso novo produto, Glorious Future, oferece um retorno de 13,13 %. Dado o seu volume atual, seu lucro potencial seria de ¤63.000.000,00.

Aqui está uma rápida comparação:

Magic Yield         12.75 %   R$ 55,000,000.00      
Glorious Future     13.13 %   R$ 63,000,000.00
```

