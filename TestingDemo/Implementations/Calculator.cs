namespace TestingDemo.Implementations;

public class Calculator : ICalculator
{
    private readonly ILogHandler _logger;

    public Calculator(ILogHandler logger)
    {
        _logger = logger;
    }

    public int Add(int a, int b)
    {
        _logger.LogInfo($"Adding {a} and {b}");
        int result = a + b;
        _logger.LogInfo($"Result: {result}");
        return result;
    }

    public int Divide(int a, int b)
    {
        _logger.LogInfo($"Dividing {a} by {b}");
        if (b == 0)
        {
            _logger.LogError("Cannot divide by zero");
            throw new ArgumentException("Cannot divide by zero");
        }
        int result = a / b;
        _logger.LogInfo($"Result: {result}");
        return result;
    }
}
