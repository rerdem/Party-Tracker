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
        public string Class { get; set; }
        public int Level { get; set; }
        public string Background { get; set; }
        public string Alignment { get; set; }
        public int AC { get; set; }
        public int PassivePerception { get; set; }
        public int MaxHP { get; set; }
        public string Notes { get; set; }

        public Player(int inputID)
        {
            PlayerID = inputID;
            CharacterName = "";
            PlayerName = "";
            Race = "";
            ShowAdditionalInfo = true;
            Class = "";
            Level = 1;
            Background = "";
            Alignment = "";
            AC = 0;
            PassivePerception = 0;
            MaxHP = 0;
            Notes = "";
        }

        [JsonConstructor]
        public Player(int inputID, string inputCharacterName, string inputPlayerName, string inputRace, bool inputShowAdditionalInfo, string inputClass, int inputLevel, string inputBackground, string inputAlignment, int inputAC, int inputPassivePerception, int inputMaxHP, string inputNotes)
        {
            PlayerID = inputID;
            CharacterName = inputCharacterName;
            PlayerName = inputPlayerName;
            Race = inputRace;
            ShowAdditionalInfo = inputShowAdditionalInfo;
            Class = inputClass;
            Level = inputLevel;
            Background = inputBackground;
            Alignment = inputAlignment;
            AC = inputAC;
            PassivePerception = inputPassivePerception;
            MaxHP = inputMaxHP;
            Notes = inputNotes;
        }
    }
}
