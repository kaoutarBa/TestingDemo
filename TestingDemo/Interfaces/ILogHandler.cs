namespace TestingDemo.Interfaces;

public interface ILogHandler
{
    void LogInfo(string message);
    void LogError(string message);
}
