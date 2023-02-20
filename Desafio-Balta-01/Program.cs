
Console.WriteLine("Digite um texto: ");

var text = Console.ReadLine();

var wordsCount = text.Split(' ').Count();
var charsCount = text.Count();

Console.WriteLine(text);
Console.WriteLine($"{charsCount} caracteres, {wordsCount} palavras");

Console.ReadLine();
