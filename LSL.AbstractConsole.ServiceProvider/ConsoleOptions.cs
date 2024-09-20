using System;
using System.IO;

namespace LSL.AbstractConsole.ServiceProvider
{
    /// <summary>
    /// Options for injecting the default <c cref="IConsole">IConsole</c> implementation
    /// </summary>
    public class ConsoleOptions
    {
        /// <summary>
        /// The <c>TextWriter</c> to use for all <c cref="IConsole">IConsole</c> injected services to use
        /// </summary>
        /// <value></value>
        public TextWriter TextWriter { get; set; } = Console.Out;
    }
}