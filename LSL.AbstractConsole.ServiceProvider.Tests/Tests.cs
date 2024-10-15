using System;
using System.IO;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace LSL.AbstractConsole.ServiceProvider.Tests;

public class Tests
{
    [Test]
    public void GivenAServiceCollectionWithAnAbstractConsole_ThenItShouldLogAsExpected()
    {
        using var writer = new StringWriter();

        var provider = new ServiceCollection()
            .AddAbstractConsole(c => c.TextWriter = writer)
            .BuildServiceProvider();

        provider.GetRequiredService<IConsole>().Write("hello");

        writer
            .ToString()
            .Should()
            .Be("hello");
    }

    [Test]
    public void GivenAServiceCollectionWithAnUnconfiguredAbstractConsole_ThenItShouldLogToConsoleOut()
    {
        using var writer = new StringWriter();

        Console.SetOut(writer);
        
        var provider = new ServiceCollection()
            .AddAbstractConsole()
            .BuildServiceProvider();

        provider.GetRequiredService<IConsole>().Write("hello");

        writer
            .ToString()
            .Should()
            .Be("hello");
    }    
}