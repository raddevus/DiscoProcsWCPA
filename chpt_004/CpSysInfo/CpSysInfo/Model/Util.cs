using System.Security.Cryptography;
using System.Text;

namespace CpSysInfo.Model;

public class Util{
    public static string GenSha256FromFileBytes(string targetFile) 
    { 
        var sha = SHA256.Create();
            using (FileStream fs = new FileStream(targetFile, 
                                        FileMode.Open, 
                                        FileAccess.Read,    
                                        FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                        byte[] hash = sha.ComputeHash(fs);
                        return String.Concat(Array.ConvertAll(hash, x => x.ToString("x2")));
                }
            }
    }
}
