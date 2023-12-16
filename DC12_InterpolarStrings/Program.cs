Console.Clear();

string nomeCliente = "Sra. Barros";

int acoesAtuais = 2975000;
string atualProduto = "Magic Yield";
decimal atualRetorno = 0.1275m;
decimal atualLucro = 55000000.0m;

string novoProduto = "Glorious Future";
decimal novoRetorno = 0.13125m;
decimal novoLucro = 63000000.0m;

// TODO : Implementar o código aqui.

string introducao = "";
introducao = $"Prezada {nomeCliente},\n\n";

introducao += $"ComoComo cliente de nossa oferta {atualProduto}, estamos entusiasmados em informá-la sobre um novo produto financeiro que poderia aumentar dramaticamente o seu retorno.\n\n";

introducao += $"Atualmente, você possui {acoesAtuais:N} ações com um retorno de {atualRetorno:P}\n\n";

introducao += $"Nosso novo produto, {novoProduto}, oferece um retorno de {novoRetorno:P2}. Dado o seu volume atual, seu lucro potencial seria de {novoLucro:C}.\n\n";

Console.Write(introducao);

Console.WriteLine("Aqui está uma rápida comparação:\n");

string mensagemComparacao = "";
 
mensagemComparacao += atualProduto.PadRight(20) + atualRetorno.ToString("P2").PadRight(10) + atualLucro.ToString("C") + "\n";

mensagemComparacao += novoProduto.PadRight(20) + novoRetorno.ToString("P2").PadRight(10) + novoLucro.ToString("C") + "\n";


Console.WriteLine(mensagemComparacao);




// Final do Código
Console.WriteLine("\n\nPressione qualquer tecla para fechar...");
Console.ReadKey();
Thread.Sleep(400);
Console.Clear();