using ServiceAndInject.Interfaces;

namespace ServiceAndInject.Services;

public class CalculatorService : ICalculatorService<int>
{
    public int Add(int left, int right)
    {
        return left + right;
    }

    public int Divide(int left, int right)
    {
        return left / right;
    }

    public int Multiply(int left, int right)
    {
        return left * right;
    }

    public int Subtract(int left, int right)
    {
        return left - right;
    }
}