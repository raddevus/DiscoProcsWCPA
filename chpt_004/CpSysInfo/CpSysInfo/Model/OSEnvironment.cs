using System.Collections;
using System.Text.Json;

namespace CpSysInfo.Model;

public class OSEnvironment{
   
   /// Retrieves all environment vars and returns them as JSON 
   public string GetAllEnvironmentVars(){
      var allEnvVars = Environment.GetEnvironmentVariables()
         // Cast each name/value pair to a DictionaryEntry
         .Cast<DictionaryEntry>() // This returns an IEnumerable of DictionaryEntry<string,string>
         // sort each entry by it's Key (environment var name)
         .OrderBy(obj => obj.Key); // This call returns an Enumerable wrapper around all the items

      // Next line displays the allEnvVars type (Enumerable) & how many items are in the System.Linq.Enumerable+OrderedIterator object which is returned by the LINQ OrderBy() method 
      Console.WriteLine($"{allEnvVars.GetType()} : {allEnvVars.Count()}");
      foreach (DictionaryEntry k in allEnvVars) { 
         Console.WriteLine($"{k.Key} => {k.Value}"); }
      return JsonSerializer.Serialize(allEnvVars);
   }
}
