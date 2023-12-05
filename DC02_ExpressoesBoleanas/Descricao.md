# :dart: Desafio de lógica de decisão

Neste desafio, deverá ser implementado a lógica de decisão com base em uma série de regras de negócios. As regras de negócios especificam o acesso que será concedido aos usuários com base nas respectivas permissões baseadas em função e no nível de carreira. Os branches de código exibirão uma mensagem diferente para cada usuário, de acordo com as respectivas permissões e o nível.
___

## Visão geral do Desafio  :books: 


###  <font color=hotpink> Inicializar valores de permissão e nível  </font>

\
:memo: Digite o código de exemplo a seguir no Editor:

```csharp
string permission = "Admin|Manager";
int level = 55;
```

:memo: ***Examine as linhas de código iniciais:*** O aplicativo usará uma combinação de permission e level para aplicar/avaliar as regras de negócios neste cenário de desafio. A lista completa de condições para regras de negócios é especificada na próxima etapa. A solução final deve usar permission e level.


___

#### <font color=turquoise>  :bulb:   Dica:

> Para testar suficientemente todas as combinações de permission e level descritas nas regras de negócios abaixo, você precisará atribuir valores adicionais a essas variáveis e executar o aplicativo várias vezes.
___

</font>

###  <font color=hotpink> Implementar regras de negócios </font>


- :warning: ***RN01:*** Se o usuário for um administrador com um nível maior que 55, exiba a mensagem:


```csharp
Welcome, Super Admin user.
```

- :warning: ***RN02:***  Se o usuário for um administrador com um nível menor ou igual a 55, exiba a mensagem:

```csharp
Welcome, Admin user.
```
- :warning: ***RN03:*** Se o usuário for um gerente com um nível maior ou igual a 20, exiba a mensagem:

```csharp
Contact an Admin for access.
```

- :warning: ***RN04:*** Se o usuário for um gerente com um nível menor que 20, exiba a mensagem:

```csharp
You do not have sufficient privileges.
```

- :warning: ***RN05:*** Se o usuário não for um administrador nem um gerente, exiba a mensagem:

```csharp
You do not have sufficient privileges.
```

####  ***Importante*** :heavy_exclamation_mark::heavy_exclamation_mark::heavy_exclamation_mark:

> ***Você precisará usar o método auxiliar `Contains()` para determinar se o valor atribuído à cadeia de caracteres permission contém um dos valores de permissão especificados pelas "regras de negócios". Por exemplo, a expressão permission.Contains("Admin") retornará true ao usar os valores de dados iniciais especificados no código acima.***
___


###  <font color=hotpink> Testar a solução usando os valores de dados iniciais sugeridos </font>

\
:memo: Compile e execute o código.

:memo: ***Avalie a saída:*** Ao executar o código, incluindo os dados de configuração inicial, você verá a seguinte saída:

```csharp
Welcome, Admin user.
```


###  <font color=hotpink> Fazer testes quanto a outras regras de negócios </font>

\
:memo: Atualize os valores atribuídos a permission e level.


:memo: Avalie a saída para verificar se as outras regras de negócios foram atendidas.

