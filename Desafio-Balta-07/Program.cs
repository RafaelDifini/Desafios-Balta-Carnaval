
int rows;

Console.Write("Digite o número de linhas da pirâmide de Fibonacci: ");
rows = int.Parse(Console.ReadLine());

int[] fibonacci = new int[rows];
fibonacci[0] = 1;
fibonacci[1] = 1;

for (int i = 2; i < rows; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(fibonacci[j] + " ");
    }
    Console.WriteLine();
}

Console.ReadLine();

