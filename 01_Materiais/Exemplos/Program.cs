Console.Clear();






//Parte01();

static void Parte01()
{
	Console.Write("Valor da Compra: ");
	var valorCompra = double.Parse(Console.ReadLine());

	int desconto = valorCompra >= 1000 ? 100 : 50;

	Console.WriteLine($"Desconto: {desconto:c}\nTotal: {valorCompra - desconto:c}");

	Console.WriteLine("Pressione qualquer tecla...");
	Console.ReadKey();
	Console.Clear();
}

