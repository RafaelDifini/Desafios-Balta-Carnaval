using System.Text;

namespace DesafioCarnaval4;
class Program
{
    static readonly decimal[] cedulas = { 200, 100, 50, 20, 10, 5, 2, 1, (decimal)(0.5), (decimal)0.25, (decimal)0.1, (decimal)0.05, (decimal)0.01 };
    static void Main(string[] args)
    {
        try
        {
            Console.Write("- Valor Final da Compra: R$ ");
            decimal.TryParse(Console.ReadLine(), out decimal valorCompra);
            Console.Write("- Pagamento: R$ ");
            decimal.TryParse(Console.ReadLine(), out decimal pagamento);
            var troco = ValorTroco(pagamento, valorCompra);
            var dinheiro = DarToco(troco);
            Console.WriteLine($"- Troco: \n{dinheiro}");
            if (troco < 0)
            {
                Console.WriteLine($"O cliente ainda precisa pagar {Math.Abs(troco).ToString("C")}!");
                return;
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("erro Interno : " + e.Message);
        }
    }

    static decimal ValorTroco(decimal pagamento, decimal valorCompra)
        => pagamento - valorCompra;


    static string DarToco(decimal _troco)
    {
        StringBuilder sb = new StringBuilder();

        foreach (var cedula in cedulas)
        {
            int quantidade = (int)(_troco / cedula);
            if (quantidade > 0)
            {
                _troco -= (quantidade * cedula);
                var opcao = (cedula > 0 && cedula < 1) ? "Moeda" : "Nota";
                sb.Append($"   - {quantidade} {opcao} {cedula} R$ \n");
            }

        }
        return sb.ToString();
    }
}