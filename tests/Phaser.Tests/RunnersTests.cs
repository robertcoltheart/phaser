namespace Phaser.Tests;

public class RunnersTests
{
    [Test]
    [Arguments("dotnet", "--list-sdks")]
    [Arguments("dotnet.exe", "--list-sdks")]
    [Arguments("npm", "--version")]
    public void CanRunWithSuccess(string name, string arguments)
    {
        Runners.Run(name, arguments);
    }
}
