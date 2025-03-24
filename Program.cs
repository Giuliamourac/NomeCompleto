


Console.WriteLine("Escreva seu primeiro nome.");

string nome = Console.ReadLine();

Console.WriteLine("Escreva seu sobrenome.");

string sobrenome = Console.ReadLine();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");

Console.WriteLine($"Nome de catalogo: {sobrenome.ToUpper()!}, {nome}");

Console.ReadKey();