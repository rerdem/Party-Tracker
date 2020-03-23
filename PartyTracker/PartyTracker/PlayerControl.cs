using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyTracker
{
    public partial class PlayerControl : UserControl
    {
        private PartyManager pm;
        private Player player;
        private bool InitialContentLoaded;

        public PlayerControl(PartyManager partyManager, Player inputPlayer)
        {
            InitializeComponent();

            pm = partyManager;
            player = inputPlayer;
            InitialContentLoaded = false;

            LoadInitialContent();

            pm.StartDeleteMode += new EventHandler(pm_StartDeleteMode);
            pm.StopDeleteMode += new EventHandler(pm_StopDeleteMode);
        }

        private void LoadInitialContent()
        {
            charNameBox.Text = player.CharacterName;
            raceBox.Text = player.Race;
            playerNameBox.Text = player.PlayerName;
            classBox.Text = player.CharacterClass;
            levelBox.Value = player.Level;
            backgroundBox.Text = player.Background;
            alignmentBox.Text = player.Alignment;
            acBox.Value = player.AC;
            passivePerceptionBox.Value = player.PassivePerception;
            maxHPBox.Value = player.MaxHP;
            noteBrowser.DocumentText = Markdig.Markdown.ToHtml(player.Notes);

            if (player.ShowAdditionalInfo)
            {
                classPanel.Visible = true;
            }
            else
            {
                classPanel.Visible = false;
            }

            if (pm.DeleteMode)
            {
                deleteButton.Visible = true;
            }
            else
            {
                deleteButton.Visible = false;
            }

            InitialContentLoaded = true;
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateShowAdditionalInfo(player.PlayerID, !player.ShowAdditionalInfo);
                classPanel.Visible = !classPanel.Visible;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.RemovePlayer(player.PlayerID);
                this.Dispose();
            }
        }

        private void charNameBox_TextChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateCharacterName(player.PlayerID, charNameBox.Text);
            }
        }

        private void raceBox_TextChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateRace(player.PlayerID, raceBox.Text);
            }
        }

        private void playerNameBox_TextChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdatePlayerName(player.PlayerID, playerNameBox.Text);
            }
        }

        private void classBox_TextChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateClass(player.PlayerID, classBox.Text);
            }
        }

        private void levelBox_ValueChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateLevel(player.PlayerID, (int)levelBox.Value);
            }
        }

        private void backgroundBox_TextChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateBackground(player.PlayerID, backgroundBox.Text);
            }
        }

        private void alignmentBox_TextChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateAlignment(player.PlayerID, alignmentBox.Text);
            }
        }

        private void acBox_ValueChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateArmorClass(player.PlayerID, (int)acBox.Value);
            }
        }

        private void passivePerceptionBox_ValueChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdatePassivePercetion(player.PlayerID, (int)passivePerceptionBox.Value);
            }
        }

        private void maxHPBox_ValueChanged(object sender, EventArgs e)
        {
            if (InitialContentLoaded)
            {
                pm.UpdateMaxHP(player.PlayerID, (int)maxHPBox.Value);
            }
        }

        private void noteEditButton_Click(object sender, EventArgs e)
        {
            NoteEditor editor = new NoteEditor();
            string editingResult = editor.ShowDialog($"{player.CharacterName} Player Notes", player.Notes);
            if (!string.IsNullOrEmpty(editingResult))
            {
                pm.UpdateNotes(player.PlayerID, editingResult);
                noteBrowser.DocumentText = Markdig.Markdown.ToHtml(player.Notes);
            }
        }

        private void pm_StartDeleteMode(object sender, EventArgs e)
        {
            deleteButton.Visible = true;
        }

        private void pm_StopDeleteMode(object sender, EventArgs e)
        {
            deleteButton.Visible = false;
        }
    }
}
