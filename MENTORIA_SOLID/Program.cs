using System;

namespace MENTORIA_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Paulo Machado";
            var valorNaCarteira = 10000.00D;

            var nomeDoPrimeiroInvestimento = "Poupança";
            var valorDoPrimeiroInvestimento = 5000.00D;
            var valorDoImpostoDeRenda = 00.00D;
            var valodDoIoF = 00.00D;
            var valorDoICMS = 00.00D;
            var tempoDeInvestimentoEmDias = 180;
            var rendimentoMensal = 0.04D;

            var valorTotalDoRendimento = tempoDeInvestimentoEmDias / 30 * rendimentoMensal * valorDoPrimeiroInvestimento / 100;
            var valorTotal = valorDoPrimeiroInvestimento + valorTotalDoRendimento;
            Console.WriteLine($"O investimento na {nomeDoPrimeiroInvestimento} no valor de "
            + $"{valorDoPrimeiroInvestimento} rendeu "
            + $"{valorTotalDoRendimento}, tendo o {nome} o valor total nesse investimento de "
            + $"{valorTotal}");
        }
    }
}
