# :dart: Desafio de código: Reescrever if-elseif-else usando uma instrução switch

Neste desafio, você reescreverá um constructo if-elseif-else como uma instrução switch. Com isso, será possível analisar os pontos fortes e fracos da instrução switch quando comparada a um constructo if-elseif-else.
___

## Visão geral do Desafio :books: 

###  <font color=hotpink> Descrição do problema: </font>

:memo: Você começará com o código que usa um constructo if-elseif-else para avaliar os componentes de uma SKU de produto. 
- A SKU (unidade de manutenção de estoque) é formatada usando três valores codificados: 
    - `<product #>-<2-letter color code>-<size code>`. 
    - Por exemplo, um valor de SKU de `01-MN-L` corresponde a `(moletom)-(marrom)-(grande)` e o código gera uma descrição que aparece como `"Produto: Moletom Marrom Grande"`.

###  <font color=hotpink> Código Inicial: </font>

:memo: Insira o código de exemplo a seguir no Editor:


```csharp
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
```

:memo: Atualize o código para usar uma instrução `switch` no lugar do constructo `if-elseif-else`.

:memo: ***Verifique se a saída não foi alterada.*** Independentemente de como você fizer isso, o código deverá produzir a seguinte saída:

```csharp
Product: Large Maroon Sweat shirt
```
