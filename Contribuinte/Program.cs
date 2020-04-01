using System;
using System.Globalization;
using System.Collections.Generic;
using Contribuinte.Entidades;

namespace Contribuinte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Digite o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}: ");
                Console.Write("Pessoa fisica ou juridica (f/j)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Entre com o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(resp == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else if(resp == 'j')
                {
                    Console.Write("Numeros de funcionários: ");
                    int numero = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, numero));
                }
            }
            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: ");
            double soma = 0.00;
            foreach(Pessoa obj in list)
            {
                Console.WriteLine(obj.Nome
                    + ": $ "
                    + obj.Imposto().ToString("f2", CultureInfo.InvariantCulture));
                soma += obj.Imposto();
            }
            Console.WriteLine();
            Console.WriteLine("IMPOSTO TOTAL: $ " + soma.ToString("f2", CultureInfo.InvariantCulture));
         }
    }
}