namespace CpSysInfo.Model;

public class OSEnvironment{
   
   /// Retrieves all environment vars and returns them as JSON 
   public string GetAllEnvironmentVars(){
      var allEnvVars = Environment.GetEnvironmentVariables();
      foreach (string k in allEnvVars.Keys) { 
         Console.WriteLine($"{k} => {allEnvVars[k]}"); }
      return "true";
   }
}

