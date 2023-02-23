Console.WriteLine("Digite o valor que deseja escrever por extenso: ");
double valor = double.Parse(Console.ReadLine());
string valorPorExtenso = ConverteValorPorExtenso(valor);
Console.WriteLine(valorPorExtenso);

static string ConverteValorPorExtenso(double valor)
{
    int reais = (int)Math.Truncate(valor);
    int centavos = (int)Math.Round((valor - reais) * 100);

    string valorPorExtenso = NumeroPorExtenso(reais) + " REAIS";
    if (centavos > 0)
    {
        valorPorExtenso += " E " + NumeroPorExtenso(centavos) + " CENTAVOS";
    }

    return valorPorExtenso.ToUpper();
}

static string NumeroPorExtenso(int numero)
{
    if (numero > 99999999)
    {
        return $"Erro\nNumero exigido acima do suportado pelo programa\nDigite numeros entre -99999999 e 99999999";
    }
    if (numero == 0)
    {
        return "ZERO";
    }

    if (numero < 0)
    {
        return "MENOS " + NumeroPorExtenso(Math.Abs(numero));
    }

    string valorPorExtenso = "";

    if ((numero / 1000000) > 0)
    {
        valorPorExtenso += NumeroPorExtenso(numero / 1000000) + " MILHÕES ";
        numero %= 1000000;
    }

    if ((numero / 1000) > 0)
    {
        if ((numero / 1000) > 0)
        {
            if (numero / 1000 == 1)
            {
                valorPorExtenso += "MIL ";
            }
            else
            {
                valorPorExtenso += NumeroPorExtenso(numero / 1000) + " MIL ";
            }
            numero %= 1000;
        }
    }

    if ((numero / 100) > 0)
    {
        valorPorExtenso += NumeroPorExtenso(numero / 100) + "CENTOS ";
        numero %= 100;
    }

    if (numero > 0)
    {
        if (valorPorExtenso != "")
        {
            valorPorExtenso += "E ";
        }

        string[] unidades = { "", "UM", "DOIS", "TRÊS", "QUATRO", "CINCO", "SEIS", "SETE", "OITO", "NOVE", "DEZ", "ONZE", "DOZE", "TREZE", "QUATORZE", "QUINZE", "DEZESSEIS", "DEZESSETE", "DEZOITO", "DEZENOVE" };
        string[] dezenas = { "", "DEZ", "VINTE", "TRINTA", "QUARENTA", "CINQUENTA", "SESSENTA", "SETENTA", "OITENTA", "NOVENTA" };

        if (numero < 20)
        {
            valorPorExtenso += unidades[numero];
        }
        else
        {
            valorPorExtenso += dezenas[numero / 10];
            if ((numero % 10) > 0)
            {
                valorPorExtenso += " E " + unidades[numero % 10];
            }
        }
    }

    return valorPorExtenso;
}

