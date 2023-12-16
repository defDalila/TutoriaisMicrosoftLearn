Console.Clear();
// Início do Código

// Dados Do Animal
string[] dadosNecessarios = { "ID", "Espécie", "Nome", "Idade", "Características Físicas", "Personalidade" };
string[] especiesPermitdas = { "cachorro", "gato" };

string? animalId;
string? animalEspecie;
string? animalIdade;
string? animalNome;
string? animalCaractisticaFisica;
string? animalPersonalidade;


int capacidadeMaxima = 10;
string? readResult;
string?[,] animaisParaAdocao = new string[capacidadeMaxima, dadosNecessarios.Length];

for (var i = 0; i < capacidadeMaxima; i++)
{
	switch (i)
	{
		case 0:
			animalId = "C001";
			animalEspecie = "cachorro";
			animalIdade = "2";
			animalCaractisticaFisica = "Cachorro Golden Retriever fêmea de cor creme de tamanho médio, pesando cerca de 65 libras. Treinado para fazer as necessidades fora de casa.";
			animalPersonalidade = "Adora ter a barriga acariciada e gosta de perseguir o próprio rabo. Dá muitos beijinhos.";
			animalNome = "lola";
			break;
		case 1:
			animalId = "C002";
			animalEspecie = "cachorro";
			animalIdade = "9";
			animalCaractisticaFisica = "Grande Golden Retriever macho de cor marrom-avermelhada pesando cerca de 85 libras. Treinado para fazer as necessidades fora de casa.";
			animalPersonalidade = "Adora ter as orelhas acariciadas quando te recebe na porta, ou em qualquer momento! Gosta de se inclinar e dar abraços caninos.";
			animalNome = "loki";
			break;
		case 2:
			animalId = "G003";
			animalEspecie = "gato";
			animalIdade = "1";
			animalCaractisticaFisica = "Pequena fêmea branca pesando cerca de 8 libras. Treinada para usar a caixa de areia.";
			animalPersonalidade = "Amigável";
			animalNome = "Puss";
			break;
		case 3:
			animalId = "G004";
			animalEspecie = "gato";
			animalIdade = "?";
			animalCaractisticaFisica = null;
			animalPersonalidade = null;
			animalNome = null;
			break;

		default:
			animalId = null;
			animalEspecie = null;
			animalIdade = null;
			animalCaractisticaFisica = null;
			animalPersonalidade = null;
			animalNome = null;
			break;
	}

	string?[] dados = { animalId, animalEspecie, animalNome, animalIdade,
					   animalCaractisticaFisica, animalPersonalidade };


	for (var j = 0; j < dadosNecessarios.Length; j++)
	{
		animaisParaAdocao[i, j] = dados[j];
	}

}

string opcaoMenu;
do
{
	ExibirCabecalho();
	Console.WriteLine("\nOpções do menu principal:");
	Console.WriteLine(" [1] Listar todas as nossas informações atuais sobre animais de estimação");
	Console.WriteLine(" [2] Adicionar um novo animal amigo ao array ourAnimals");
	Console.WriteLine(" [3] Editar a idade de um animal");
	Console.WriteLine(" [4] Editar a descrição da personalidade de um animal");
	Console.WriteLine(" [5] Mostrar todos os gatos");
	Console.WriteLine(" [6] Mostrar todos os cães");
	Console.WriteLine();
	Console.Write("Digite o número da opção (ou digite [x] para sair do programa): ");

	readResult = Console.ReadLine();
	opcaoMenu = (readResult != null) ? readResult.ToLower() : "";

	string mensagem = $"Você escolheu a opção {opcaoMenu}";

	switch (opcaoMenu)
	{
		case "1":
			ExibirCabecalho();

			for (var i = 0; i < capacidadeMaxima; i++)
			{
				if (!String.IsNullOrEmpty(animaisParaAdocao[i, 0]))
				{
					Console.WriteLine($"");
					for (var j = 0; j < dadosNecessarios.Length; j++)
					{
						if (!String.IsNullOrEmpty(animaisParaAdocao[i, j]))
						{
							Console.WriteLine($"{dadosNecessarios[j]}: {animaisParaAdocao[i, j]}");
						}
						else
							Console.WriteLine($"{dadosNecessarios[j]}: _____________");
					}
				}
			}
			VoltarMenuAnterior();
			break;

		case "2":
			bool sair = false;
			while (!sair)
			{
				ExibirCabecalho();
				Console.WriteLine($"Opção 2: Inserir Novo Animal");

				int petCount = 0;

				for (var i = 0; i < capacidadeMaxima; i++)
				{
					if (!String.IsNullOrEmpty(animaisParaAdocao[i, 0]))
					{
						petCount++;
					}
				}

				string relacaoDeAnimais = "Relação de Animais na Instituição: \n" +
										  $"Total de vagas: \t{capacidadeMaxima}\n" +
										  $"Vagas Ocupadas: \t{petCount}\n" +
										  "------------------------------------\n\n";

				if (petCount >= capacidadeMaxima)
				{
					relacaoDeAnimais += "Por enquanto não temos nenhuma vaga disponível.";
					sair = true;


				}
				else
				{
					relacaoDeAnimais += $"Vagas lives: \t{capacidadeMaxima - petCount}";
					Console.WriteLine($"{relacaoDeAnimais}\n");

					bool entradaValida = false;
					string opcaoAddPet;
					do
					{
						Console.WriteLine("Deseja cadastrar algum animal?");
						Console.Write($"Responda com [s/n] : ");
						readResult = Console.ReadLine();

						opcaoAddPet = String.IsNullOrEmpty(readResult) ? "" : readResult.ToLower();
						entradaValida = opcaoAddPet == "s" || opcaoAddPet == "n";

						if (!entradaValida)
						{
							Console.WriteLine("Opção inválida. Por favor, responda com [s/n]");
						}

					} while (!entradaValida);

					if (opcaoAddPet == "n")
					{
						sair = true;
					}
					else
					{
						string?[] novoCadastro = new string[dadosNecessarios.Length];
						Console.WriteLine($"Você deseja adicionar um [gato] ou um [cachorro]? ");
						for (var i = 1; i < dadosNecessarios.Length; i++)
						{
							switch (i)
							{
								case 1:
									do
									{
										Console.Write($"{dadosNecessarios[i]}: ");
										readResult = Console.ReadLine();

										opcaoAddPet = String.IsNullOrEmpty(readResult) ? "" : readResult.ToLower();
										entradaValida = especiesPermitdas.Contains(opcaoAddPet);

										if (!entradaValida)
										{
											Console.WriteLine($"Opção inválida. Por favor, responda com [gato] ou [cachorro]");
										}

									} while (!entradaValida);
									novoCadastro[i] = opcaoAddPet;
									novoCadastro[0] = opcaoAddPet.Substring(0, 1).ToUpper() + (petCount+1).ToString("000");
									break;
								case 2:
									do
									{
										Console.WriteLine($"(Obrigatório)");
										Console.Write($"\t\t{dadosNecessarios[i]}: ");
										readResult = Console.ReadLine();

										entradaValida = !String.IsNullOrEmpty(readResult);


									} while (!entradaValida);
									novoCadastro[i] = readResult;
									break;
								case 3:
									do
									{
										Console.WriteLine($"(Número Inteiro) \t");
										Console.Write($"\t\t{dadosNecessarios[i]}: ");
										readResult = Console.ReadLine();

										if (!String.IsNullOrEmpty(readResult))
										{
											entradaValida = int.TryParse(readResult, out int _);
										}
										else
										{
											Console.WriteLine($"Deve ser fornecido um número inteiro, caso não saiba informar, responda com [0]");
										}
									} while (!entradaValida);
									novoCadastro[i] = readResult;
									break;
								case 4:
									entradaValida = false;
									do
									{
										Console.WriteLine($"(Obrigatório - Cor, gênero, etc...) \t");
										Console.Write($"\t\t{dadosNecessarios[i]}: ");
										readResult = Console.ReadLine();
										
										if (!String.IsNullOrEmpty(readResult))
										{
											entradaValida = true;
										}
										else
										{
											Console.WriteLine($"O campo {dadosNecessarios[i]} não pode ser vazio.");
										}
									} while (!entradaValida);
									novoCadastro[i] = readResult;
									break;
								default:
									Console.WriteLine($"(Opcional) \t\t");
									Console.Write($"\t\t{dadosNecessarios[i]}: ");
									readResult = Console.ReadLine();
									novoCadastro[i] = readResult;
									break;
							}
						}

						for (var i = 0; i < novoCadastro.Length; i++)
						{
							animaisParaAdocao[petCount, i] = novoCadastro[i];
						}
						
					}
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
		default:
			break;
	}

} while (opcaoMenu != "x");

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