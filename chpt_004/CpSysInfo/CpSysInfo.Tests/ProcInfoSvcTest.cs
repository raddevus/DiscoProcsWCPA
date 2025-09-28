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
      var allProcInfo = pis.GetAllProcesses();
      Console.WriteLine($"{allProcInfo.Count()}");
      Console.WriteLine($"first: {allProcInfo.First().Name}: {allProcInfo.First().FileHash}");
      
    }

    [Fact]
    public void TestForProcsWithBlankName(){
       ProcInfoService pis = new();
       var allProcInfo = pis.GetAllProcesses();
      Console.WriteLine($"running process count: {allProcInfo.Count()}");
      var noNameProcs = allProcInfo.Where(item => string.IsNullOrEmpty(item.Name));
      Console.WriteLine($"{noNameProcs.Count()} process(es) have no name.");
      foreach (ProcInfo pi in noNameProcs){
         Console.WriteLine($" filename : {pi.Filename} pid: {pi.ProcId}");
      }
    }
}

