Console.Clear();

Console.WriteLine("--- Imitando Dory ---");

Console.WriteLine();

Console.Write("Escreva uma frase: ");

Console.WriteLine(
    Console.ReadLine()!
    .Replace("a", "aaa")
    .Replace("e", "eee")
    .Replace("i", "iii" )
    .Replace("o", "ooo")
    .Replace("u", "uuu")
);