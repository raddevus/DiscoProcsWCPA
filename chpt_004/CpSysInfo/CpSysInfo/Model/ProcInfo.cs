using System.Diagnostics;

namespace CpSysInfo.Model;
public class ProcInfo{
    public Int32 Id{get;set;}
    public string Name{get;set;}
    public string Filename{get;set;}
    public string? FileDate{get;set;}
    public int ProcId{get;set;}

    public string FileHash{get;set;}

    public long FileSize{get;set;}
    
    public String? Created{get;set;}

    public ProcInfo(String name, String filename, int procId)
    {
        name = name.Trim().ToLower();
        if (!String.IsNullOrEmpty(name)){
            var endIdx = name.IndexOf(' ');
            if (endIdx > 0){
                name = name.Substring(0,endIdx);
            }
        }
        Name = name;
        Filename = filename;
        ProcId = procId;
        Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        try{
            if (Filename != null && Filename != String.Empty){
               if (File.Exists(Filename)){
                FileInfo fi = new FileInfo(Filename);
                FileSize = fi.Length;
                FileDate = fi.CreationTime.ToString("yyyy-MM-dd HH:mm:ss");
                FileHash = "fake-value"; 
               }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"FAIL! : {ex.GetType().ToString()}:{ex.Message}");
            throw ex;
        }
    }
}
