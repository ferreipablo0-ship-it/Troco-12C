decimal valorCompra, valorPago, valorTroco;
Console.WriteLine("--- Digite o Valor da sua compra ---");
valorCompra = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("--- Digite o valor pago --- ");
valorPago = Convert.ToDecimal(Console.ReadLine());
valorTroco = valorPago - valorCompra;

Console.WriteLine("--- Troco de Compra ---\n");

Console.WriteLine($"Valor da compra(R$)...: {valorCompra}");

Console.WriteLine($"Valor pago (R$)........: {valorPago}");

Console.WriteLine($"\nValor do troco (S$):{valorTroco}");
