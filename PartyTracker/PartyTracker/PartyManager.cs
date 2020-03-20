using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTracker
{
    public class PartyManager
    {
        public string PartyNotes { get; set; }
        public bool Autosave { get; set; }
        public bool DeleteMode { get; private set; }
        public List<Player> Players { get; }

        public event EventHandler PlayerRemoved;
        public event EventHandler LastPlayerRemoved;

        private int IDCounter;

        public PartyManager()
        {
            PartyNotes = "";
            Autosave = true;
            DeleteMode = false;
            Players = new List<Player>();

            IDCounter = 0;
        }

        public void AddPlayer()
        {
            Players.Add(new Player(IDCounter));
            IDCounter++;
        }

        public void AddPlayer(string characterName, string playerName, string race, bool showAdditionalInfo, string characterClass, int level, string background, string alignment, int ac, int passivePerception, int maxHP, string notes)
        {
            Players.Add(new Player(IDCounter, characterName, playerName, race, showAdditionalInfo, characterClass, level, background, alignment, ac, passivePerception, maxHP, notes));
            IDCounter++;
        }

        public void RemovePlayer(int IDToRemove)
        {
            int indexToRemove = Players.FindIndex(p => p.PlayerID == IDToRemove);
            Players.RemoveAt(indexToRemove);

            OnPlayerRemoved(null);

            if (Players.Count==0)
            {
                OnLastPlayerRemoved(null);
            }
        }

        public void UpdateCharacterName(int playerID, string characterName)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).CharacterName = characterName;
        }

        public void UpdateRace(int playerID, string characterRace)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Race = characterRace;
        }
        public void UpdatePlayerName(int playerID, string playerName)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).PlayerName = playerName;
        }

        public void UpdateClass(int playerID, string characterClass)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Class = characterClass;
        }

        public void UpdateLevel(int playerID, int characterLevel)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Level = characterLevel;
        }

        public void UpdateBackground(int playerID, string characterBackground)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Background = characterBackground;
        }

        public void UpdateAlignment(int playerID, string characterAlignment)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Alignment = characterAlignment;
        }

        public void UpdateArmorClass(int playerID, int armorClass)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).AC = armorClass;
        }

        public void UpdatePassivePercetion(int playerID, int passivePerception)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).PassivePerception = passivePerception;
        }

        public void UpdateMaxHP(int playerID, int maxHP)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).MaxHP = maxHP;
        }

        public void UpdateNotes(int playerID, string characterNotes)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Notes = characterNotes;
        }

        public void UpdateShowAdditionalInfo(int playerID, bool showAdditionalInfo)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).ShowAdditionalInfo = showAdditionalInfo;
        }

        public void StartDeleteMode()
        {
            if (Players.Count>0)
            {
                DeleteMode = true;
            }
        }

        public void StopDeleteMode()
        {
            DeleteMode = false;
        }

        protected virtual void OnPlayerRemoved(EventArgs e)
        {
            EventHandler handler = PlayerRemoved;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnLastPlayerRemoved(EventArgs e)
        {
            EventHandler handler = LastPlayerRemoved;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
