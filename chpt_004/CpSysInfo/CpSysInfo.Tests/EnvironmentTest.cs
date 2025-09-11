using CpSysInfo.Model;
namespace CpSysInfo.Tests;

public class EnvironmentTest 
{
    [Fact]
    public void Test1()
    {
      Console.WriteLine("### This is the test output. ###");
      OSEnvironment ose = new();
      Console.WriteLine(ose.GetAllEnvironmentVars());
      
    }
}
