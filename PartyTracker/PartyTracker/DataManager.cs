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
            FolderPath = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}SavedParties{Path.DirectorySeparatorChar}";
            Directory.CreateDirectory(FolderPath);

            PartyList = new List<string>();
            RefreshPartyList();
        }

        public void RefreshPartyList()
        {
            PartyList = Directory.GetFiles(FolderPath, "*.json")
                        .Select(Path.GetFileNameWithoutExtension)
                        .ToList();
        }

        public void DeleteParty(string partyNameToDelete)
        {
            string fullPath = $"{FolderPath}{partyNameToDelete}.json";
            File.Delete(fullPath);
        }

        public void ExportPartyToJSON(Party currentParty)
        {
            string fullPath = $"{FolderPath}{currentParty.PartyName}.json";
            int indexOfLastBackslash = fullPath.LastIndexOf("\\");
            FileInfo file = new FileInfo(fullPath.Substring(0, indexOfLastBackslash));
            file.Directory.Create();
            File.WriteAllText(fullPath, JsonConvert.SerializeObject(currentParty, Formatting.Indented));
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
