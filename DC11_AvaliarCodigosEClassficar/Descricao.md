# :dart: Desafio: analisar uma cadeia de caracteres de pedidos, classificá-los e marcar possíveis erros

Os dados vêm em muitos formatos. Neste desafio, você deverá analisar as "IDs do pedido" individuais e gerá-las classificadas e marcadas como "Erro" quando não tiverem exatamente quatro caracteres.
___

## Visão geral do Desafio :books: 

:memo: Adicione o seguinte código para obter os dados para o desafio:

```
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
```

:memo: Observe que no código anterior, a variável orderStream contém um string de várias IDs de pedido separadas por vírgulas

:memo: Adicione o código abaixo do código anterior para analisar as "IDs de pedido" do de pedidos de entrada string e armazenar as "IDs do pedido" em uma matriz

:memo: Adicione o código para gerar cada "ID do pedido" na ordem classificada e marque os pedidos que não tiverem exatamente quatro caracteres como "- Erro"

:memo: Seu código deverá produzir a seguinte saída:

```
output:

A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
```
