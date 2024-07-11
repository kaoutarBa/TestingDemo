namespace TestingDemo.Tests.CalculatorTest;

public class CalculatorTest
{
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var loggerMock = new Mock<ILogHandler>();
        var calculator = new Calculator(loggerMock.Object);

        // Act
        int result = calculator.Add(3, 4);

        // Assert
        Assert.Equal(7, result);
        loggerMock.Verify(l => l.LogInfo("Adding 3 and 4"), Times.Once);
        loggerMock.Verify(l => l.LogInfo("Result: 7"), Times.Once);
    }

    [Fact]
    public void Divide_DivisorNotZero_ReturnsQuotient()
    {
        // Arrange
        var loggerMock = new Mock<ILogHandler>();
        var calculator = new Calculator(loggerMock.Object);

        // Act
        int result = calculator.Divide(10, 2);

        // Assert
        Assert.Equal(5, result);
        loggerMock.Verify(l => l.LogInfo("Dividing 10 by 2"), Times.Once);
        loggerMock.Verify(l => l.LogInfo("Result: 5"), Times.Once);
    }

    [Fact]
    public void Divide_DivisorZero_ThrowsException()
    {
        // Arrange
        var loggerMock = new Mock<ILogHandler>();
        var calculator = new Calculator(loggerMock.Object);

        // Act & Assert
        Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
        loggerMock.Verify(l => l.LogInfo("Dividing 10 by 0"), Times.Once);
        loggerMock.Verify(l => l.LogError("Cannot divide by zero"), Times.Once);
    }
}
