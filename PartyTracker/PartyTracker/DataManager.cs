using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTracker
{
    public class DataManager
    {
        //TO DO
        //read or create config
        //read or create default party
        //save party
        //load party

        public DataManager()
        {

        }






        public void exportPartyToJSON(string path, PartyManager pm)
        {
            int indexOfLastBackslash = path.LastIndexOf("\\");
            FileInfo file = new FileInfo(path.Substring(0, indexOfLastBackslash));
            file.Directory.Create();
            File.WriteAllText(path, JsonConvert.SerializeObject(pm, Formatting.Indented));
        }

        public PartyManager importPartyFromJson(string path)
        {
            PartyManager pm = new PartyManager();
            
            if (File.Exists(path))
            {
                pm = JsonConvert.DeserializeObject<PartyManager>(File.ReadAllText(path));
            }

            return pm;
        }
    }
}
