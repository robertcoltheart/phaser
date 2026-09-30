
using System.Diagnostics;

namespace Phaser;

public static class Runners
{
    public static void Run(string name, string arguments = "")
    {
        using var process = new Process();

        process.StartInfo = new ProcessStartInfo
        {
            FileName = name,
            Arguments = arguments,
            CreateNoWindow = false,
            UseShellExecute = false,
        };

        Console.WriteLine($"{name} {arguments}");

        process.Start();
        process.WaitForExit();

        if (process.ExitCode != 0)
        {
            Environment.Exit(process.ExitCode);
        }
    }
}
