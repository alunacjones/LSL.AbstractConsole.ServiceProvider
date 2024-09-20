using System;
using Microsoft.Extensions.DependencyInjection;

namespace LSL.AbstractConsole.ServiceProvider
{
    /// <summary>
    /// AbstractConsoleServiceCollectionExtensions
    /// </summary>
    public static class AbstractConsoleServiceCollectionExtensions
    {
        /// <summary>
        /// Register the default <c cref="IConsole">IConsole</c> implementation and optionally configure the options (defaults the output to Console.Out)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="configurer">Delegate to setup the <c cref="ConsoleOptions">ConsoleOptions</c> </param>
        /// <returns></returns>
        public static IServiceCollection AddAbstractConsole(this IServiceCollection source, Action<ConsoleOptions> configurer = null)
        {
            configurer ??= (o => {});
            
            return source
                .AddSingleton<IConsole, DefaultConsole>()
                .Configure(configurer);
        }
    }
}