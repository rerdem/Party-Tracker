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

        public PlayerControl(PartyManager partyManager, Player inputPlayer)
        {
            InitializeComponent();

            pm = partyManager;
            player = inputPlayer;

            charNameBox.Text = player.CharacterName;
            raceBox.Text = player.Race;
            playerNameBox.Text = player.PlayerName;
            classBox.Text = player.Class;
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
        }

        public void ShowDeleteButton()
        {
            deleteButton.Visible = true;
        }

        public void HideDeleteButton()
        {
            deleteButton.Visible = false;
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            pm.UpdateShowAdditionalInfo(player.PlayerID, !player.ShowAdditionalInfo);
            classPanel.Visible = !classPanel.Visible;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            pm.RemovePlayer(player.PlayerID);
            this.Dispose();
        }

        private void charNameBox_TextChanged(object sender, EventArgs e)
        {
            pm.UpdateCharacterName(player.PlayerID, charNameBox.Text);
        }

        private void raceBox_TextChanged(object sender, EventArgs e)
        {
            pm.UpdateRace(player.PlayerID, raceBox.Text);
        }

        private void playerNameBox_TextChanged(object sender, EventArgs e)
        {
            pm.UpdatePlayerName(player.PlayerID, playerNameBox.Text);
        }

        private void classBox_TextChanged(object sender, EventArgs e)
        {
            pm.UpdateClass(player.PlayerID, classBox.Text);
        }

        private void levelBox_ValueChanged(object sender, EventArgs e)
        {
            pm.UpdateLevel(player.PlayerID, (int)levelBox.Value);
        }

        private void backgroundBox_TextChanged(object sender, EventArgs e)
        {
            pm.UpdateBackground(player.PlayerID, backgroundBox.Text);
        }

        private void alignmentBox_TextChanged(object sender, EventArgs e)
        {
            pm.UpdateAlignment(player.PlayerID, alignmentBox.Text);
        }

        private void acBox_ValueChanged(object sender, EventArgs e)
        {
            pm.UpdateArmorClass(player.PlayerID, (int)acBox.Value);
        }

        private void passivePerceptionBox_ValueChanged(object sender, EventArgs e)
        {
            pm.UpdatePassivePercetion(player.PlayerID, (int)passivePerceptionBox.Value);
        }

        private void maxHPBox_ValueChanged(object sender, EventArgs e)
        {
            pm.UpdateMaxHP(player.PlayerID, (int)maxHPBox.Value);
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
    }
}
