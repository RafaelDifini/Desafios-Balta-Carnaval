Console.Write("Infome sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.Write("Informe sua altura(m): ");
decimal altura = decimal.Parse(Console.ReadLine());
Console.Write("Informe seu peso(kg): ");
decimal peso = decimal.Parse(Console.ReadLine());

decimal calculoIMC = peso / (altura * altura);
string classificacao = String.Empty;
string risco = string.Empty;
string grauDeObesidade = string.Empty;


if (idade <= 5 && calculoIMC < 18.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Baixo peso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade <= 5 && calculoIMC >= 18.5M || calculoIMC <= 24.9M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Peso adequado";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade <= 5 && calculoIMC >= 25)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Sobrepeso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "1";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade <= 5 && calculoIMC >= 30)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC}");
    classificacao = "Obesidade";
    Console.WriteLine(classificacao);
    grauDeObesidade = "2";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade <= 5 && calculoIMC >= 35)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade grave";
    Console.WriteLine(classificacao);
    grauDeObesidade = "3";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 6 || idade <= 10 && calculoIMC < 18.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Baixo peso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 6 || idade <= 10 && calculoIMC <= 18.5M || calculoIMC <= 22.9M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Peso adequado";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 6 || idade <= 10 && calculoIMC <= 23 || calculoIMC < 27.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Sobrepeso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "1";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 6 || idade <= 10 && calculoIMC >= 27.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade";
    Console.WriteLine(classificacao);
    grauDeObesidade = "2";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 6 || idade <= 10 && calculoIMC >= 32.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade grave";
    Console.WriteLine(classificacao);
    grauDeObesidade = "3";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 11 || idade <= 19 && calculoIMC < 18.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Baixo peso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 11 || idade <= 19 && calculoIMC <= 18.5M || calculoIMC <= 24.9M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Peso adequado";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 11 || idade <= 19 && calculoIMC >= 25M || calculoIMC < 30)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Sobrepeso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "1";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 11 || idade <= 19 && calculoIMC >= 30M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade";
    Console.WriteLine(classificacao);
    grauDeObesidade = "2";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 11 || idade <= 19 && calculoIMC >= 30M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade";
    Console.WriteLine(classificacao);
    grauDeObesidade = "2";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 11 || idade <= 19 && calculoIMC >= 35M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade grave";
    Console.WriteLine(classificacao);
    grauDeObesidade = "3";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 20 || idade <= 59 && calculoIMC < 18.5M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Baixo peso 25";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 20 || idade <= 59 && calculoIMC >= 18.5M || calculoIMC <= 24.9M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Peso adequado";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 20 || idade <= 59 && calculoIMC >= 25M || calculoIMC <= 29.9M)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Sobrepeso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "1";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 20 || idade <= 59 && calculoIMC >= 30)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade";
    Console.WriteLine(classificacao);
    grauDeObesidade = "2";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 20 || idade <= 59 && calculoIMC >= 35)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Obesidade grave";
    Console.WriteLine(classificacao);
    grauDeObesidade = "3";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 60 && calculoIMC < 23)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Baixo peso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 60 && calculoIMC <= 23 || calculoIMC <= 28)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Peso adequado";
    Console.WriteLine(classificacao);
    grauDeObesidade = "0";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Baixo";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 60 && calculoIMC >= 28)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Sobrepeso/Obesidade";
    Console.WriteLine(classificacao);
    grauDeObesidade = "1";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Elevado";
    Console.WriteLine($"Risco: {risco}");
}
else if (idade >= 60 && calculoIMC >= 33)
{
    Console.WriteLine($"Seu IMC é: {calculoIMC.ToString().Substring(0, 4)}");
    classificacao = "Sobrepeso";
    Console.WriteLine(classificacao);
    grauDeObesidade = "2";
    Console.WriteLine($"Obesidade Grau {grauDeObesidade}");
    risco = "Muito elevado";
    Console.WriteLine($"Risco: {risco}");
}