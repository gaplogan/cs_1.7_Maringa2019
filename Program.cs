using System;

namespace cs_1._7_Maringa2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara três constantes do programa
            const double HAB = 423666, MULHER = 217000, VEICULO = 327000;

            //declara três variáveis reais do programa
            double PercF, PercM, VeiHab;

            //{Processamentos dos dados}
            PercM = ((HAB - MULHER) / HAB) * 100; // % de homens
            PercF = 100 - PercM; //% de mulheres
            VeiHab = VEICULO / HAB; //razão: veículos por habitante

            //{Saída das informações}
            Console.WriteLine($"Percentual de homens..: {PercM}%");
            Console.WriteLine($"Percentual de mulheres: {PercF}%");
            Console.WriteLine($"Veículos por habitante: {VeiHab}");
        }
    }
}
