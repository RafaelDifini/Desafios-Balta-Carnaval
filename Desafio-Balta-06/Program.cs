
class Program
{
    private static readonly Dictionary<char, char> codigos = new()
    {
        {'a', 'K'}, {'b', 'R'}, {'c', 'V'}, {'d', 'A'}, {'e', 'L'}, {'f', 'U'},
        {'g', 'I'}, {'h', 'R'}, {'i', 'M'}, {'j', 'S'}, {'k', 'P'}, {'l', 'B'},
        {'m', 'Y'}, {'n', 'J'}, {'o', 'D'}, {'p', 'C'}, {'q', 'E'}, {'r', 'T'},
        {'s', 'F'}, {'t', 'W'}, {'u', 'Z'}, {'v', 'G'}, {'w', 'N'}, {'y', 'H'},
        {'z', 'O'}, {'0', '#'}, {'1', '!'}, {'2', '$'}, {'3', '%'}, {'4', '&'},
        {'5', '|'}, {'6', '='}, {'7', '*'}, {'8', '/'}, {'9', '<'}, {' ', '_'}
    };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("1 - Para encriptar.");
            Console.WriteLine("2 - Para decriptar.");
            Console.WriteLine("3 - Para sair.");
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o texto para encriptar:");
                    var textoEncriptar = Console.ReadLine();
                    var textoEncriptado = EncriptarTexto(textoEncriptar);
                    Console.WriteLine($"Texto encriptado: {textoEncriptado}");
                    break;

                case 2:
                    Console.WriteLine("Digite o texto para decriptar:");
                    var textoDecriptar = Console.ReadLine();
                    var textoDecriptado = DecriptarTexto(textoDecriptar);
                    Console.WriteLine($"Texto decriptado: {textoDecriptado}");
                    break;

                case 3:
                    Console.WriteLine("Saindo..");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static string EncriptarTexto(string texto)
    {
        string textoEncriptado = "";
        foreach (char c in texto.ToLower())
        {
            if (codigos.ContainsKey(c))
            {
                textoEncriptado += codigos[c];
            }
            else
            {
                textoEncriptado += c;
            }
        }
        return textoEncriptado;
    }

    static string DecriptarTexto(string texto)
    {
        string textoDecriptado = "";
        foreach (char c in texto.ToUpper())
        {
            if (codigos.ContainsValue(c))
            {
                textoDecriptado += codigos.FirstOrDefault(x => x.Value == c).Key;
            }
            else
            {
                textoDecriptado += c;
            }
        }
        return textoDecriptado;
    }
}
