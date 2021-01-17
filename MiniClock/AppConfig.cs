using System.Collections.Generic;
using System.IO;
using Json;

namespace MiniClock
{
  public class AppConfig
  {
    public Dictionary<string, object> LoadConfig(string filename, Dictionary<string, object> default_config = null)
    {
      if(File.Exists(filename)) {
        string content = "";
        FileStream f = File.Open(filename, FileMode.OpenOrCreate);
        if(f.CanRead) {
          StreamReader r = new StreamReader(f);
          content = r.ReadToEnd();
        }
        f.Close();

        if (content.Length > 0) {
          return (Dictionary<string, object>)JsonParser.FromJson(content);
        }
      }

      if (default_config != null) {
        SaveConfig(filename, default_config);
        return default_config;
      } else {
        return null;
      }
    }

    public void SaveConfig(string filename, Dictionary<string, object> config)
    {
      var f = (new StreamWriter(filename));
      f.WriteLine(JsonParser.ToJson(config));
      f.Close();
    }
  }
}
