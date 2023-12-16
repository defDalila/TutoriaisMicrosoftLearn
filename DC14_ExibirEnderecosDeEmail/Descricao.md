# :dart: Desafio: Exibir endereços de email

O desafio é criar um método que exibe o endereço de email correto para funcionários internos e externos. Você recebe listas de nomes de funcionários internos e externos. O endereço de email do funcionário consiste no nome de usuário e no nome de domínio da empresa.

O formato de nome de usuário é os dois primeiros caracteres do nome do funcionário, seguidos pelo sobrenome. Por exemplo, um funcionário chamado "Robert Bavin" teria o nome de usuário "robavin". O domínio para funcionários internos é "contoso.com".

Neste desafio, você recebe um código para iniciar. Você deve decidir como criar e chamar o método para exibir os endereços de email.


___

## Visão geral do Desafio :books: 

###  <font color=hotpink> Adicionar um método para exibir endereços de email </font>

&nbsp;&nbsp;:memo: No código inicial, há duas matrizes para funcionários internos e externos. 

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :pushpin: o domínio para funcionários internos é `"contoso.com"` e o nome de usuário para todos os funcionários terá os dois primeiros caracteres do nome, seguido pelo sobrenome completo. 

&nbsp;&nbsp;:memo: O método deve incluir um parâmetro opcional para o nome de domínio de funcionários externos.

&nbsp;&nbsp;:memo: O código inicial:


```csharp
string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
}

```

&nbsp;&nbsp; :memo: Verifique se o código produz a seguinte saída:


```
output:
_________________________

robavin@contoso.com
sibright@contoso.com
kisinclair@contoso.com
aakamath@contoso.com
sadelucchi@contoso.com
siali@contoso.com
viashton@hayworth.com
codysart@hayworth.com
shlawrence@hayworth.com
davaldes@hayworth.com
```