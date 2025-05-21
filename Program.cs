using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informational Version: " + ThisAssembly.AssemblyInformationalVersion);
        Console.WriteLine("Nový commit test."); 
    }
}
