using System;
using System.Globalization;
using Operacoes;
using ExibirPainel;

namespace MinhaCalculadora;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            PainelDeExibicao painel = new PainelDeExibicao();

            painel.ExibirPainel1();

            int operacao;

            if (int.TryParse(Console.ReadLine(), out operacao))
            {
                // Encerrar o Programa
                if (operacao == 5)
                {
                    Console.Clear();
                    painel.ExibirPainel2();
                    Console.WriteLine("Encerrando o Programa...");
                    Environment.Exit(0);
                }

                if (operacao > 0 && operacao <= 5)
                {
                    Console.Clear();
                    painel.ExibirPainel2();
                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Clear();
                    painel.ExibirPainel2();
                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    double resultado = 0;

                    switch (operacao)
                    {

                        case 1:
                            Soma soma = new Soma();
                            resultado = soma.Somar(num1, num2);
                            Console.WriteLine($"Resultado da Soma: {resultado}\n");
                            break;

                        case 2:
                            Subtracao subtracao = new Subtracao();
                            resultado = subtracao.Subtrair(num1, num2);
                            Console.WriteLine($"Resultado da Subtração: {resultado}\n");
                            break;

                        case 3:
                            Multiplicacao multiplicacao = new Multiplicacao();
                            resultado = multiplicacao.Multiplicar(num1, num2);
                            Console.WriteLine($"Resultado da Multiplicação: {resultado}\n");
                            break;

                        case 4:
                            Divisao divisao = new Divisao();
                            resultado = divisao.Dividir(num1, num2);
                            Console.WriteLine($"Resultado da Divisão: {resultado.ToString("F2", CultureInfo.InvariantCulture)}\n");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida! Tente de novo.\n");
                }
            }
        }
    }
}
