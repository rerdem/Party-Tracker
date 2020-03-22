using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyTracker
{
    public class Player
    {
        public int PlayerID { get; }
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public string Race { get; set; }
        public bool ShowAdditionalInfo { get; set; }
        public string CharacterClass { get; set; }
        public int Level { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public int AC { get; set; }
        public int PassivePerception { get; set; }
        public int MaxHP { get; set; }
        public string Notes { get; set; }

        public Player(int playerID)
        {
            PlayerID = playerID;
            CharacterName = "";
            PlayerName = "";
            Race = "";
            ShowAdditionalInfo = true;
            CharacterClass = "";
            Level = 1;
            Background = "";
            Alignment = "";
            AC = 0;
            PassivePerception = 0;
            MaxHP = 0;
            Notes = "";
        }

        [JsonConstructor]
        public Player(int playerID, string characterName, string playerName, string race, bool showAdditionalInfo, string characterClass, int level, string background, string alignment, int ac, int passivePerception, int maxHP, string notes)
        {
            PlayerID = playerID;
            CharacterName = characterName;
            PlayerName = playerName;
            Race = race;
            ShowAdditionalInfo = showAdditionalInfo;
            CharacterClass = characterClass;
            Level = level;
            Background = background;
            Alignment = alignment;
            AC = ac;
            PassivePerception = passivePerception;
            MaxHP = maxHP;
            Notes = notes;
        }
    }
}
