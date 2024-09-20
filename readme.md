[![Build status](https://img.shields.io/appveyor/ci/alunacjones/lsl-abstractconsole-serviceprovider.svg)](https://ci.appveyor.com/project/alunacjones/lsl-abstractconsole-serviceprovider)
[![Coveralls branch](https://img.shields.io/coverallsCoverage/github/alunacjones/LSL.AbstractConsole.ServiceProvider)](https://coveralls.io/github/alunacjones/LSL.AbstractConsole.ServiceProvider)
[![NuGet](https://img.shields.io/nuget/v/LSL.AbstractConsole.ServiceProvider.svg)](https://www.nuget.org/packages/LSL.AbstractConsole.ServiceProvider/)

# LSL.AbstractConsole.ServiceProvider

Provides an `IServiceCollection` extension to register the default `IConsole` implementation of [LSL.AbstractConsole](https://www.nuget.org/packages/LSL.AbstractConsole)

```csharp
using LSL.AbstractConsole.ServiceProvider

...

var services = new ServiceCollection()
    // Allows for optionally setting of the TextWriter in adding the IConsole service 
    // to the service collection. It defaults to Console.Out
    .AddAbstractConsole(o => o.TextWriter = new StringWriter());

// You may also configure the ConsoleOptions via the `Configure` method of a service
// collection to defer setting up the TextWriter to something that needs to resolve from
// aa service provider
```
