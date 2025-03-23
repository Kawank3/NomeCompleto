string nome;
string sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
