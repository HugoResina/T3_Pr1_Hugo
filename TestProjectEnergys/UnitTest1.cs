using System;
using Xunit;
using T3_Pr1_Hugo;

public class EnergiaTests
{
    [Theory]
    [InlineData(30, 235.2)]
    [InlineData(20, 156.8)]
    public void Hidroelectric_CalculEnergia(double input, double expected)
    {
        var sistema = new SistemaHidroelectric();
        Assert.Equal(expected, sistema.CalculEnergia(input), 2);
    }

    [Theory]
    [InlineData(15, 45)]
    [InlineData(5, 5)]
    public void Eolic_CalculEnergia(double input, double expected)
    {
        var sistema = new SistemaEolic();
        Assert.Equal(expected, sistema.CalculEnergia(input), 2);
    }

    [Theory]
    [InlineData(10, 15)]
    [InlineData(1, 1.5)]
    public void Solar_CalculEnergia(double input, double expected)
    {
        var sistema = new SistemaSolar();
        Assert.Equal(expected, sistema.CalculEnergia(input), 2);
    }
}

public class ProgramTests
{
    [Theory]
    [InlineData(1, typeof(SistemaEolic))]
    [InlineData(2, typeof(SistemaHidroelectric))]
    [InlineData(3, typeof(SistemaSolar))]
    [InlineData(99, typeof(SistemaEolic))]
    public void ChooseSimulation_ReturnsCorrectType(int input, Type expectedType)
    {
        var result = MyProgram.ChooseSimulation();
        Assert.IsType(expectedType, result);
    }
}
