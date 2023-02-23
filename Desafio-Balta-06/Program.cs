int opcao = 0;
do
{
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Para encriptar.");
    Console.WriteLine("2 - Para desencriptar.");
    Console.WriteLine("0 - Para sair.");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o texto que deseja encriptar:");
            string textoEncriptar = Console.ReadLine();
            string textoEncriptado = EncriptarTexto(textoEncriptar);
            Console.WriteLine("Texto encriptado: " + textoEncriptado);
            Console.WriteLine("Pressione Enter para continuar.");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("Digite o texto que deseja desencriptar:");
            string textoDesencriptar = Console.ReadLine();
            string textoDesencriptado = DesencriptarTexto(textoDesencriptar);
            Console.WriteLine("Texto desencriptado: " + textoDesencriptado);
            Console.WriteLine("Pressione Enter para continuar.");
            Console.ReadLine();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Pressione Enter para continuar.");
            Console.ReadLine();
            break;
    }
} while (opcao != 0);


static string EncriptarTexto(string texto)
{
    string textoEncriptado = "";
    foreach (char c in texto)
    {
        int valorAscii = (int)c;
        valorAscii += 7;
        char caractereEncriptado = (char)valorAscii;
        textoEncriptado += caractereEncriptado;
    }
    return textoEncriptado;
}

static string DesencriptarTexto(string texto)
{
    string textoDesencriptado = "";
    foreach (char c in texto)
    {
        int valorAscii = (int)c;
        valorAscii -= 7;
        char caractereDesencriptado = (char)valorAscii;
        textoDesencriptado += caractereDesencriptado;
    }
    return textoDesencriptado;
}