using CpSysInfo.Model;

namespace CpSysInfo.Service;
public class ProcInfoService{
   public IEnumerable<ProcInfo> GetAllProcesses()
    {
        foreach (var proc in System.Diagnostics.Process.GetProcesses())
        {
            string filename = string.Empty;
            try
            {
                filename = proc.MainModule?.FileName ?? string.Empty;
            }
            catch { /* access denied for some system processes */ }

            yield return new ProcInfo(proc.ProcessName, filename, proc.Id);
        }
    }

   public IEnumerable<ProcInfo> GetAllUniqueProcesses(){
      var allProcs = new List<ProcInfo>(); 
      foreach (var proc in System.Diagnostics.Process.GetProcesses())
        {
            string filename = string.Empty;
            try
            {
                filename = proc.MainModule?.FileName ?? string.Empty;
            }
            catch { /* access denied for some system processes */ }

             allProcs.Add(new ProcInfo(proc.ProcessName, filename, proc.Id));
        }
      return allProcs.Where(item => !string.IsNullOrEmpty(item.Name))
         .DistinctBy(item => new {item.Name, item.Filename})
         .OrderBy(item => item.Name);
   }
}
