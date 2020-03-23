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
        public List<string> PartyList { get; private set; }

        public event EventHandler FileSaved;

        private string FolderPath;

        public DataManager()
        {
            FolderPath = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}SavedParties{Path.DirectorySeparatorChar}";
            Directory.CreateDirectory(FolderPath);

            PartyList = new List<string>();
            RefreshPartyList();
        }

        private void RefreshPartyList()
        {
            PartyList = Directory.GetFiles(FolderPath, "*.json")
                        .Select(Path.GetFileNameWithoutExtension)
                        .ToList();
        }

        public void DeleteParty(string partyNameToDelete)
        {
            string fullPath = $"{FolderPath}{partyNameToDelete}.json";
            File.Delete(fullPath);
            RefreshPartyList();
        }

        public bool DoesPartyExist(string partyName)
        {
            return File.Exists($"{FolderPath}{partyName}.json");
        }

        public void ExportPartyToJSON(Party currentParty)
        {
            string fullPath = $"{FolderPath}{currentParty.PartyName}.json";
            int indexOfLastBackslash = fullPath.LastIndexOf("\\");
            FileInfo file = new FileInfo(fullPath.Substring(0, indexOfLastBackslash));
            file.Directory.Create();
            File.WriteAllText(fullPath, JsonConvert.SerializeObject(currentParty, Formatting.Indented));
            RefreshPartyList();

            OnFileSaved(null);
        }

        public Party ImportPartyFromJson(string partyName)
        {
            string path = $"{FolderPath}{partyName}.json";
            Party loadedParty = new Party();
            
            if (File.Exists(path))
            {
                loadedParty = JsonConvert.DeserializeObject<Party>(File.ReadAllText(path));
            }

            return loadedParty;
        }

        protected virtual void OnFileSaved(EventArgs e)
        {
            EventHandler handler = FileSaved;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
