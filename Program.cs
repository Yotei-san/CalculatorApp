using System;

class CalculatorApp
{
    static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════╗");
        Console.WriteLine("║        CALCULADORA SIMPLES         ║");
        Console.WriteLine("╚════════════════════════════════════╝\n");

        bool executando = true;

        while (executando)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine("\nOperações disponíveis:");
                Console.WriteLine("  + Adição");
                Console.WriteLine("  - Subtração");
                Console.WriteLine("  * Multiplicação");
                Console.WriteLine("  / Divisão");
                Console.Write("\nEscolha a operação: ");
                string operacao = Console.ReadLine() ?? "";

                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine() ?? "0");

                // Chamando método para calcular o resultado
                double resultado = Calcular(numero1, numero2, operacao);

                Console.WriteLine($"\n{'─', 36}");
                Console.WriteLine($"Resultado: {numero1} {operacao} {numero2} = {resultado}");
                Console.WriteLine($"{'─', 36}\n");

                Console.Write("Deseja fazer outro cálculo? (s/n): ");
                string resposta = Console.ReadLine()?.ToLower() ?? "n";
                executando = resposta == "s";

                if (executando)
                    Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("❌ Erro: Digite números válidos!\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("❌ Erro: Não é possível dividir por zero!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro: {ex.Message}\n");
            }
        }

        Console.WriteLine("✓ Obrigado por usar a calculadora!");
    }

    /// <summary>
    /// Realiza uma operação matemática entre dois números
    /// </summary>
    /// <param name="numero1">Primeiro número</param>
    /// <param name="numero2">Segundo número</param>
    /// <param name="operacao">Operador (+, -, *, /)</param>
    /// <returns>Resultado da operação</returns>
    static double Calcular(double numero1, double numero2, string operacao)
    {
        return operacao switch
        {
            "+" => numero1 + numero2,
            "-" => numero1 - numero2,
            "*" => numero1 * numero2,
            "/" => numero2 != 0 ? numero1 / numero2 : throw new DivideByZeroException("Divisão por zero não permitida"),
            _ => throw new InvalidOperationException($"Operação '{operacao}' não reconhecida")
        };
    }
}
