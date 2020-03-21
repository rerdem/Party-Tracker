using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyTracker
{
    public partial class MainWindow : Form
    {
        private PartyManager pm;
        
        public MainWindow(PartyManager partyManager)
        {
            InitializeComponent();
            
            pm = partyManager;
            pm.PlayerRemoved += new EventHandler(pm_PlayerRemoved);
            pm.LastPlayerRemoved += new EventHandler(pm_LastPlayerRemoved);
            pm.PartyNotesChanged += new EventHandler(pm_PartyNotesChanged);
            pm.PartyNameChanged += new EventHandler(pm_PartyNameChanged);

            autosaveChangesToolStripMenuItem.Checked = Properties.Settings.Default.AutoSave;
        }

        private void refreshPanel()
        {
            foreach (PlayerControl p in playerFlowPanel.Controls)
            {
                p.Dispose();
            }

            playerFlowPanel.Controls.Clear();

            foreach (Player player in pm.Players)
            {
                playerFlowPanel.Controls.Add(new PlayerControl(pm, player));
            }
        }

        private void refreshPartyNotes()
        {
            partyNoteBox.DocumentText = Markdig.Markdown.ToHtml(pm.PartyNotes);
        }

        private void autosaveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autosaveChangesToolStripMenuItem.Checked = !autosaveChangesToolStripMenuItem.Checked;
            Properties.Settings.Default.AutoSave = autosaveChangesToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.AddPlayer();
            refreshPanel();
        }

        private void startStopDeleteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pm.DeleteMode)
            {
                pm.StartDeleteMode();
                foreach (PlayerControl p in playerFlowPanel.Controls)
                {
                    p.ShowDeleteButton();
                }
            }
            else
            {
                pm.StopDeleteMode();
                foreach (PlayerControl p in playerFlowPanel.Controls)
                {
                    p.HideDeleteButton();
                }
            }
        }

        private void pm_PlayerRemoved(object sender, EventArgs e)
        {
            //refreshPanel();
        }

        private void pm_LastPlayerRemoved(object sender, EventArgs e)
        {
            pm.StopDeleteMode();
        }

        private void pm_PartyNotesChanged(object sender, EventArgs e)
        {
            refreshPartyNotes();
        }

        private void pm_PartyNameChanged(object sender, EventArgs e)
        {
            partyNameLabel.Text = pm.PartyName;
        }

        private void editPartyNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteEditor editor = new NoteEditor();
            string editingResult = editor.ShowDialog("Party Notes", pm.PartyNotes);
            if (!string.IsNullOrEmpty(editingResult))
            {
                pm.UpdatePartyNotes(editingResult);
            }
        }

        private void newPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void savePartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pm.PartyName))
            {
                SaveForm saveWindow = new SaveForm();
                string newPartyName = saveWindow.ShowDialog("Save Party As...", pm.PartyName);
                if (!string.IsNullOrEmpty(newPartyName))
                {
                    pm.UpdatePartyName(newPartyName);
                }
            }
        }

        private void loadPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renamePartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm renameWindow = new SaveForm();
            string newPartyName = renameWindow.ShowDialog("Rename Party...", pm.PartyName);
            if (!string.IsNullOrWhiteSpace(newPartyName))
            {
                pm.UpdatePartyName(newPartyName);
            }
        }
    }
}
