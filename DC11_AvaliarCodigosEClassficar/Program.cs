Console.Clear();

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');
Array.Sort(orders);

foreach (var order in orders)
{
	if (order.Length == 4 )
	{
		Console.WriteLine($"{order}");
	}
	else
	{
		Console.WriteLine($"{order}\t- Error");
	}
}

// Final do Código
Console.WriteLine("\n\nPressione qualquer tecla para fechar...");
Console.ReadKey();
Thread.Sleep(400);
Console.Clear();