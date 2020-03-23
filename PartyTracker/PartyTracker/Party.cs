using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTracker
{
    public class Party
    {
        public string PartyName { get; private set; }
        public string PartyNotes { get; private set; }
        public List<Player> Players { get; }

        public event EventHandler PlayerRemoved;
        public event EventHandler LastPlayerRemoved;

        public event EventHandler PartyNotesChanged;
        public event EventHandler PartyNameChanged;

        public event EventHandler PartyChanged;
        
        public Party()
        {
            PartyName = $"Party_{DateTime.Now.ToString("yyyy-MM-dd_HHmmss")}";
            PartyNotes = "";
            Players = new List<Player>();
        }

        [JsonConstructor]
        public Party(string partyName, string partyNotes, List<Player> players)
        {
            PartyName = partyName;
            PartyNotes = partyNotes;
            Players = players;
        }

        public void AddPlayer(int playerID)
        {
            Players.Add(new Player(playerID));

            OnPartyChanged(null);
        }

        public void AddPlayer(int playerID, string characterName, string playerName, string race, bool showAdditionalInfo, string characterClass, int level, string background, string alignment, int ac, int passivePerception, int maxHP, string notes)
        {
            Players.Add(new Player(playerID, characterName, playerName, race, showAdditionalInfo, characterClass, level, background, alignment, ac, passivePerception, maxHP, notes));

            OnPartyChanged(null);
        }

        public void RemovePlayer(int IDToRemove)
        {
            int indexToRemove = Players.FindIndex(p => p.PlayerID == IDToRemove);
            Players.RemoveAt(indexToRemove);

            OnPlayerRemoved(null);

            if (Players.Count == 0)
            {
                OnLastPlayerRemoved(null);
            }

            OnPartyChanged(null);
        }

        public void UpdateCharacterName(int playerID, string characterName)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).CharacterName = characterName;

            OnPartyChanged(null);
        }

        public void UpdateRace(int playerID, string characterRace)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Race = characterRace;

            OnPartyChanged(null);
        }
        public void UpdatePlayerName(int playerID, string playerName)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).PlayerName = playerName;

            OnPartyChanged(null);
        }

        public void UpdateClass(int playerID, string characterClass)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).CharacterClass = characterClass;

            OnPartyChanged(null);
        }

        public void UpdateLevel(int playerID, int characterLevel)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Level = characterLevel;

            OnPartyChanged(null);
        }

        public void UpdateBackground(int playerID, string characterBackground)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Background = characterBackground;

            OnPartyChanged(null);
        }

        public void UpdateAlignment(int playerID, string characterAlignment)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Alignment = characterAlignment;

            OnPartyChanged(null);
        }

        public void UpdateArmorClass(int playerID, int armorClass)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).AC = armorClass;

            OnPartyChanged(null);
        }

        public void UpdatePassivePercetion(int playerID, int passivePerception)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).PassivePerception = passivePerception;

            OnPartyChanged(null);
        }

        public void UpdateMaxHP(int playerID, int maxHP)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).MaxHP = maxHP;

            OnPartyChanged(null);
        }

        public void UpdateNotes(int playerID, string characterNotes)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).Notes = characterNotes;

            OnPartyChanged(null);
        }

        public void UpdateShowAdditionalInfo(int playerID, bool showAdditionalInfo)
        {
            int indexToUpdate = Players.FindIndex(p => p.PlayerID == playerID);
            Players.ElementAt(indexToUpdate).ShowAdditionalInfo = showAdditionalInfo;

            OnPartyChanged(null);
        }

        public void UpdatePartyNotes(string newPartyNotes)
        {
            PartyNotes = newPartyNotes;

            OnPartyNotesChanged(null);
            OnPartyChanged(null);
        }

        public void UpdatePartyName(string newPartyName)
        {
            PartyName = newPartyName;
            Properties.Settings.Default.LastOpenedParty = newPartyName;
            Properties.Settings.Default.Save();

            OnPartyNameChanged(null);
            OnPartyChanged(null);
        }

        public void ResetPartyNameToDefault()
        {
            UpdatePartyName($"Party_{DateTime.Now.ToString("yyyy-MM-dd_HHmmss")}");
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

        protected virtual void OnPartyNotesChanged(EventArgs e)
        {
            EventHandler handler = PartyNotesChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnPartyNameChanged(EventArgs e)
        {
            EventHandler handler = PartyNameChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnPartyChanged(EventArgs e)
        {
            EventHandler handler = PartyChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
