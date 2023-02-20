Console.WriteLine("Insira o valor da gasolina:");
decimal valorGasolina = decimal.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor do Alcool");
decimal valorAlcool = decimal.Parse(Console.ReadLine());

decimal divisao = valorAlcool * 100 / valorGasolina;

if (divisao <= 70M)
    Console.WriteLine($"A relação de custo é de {divisao.ToString().Substring(0, 4)}, está valendo a pena abastecer com alcool");
else
    Console.WriteLine($"A relação de custo é de {divisao.ToString().Substring(0, 4)}, Melhor abastecer com gasolina");