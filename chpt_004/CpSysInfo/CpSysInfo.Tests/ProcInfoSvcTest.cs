using CpSysInfo.Model;
using CpSysInfo.Service;
namespace CpSysInfo.Tests;

public class ProcInfoSvcTest 
{
    [Fact]
    public void Test1()
    {
      Console.WriteLine("### ProcInfoSvcTest ###");
      ProcInfoService pis = new();
      pis.GetAllProcesses();
      
    }
}

