string nome, sobrenome;
Console.Write("Digite seu primeiro nome:   ");
nome = Console.ReadLine()!;
Console.Write("Digite seu segundo nome:   ");
sobrenome = Console.ReadLine()!;
string maiúscula = sobrenome.ToUpper();
Console.WriteLine($"Nome Completo: {nome}, {sobrenome}");
Console.WriteLine($"Nome de catálogo: {maiúscula}, {nome}");

