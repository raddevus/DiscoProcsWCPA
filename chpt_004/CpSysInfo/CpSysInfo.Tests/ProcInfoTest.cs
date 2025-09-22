using CpSysInfo.Model;
namespace CpSysInfo.Tests;

public class ProcInfoTest 
{
    [Fact]
    public void Test1()
    {
      Console.WriteLine("### ProcInfoTest ###");
      ProcInfo pi = new ("name","file-name", 100);
      Console.WriteLine($"{pi.Name} {pi.Filename}");
      
    }
}
