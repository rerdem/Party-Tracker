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

        public List<string> PartyList { get; private set; }

        private string FolderPath;

        public DataManager()
        {
            FolderPath = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}SavedParties";
            Directory.CreateDirectory(FolderPath);

            PartyList = new List<string>();
            RefreshPartyList();
            Console.WriteLine(PartyList.ElementAt(0));
        }




        public void RefreshPartyList()
        {
            PartyList = Directory.GetFiles(FolderPath, "*.json")
                        .Select(Path.GetFileNameWithoutExtension)
                        .ToList();
        }

        public void ExportPartyToJSON(string path, Party currentParty)
        {
            int indexOfLastBackslash = path.LastIndexOf("\\");
            FileInfo file = new FileInfo(path.Substring(0, indexOfLastBackslash));
            file.Directory.Create();
            File.WriteAllText(path, JsonConvert.SerializeObject(currentParty, Formatting.Indented));
        }

        public Party ImportPartyFromJson(string path)
        {
            Party loadedParty = new Party();
            
            if (File.Exists(path))
            {
                loadedParty = JsonConvert.DeserializeObject<Party>(File.ReadAllText(path));
            }

            return loadedParty;
        }
    }
}
