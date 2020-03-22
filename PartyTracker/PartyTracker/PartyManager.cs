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
        public Party CurrentParty { get; private set; }

        private DataManager dm;
        private string OldPartyName;

        public PartyManager()
        {
            CurrentParty = new Party();
            DeleteMode = false;
            dm = new DataManager();
            OldPartyName = "";

            CurrentParty.PartyNameChanged += new EventHandler(cp_PartyNameChanged);
        }

        public void AddPlayer()
        {
            CurrentParty.AddPlayer();
        }

        public void AddPlayer(string characterName, string playerName, string race, bool showAdditionalInfo, string characterClass, int level, string background, string alignment, int ac, int passivePerception, int maxHP, string notes)
        {
            CurrentParty.AddPlayer(characterName, playerName, race, showAdditionalInfo, characterClass, level, background, alignment, ac, passivePerception, maxHP, notes);
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
            OldPartyName = CurrentParty.PartyName;
            CurrentParty.UpdatePartyName(newPartyName);
        }

        public void StartDeleteMode()
        {
            if (CurrentParty.Players.Count>0)
            {
                DeleteMode = true;
            }
        }

        public void StopDeleteMode()
        {
            DeleteMode = false;
        }

        public bool IsPartyNameUnique(string partyName)
        {
            return !dm.PartyList.Contains(partyName);
        }

        private void RefreshLastOpenedParty()
        {
            Properties.Settings.Default.LastOpenedParty = CurrentParty.PartyName;
            Properties.Settings.Default.Save();
        }

        public void SaveParty()
        {
            dm.ExportPartyToJSON(CurrentParty);
            RefreshLastOpenedParty();
            dm.RefreshPartyList();
        }

        public void LoadParty()
        {
            //set last party name to current
        }

        public void CreateNewParty()
        {
            //set last party name to current
        }

        private void cp_PartyNameChanged(object sender, EventArgs e)
        {
            SaveParty();
            RefreshLastOpenedParty();
            
            if (!string.IsNullOrWhiteSpace(OldPartyName))
            {
                dm.DeleteParty(OldPartyName);
            }

            dm.RefreshPartyList();
        }
    }
}
