string nome, sobrenome, sobrenomeEmMaiusculo;

Console.Write("Digite seu primeiro nome:");
nome = Console.ReadLine()!;

Console.Write("Digite seu sobrenome:");
sobrenome = Console.ReadLine()!;

sobrenomeEmMaiusculo = sobrenome.ToUpper();

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Nome Catálogo: {sobrenomeEmMaiusculo}, {nome}");



