Console.Clear();
// Início do Código

// Dados Do Animal
string[] dadosNecessarios = { "ID", "Espécie", "Idade", "Apelido", "Características Físicas", "Personalidade" };
string[] especiesPermitidas = { "gato", "cachorro" };

string? animalId;
string? animalEspecie;
string? animalIdade;
string? animalApelido;
string? animalCaractisticaFisica;
string? animalPersonalidade;


int capacidadeAnimais = 10;
string? readResult;
string?[,] animaisResgatados = new string[capacidadeAnimais, dadosNecessarios.Length];

for (var i = 0; i < capacidadeAnimais; i++)
{
	switch (i)
	{
		case 0:
			animalId = "C001";
			animalEspecie = "cachorro";
			animalIdade = "2";
			animalCaractisticaFisica = "Cachorro Golden Retriever fêmea de cor creme de tamanho médio, pesando cerca de 65 libras. Treinado para fazer as necessidades fora de casa.";
			animalPersonalidade = "Adora ter a barriga acariciada e gosta de perseguir o próprio rabo. Dá muitos beijinhos.";
			animalApelido = "lola";
			break;
		case 1:
			animalId = "C002";
			animalEspecie = "cachorro";
			animalIdade = "9";
			animalCaractisticaFisica = "Grande Golden Retriever macho de cor marrom-avermelhada pesando cerca de 85 libras. Treinado para fazer as necessidades fora de casa.";
			animalPersonalidade = "Adora ter as orelhas acariciadas quando te recebe na porta, ou em qualquer momento! Gosta de se inclinar e dar abraços caninos.";
			animalApelido = "loki";
			break;
		case 2:
			animalId = "G003";
			animalEspecie = "gato";
			animalIdade = "1";
			animalCaractisticaFisica = "Pequena fêmea branca pesando cerca de 8 libras. Treinada para usar a caixa de areia.";
			animalPersonalidade = "Amigável";
			animalApelido = "Puss";
			break;
		case 3:
			animalId = "G004";
			animalEspecie = "gato";
			animalIdade = "?";
			animalCaractisticaFisica = null;
			animalPersonalidade = null;
			animalApelido = null;
			break;

		default:
			animalId = null;
			animalEspecie = null;
			animalIdade = null;
			animalCaractisticaFisica = null;
			animalPersonalidade = null;
			animalApelido = null;
			break;
	}

	string?[] dados = { animalId, animalEspecie, animalIdade, animalApelido,
					   animalCaractisticaFisica, animalPersonalidade };


	for (var j = 0; j < dadosNecessarios.Length; j++)
	{
		animaisResgatados[i, j] = dados[j];
	}

}
Console.Clear();


string opcaoMenuPrincipal;
do
{
	ExibirCabecalho();
	Console.WriteLine("\nOpções do menu principal:");
	Console.WriteLine(" [1] Listar todas as nossas informações atuais sobre animais de estimação");
	Console.WriteLine(" [2] Adicionar um novo animal amigo ao array ourAnimals");
	Console.WriteLine(" [3] Garantir que as idades dos animais e descrições físicas estejam completas");
	Console.WriteLine(" [4] Garantir que os apelidos dos animais e descrições de personalidade estejam completas");
	Console.WriteLine(" [5] Editar a idade de um animal");
	Console.WriteLine(" [6] Editar a descrição da personalidade de um animal");
	Console.WriteLine(" [7] Mostrar todos os gatos com uma característica específica");
	Console.WriteLine(" [8] Mostrar todos os cães com uma característica específica");
	Console.WriteLine();
	Console.Write("Digite o número da opção (ou digite [x] para sair do programa): ");

	readResult = Console.ReadLine();
	opcaoMenuPrincipal = (readResult != null) ? readResult.ToLower() : "";

	string mensagem = $"Você escolheu a opção {opcaoMenuPrincipal}";

	switch (opcaoMenuPrincipal)
	{
		case "1":
		ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");

			for (var i = 0; i < capacidadeAnimais; i++)
			{
				if (!String.IsNullOrEmpty(animaisResgatados[i, 0]))
				{
					Console.WriteLine($"");
					for (var j = 0; j < dadosNecessarios.Length; j++)
					{
						if (!String.IsNullOrEmpty(animaisResgatados[i, j]))
						{
							Console.WriteLine($"{dadosNecessarios[j]}: {animaisResgatados[i, j]}");
						}
						else
							Console.WriteLine($"{dadosNecessarios[j]}: _____________");
					}
				}
			}
			VoltarMenuAnterior();
			break;

		case "2":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");

			bool adicionar = true;

			while (adicionar)
			{
				int count = 0;

				for (var i = 0; i < capacidadeAnimais; i++)
				{
					if (!String.IsNullOrEmpty(animaisResgatados[i, 0])) count++;
				}

				string mensagemRetorno = $"Capacidade Total de Pets:\t\t{capacidadeAnimais}\n" +
										 $"Total de Pets Registrados:\t\t{count}\n";

				if (count < capacidadeAnimais)
				{
					string opcao = "";
					mensagemRetorno += $"Quantidade de vagas disponíveis:\t{capacidadeAnimais - count}";
					Console.WriteLine($"{mensagemRetorno}");

					ExibirCabecalho();
					Console.WriteLine($"{mensagem}\n\n");

					do
					{
						Console.Write($"\nAdicionar um novo Pet [s/n]? ");
						readResult = Console.ReadLine();
						if (!String.IsNullOrEmpty(readResult))
						{
							opcao = readResult.ToLower();
						}
						else
						{
							Console.WriteLine($"Entrada Inválida, tente novamente.");
						}

					} while (opcao != "s" & opcao != "n");

					if (opcao == "s")
					{
						string?[] novoAnimal = new string[dadosNecessarios.Length];


						Console.WriteLine($"Entre com os dados do animal conforme campos abaixo: ");
						Console.WriteLine($" (os parâmetros com * são opcionais)");

						string especieValida = "";
						for (var i = 1; i < dadosNecessarios.Length; i++)
						{

							bool ehValido = false;

							switch (i)
							{
								case 1:
									
									do
									{
										Console.Write($"{dadosNecessarios[i]} [gato/cachorro]: ");
										readResult = Console.ReadLine();
										if (!String.IsNullOrEmpty(readResult)) especieValida = readResult.ToLower();
										else Console.WriteLine($"Entrada inválida, tente novamente.");

									} while (!especiesPermitidas.Contains(especieValida));
									novoAnimal[i] = especieValida;
									break;
								case 2:
									
									do
									{
										Console.Write($"{dadosNecessarios[i]}[número]: ");
										readResult = Console.ReadLine();
										if (!String.IsNullOrEmpty(readResult))
											ehValido = int.TryParse(readResult, out int _);
										else Console.WriteLine($"Idade não pode ser vazia.");
										if (!ehValido)
										{
											Console.WriteLine($"Entrada inválida, tente novamente.");
										}

									} while (!ehValido);
									novoAnimal[i] = readResult;
									break;

								default:
									Console.Write($"{dadosNecessarios[i]} *: ");
									readResult = Console.ReadLine();
									novoAnimal[i] = readResult;
									break;
							}
						}

						string novoId = especieValida.Substring(0, 1).ToUpper() + $"{count.ToString("000")}";
						novoAnimal[0] = novoId;

						Console.Write($"Cadastrando o novo Animal ");
						for (var i = 0; i < novoAnimal.Length; i++)
						{
							animaisResgatados[count - 1, i] = novoAnimal[i];
						}
						Carregando();
						Console.WriteLine($"Cadastro Realizado Com Sucesso! Segue dados para conferência: \n");

						for (var i = 0; i < dadosNecessarios.Length; i++)
						{
							Console.WriteLine($"{dadosNecessarios[i]}: {animaisResgatados[count - 1, i]}");
						}
						VoltarMenuAnterior();
						continue;
					}
					else
					{
						adicionar = false;
					}
				}
				else
				{
					mensagemRetorno += "\nTodas as vagas foram preenchidas! \U0001F62D";
					Console.WriteLine($"{mensagemRetorno}");
					adicionar = false;
				}
			}


			VoltarMenuAnterior();
			break;
		case "3":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");
			VoltarMenuAnterior();
			break;
		case "4":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");
			VoltarMenuAnterior();
			break;
		case "5":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");
			VoltarMenuAnterior();
			break;
		case "6":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");
			VoltarMenuAnterior();
			break;
		case "7":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");
			VoltarMenuAnterior();
			break;
		case "8":
			ExibirCabecalho();
			Console.WriteLine($"{mensagem}\n\n");
			break;
		default:
			break;
	}

} while (opcaoMenuPrincipal != "x");

SairAplicacao();
// Final do Código


static void VoltarMenuAnterior()
{
	Console.Write($"\nPressione uma tecla para voltar ao menu anterior ");
	Console.ReadKey();
}

static void SairAplicacao()
{
	Thread.Sleep(100);
	Thread.Sleep(150);
	Console.Write($"\n\nSaindo ");
	Thread.Sleep(50);
	Console.Write($"da ");
	Thread.Sleep(150);
	Console.Write($"aplicação ");
	Carregando();
	Console.Write("Close");
	Thread.Sleep(50);
	Console.Clear();
}

static void Carregando()
{
	Thread.Sleep(300);
	Console.Write($" .");
	Thread.Sleep(300);
	Console.Write($" .");
	Thread.Sleep(300);
	Console.WriteLine($" .");
	Thread.Sleep(300);
}

static void ExibirCabecalho()
{
	Console.Clear();
	Console.WriteLine(@"
█▀█ █▀▀ ▀█▀ █▀▀ █▀█ █ █▀▀ █▄░█ █▀▄   █▀▀ ▄▀█ █▀▀ █▀   █▀▀   █▀▀ ▄▀█ ▀█▀ █▀█ █▀
█▀▀ ██▄ ░█░ █▀░ █▀▄ █ ██▄ █░▀█ █▄▀   █▄▄ █▀█ ██▄ ▄█   ██▄   █▄█ █▀█ ░█░ █▄█ ▄█	
	");
}