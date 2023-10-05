namespace Operacoes;

public class Divisao
{
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.Clear();
            Console.WriteLine("Não é possível dividir por zero.");
            return double.NaN;
        }
        Console.Clear();
        return a / b;
    }
}