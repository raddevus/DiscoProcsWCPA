using CpSysInfo.Model;

namespace CpSysInfo.Service;
class ProcInfoService{
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
}
