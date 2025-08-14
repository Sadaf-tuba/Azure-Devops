using System;
using System.Threading.Tasks;

namespace SampleDotNet9App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to .NET 9 on Azure Pipelines!");
            await Task.Delay(1000);
            Console.WriteLine($"You're running on: {Environment.Version}");
        }
    }
}
