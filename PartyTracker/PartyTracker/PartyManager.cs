using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTracker
{
    public class PartyManager
    {
        public bool DeleteMode { get; private set; }
        public bool ChangesSaved { get; private set; }
        public Party CurrentParty { get; private set; }

        public event EventHandler PartyLoadComplete;
        public event EventHandler PartyCreationComplete;
        public event EventHandler StartDeleteMode;
        public event EventHandler StopDeleteMode;

        private DataManager dm;
        private int playerIDCounter;
        private string OldPartyName;

        public PartyManager()
        {
            CurrentParty = new Party();
            DeleteMode = false;
            ChangesSaved = true;
            
            dm = new DataManager();
            dm.FileSaved += new EventHandler(dm_FileSaved);

            playerIDCounter = 0;
            if (CurrentParty.Players.Count > 0)
            {
                ValidatePlayerIDCounter();
            }
            OldPartyName = "";

            if ((Properties.Settings.Default.LoadLast) && (dm.DoesPartyExist(Properties.Settings.Default.LastOpenedParty)))
            {
                LoadParty(Properties.Settings.Default.LastOpenedParty);
            }
            else
            {
                CreateNewParty();
            }
        }

        public void AddPlayer()
        {
            CurrentParty.AddPlayer(playerIDCounter);
            playerIDCounter++;
        }

        public void RemovePlayer(int IDToRemove)
        {
            CurrentParty.RemovePlayer(IDToRemove);
        }

        public void UpdateCharacterName(int playerID, string characterName)
        {
            CurrentParty.UpdateCharacterName(playerID, characterName);
        }

        public void UpdateRace(int playerID, string characterRace)
        {
            CurrentParty.UpdateRace(playerID, characterRace);
        }

        public void UpdatePlayerName(int playerID, string playerName)
        {
            CurrentParty.UpdatePlayerName(playerID, playerName);
        }

        public void UpdateClass(int playerID, string characterClass)
        {
            CurrentParty.UpdateClass(playerID, characterClass);
        }

        public void UpdateLevel(int playerID, int characterLevel)
        {
            CurrentParty.UpdateLevel(playerID, characterLevel);
        }

        public void UpdateBackground(int playerID, string characterBackground)
        {
            CurrentParty.UpdateBackground(playerID, characterBackground);
        }

        public void UpdateAlignment(int playerID, string characterAlignment)
        {
            CurrentParty.UpdateAlignment(playerID, characterAlignment);
        }

        public void UpdateArmorClass(int playerID, int armorClass)
        {
            CurrentParty.UpdateArmorClass(playerID, armorClass);
        }

        public void UpdatePassivePercetion(int playerID, int passivePerception)
        {
            CurrentParty.UpdatePassivePercetion(playerID, passivePerception);
        }

        public void UpdateMaxHP(int playerID, int maxHP)
        {
            CurrentParty.UpdateMaxHP(playerID, maxHP);
        }

        public void UpdateNotes(int playerID, string characterNotes)
        {
            CurrentParty.UpdateNotes(playerID, characterNotes);
        }

        public void UpdateShowAdditionalInfo(int playerID, bool showAdditionalInfo)
        {
            CurrentParty.UpdateShowAdditionalInfo(playerID, showAdditionalInfo);
        }

        public void UpdatePartyNotes(string newPartyNotes)
        {
            CurrentParty.UpdatePartyNotes(newPartyNotes);
        }

        public void UpdatePartyName(string newPartyName)
        {
            if (string.IsNullOrWhiteSpace(OldPartyName))
            {
                OldPartyName = CurrentParty.PartyName;
            }
            CurrentParty.UpdatePartyName(newPartyName);
        }

        public void ActivateDeleteMode()
        {
            if (CurrentParty.Players.Count > 0)
            {
                DeleteMode = true;

                OnStartDeleteMode(null);
            }
        }

        public void DeactivateDeleteMode()
        {
            DeleteMode = false;

            OnStopDeleteMode(null);
        }

        public bool IsPartyNameUnique(string partyName)
        {
            return !dm.PartyList.Contains(partyName);
        }

        public List<string> GetPartyList()
        {
            return dm.PartyList;
        }

        private void RefreshLastOpenedParty()
        {
            Properties.Settings.Default.LastOpenedParty = CurrentParty.PartyName;
            Properties.Settings.Default.Save();
        }

        private void ValidatePlayerIDCounter()
        {
            if (CurrentParty.Players.Count > 0)
            {
                foreach (Player p in CurrentParty.Players)
                {
                    if (p.PlayerID > playerIDCounter)
                    {
                        playerIDCounter = p.PlayerID;
                    }
                }
                playerIDCounter++;
            }
            else
            {
                playerIDCounter = 0;
            }
        }

        public void SaveParty()
        {
            dm.ExportPartyToJSON(CurrentParty);
            RefreshLastOpenedParty();

            //if there was a party name change since the last save, delete the old json file
            if ((CurrentParty.PartyName != OldPartyName) && (!string.IsNullOrWhiteSpace(OldPartyName)))
            {
                dm.DeleteParty(OldPartyName);
                OldPartyName = "";
            }
        }

        public void LoadParty(string partyToLoad)
        {
            //import and transfer data
            CurrentParty = dm.ImportPartyFromJson(partyToLoad);
            OldPartyName = "";

            //sync ID counter
            ValidatePlayerIDCounter();

            //re-subscribe to events
            CurrentParty.PartyChanged += new EventHandler(cp_PartyChanged);

            RefreshLastOpenedParty();

            //trigger load complete event
            OnPartyLoadComplete(null);
        }

        public void CreateNewParty()
        {
            //import and transfer data
            CurrentParty = new Party();
            OldPartyName = "";

            //sync ID counter
            ValidatePlayerIDCounter();

            //re-subscribe to events
            CurrentParty.PartyChanged += new EventHandler(cp_PartyChanged);

            RefreshLastOpenedParty();

            //trigger creation  complete event
            OnPartyCreationComplete(null);
        }

        public void DeleteCurrentParty()
        {
            dm.DeleteParty(CurrentParty.PartyName);
            CreateNewParty();
        }

        private void cp_PartyChanged(object sender, EventArgs e)
        {
            ChangesSaved = false;

            if (Properties.Settings.Default.AutoSave)
            {
                SaveParty();
            }
        }

        private void dm_FileSaved(object sender, EventArgs e)
        {
            ChangesSaved = true;
        }

        protected virtual void OnPartyLoadComplete(EventArgs e)
        {
            EventHandler handler = PartyLoadComplete;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnPartyCreationComplete(EventArgs e)
        {
            EventHandler handler = PartyCreationComplete;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnStartDeleteMode(EventArgs e)
        {
            EventHandler handler = StartDeleteMode;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnStopDeleteMode(EventArgs e)
        {
            EventHandler handler = StopDeleteMode;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
