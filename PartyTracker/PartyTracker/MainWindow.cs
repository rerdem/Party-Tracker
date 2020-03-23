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
            pm.PartyLoadComplete += new EventHandler(pm_PartyLoadComplete);
            pm.PartyCreationComplete += new EventHandler(pm_PartyCreationComplete);
            SubscribeToPartyEvents();

            autosaveChangesToolStripMenuItem.Checked = Properties.Settings.Default.AutoSave;
            loadLastPartyOnStartupToolStripMenuItem.Checked = Properties.Settings.Default.LoadLast;

            RefreshAllComponents();
        }

        private void RefreshAllComponents()
        {
            RefreshPanel();
            RefreshPartyNotes();
            RefreshPartyName();
        }

        private void RefreshPanel()
        {
            foreach (PlayerControl p in playerFlowPanel.Controls)
            {
                p.Dispose();
            }

            playerFlowPanel.Controls.Clear();

            foreach (Player player in pm.CurrentParty.Players)
            {
                playerFlowPanel.Controls.Add(new PlayerControl(pm, player));
            }
        }

        private void RefreshPartyNotes()
        {
            partyNoteBox.DocumentText = Markdig.Markdown.ToHtml(pm.CurrentParty.PartyNotes);
        }

        private void RefreshPartyName()
        {
            partyNameLabel.Text = pm.CurrentParty.PartyName;
        }

        private void SubscribeToPartyEvents()
        {
            pm.CurrentParty.PlayerRemoved += new EventHandler(pm_PlayerRemoved);
            pm.CurrentParty.LastPlayerRemoved += new EventHandler(pm_LastPlayerRemoved);
            pm.CurrentParty.PartyNotesChanged += new EventHandler(pm_PartyNotesChanged);
            pm.CurrentParty.PartyNameChanged += new EventHandler(pm_PartyNameChanged);
        }

        private void autosaveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autosaveChangesToolStripMenuItem.Checked = !autosaveChangesToolStripMenuItem.Checked;
            Properties.Settings.Default.AutoSave = autosaveChangesToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void loadLastPartyOnStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadLastPartyOnStartupToolStripMenuItem.Checked = !loadLastPartyOnStartupToolStripMenuItem.Checked;
            Properties.Settings.Default.LoadLast = loadLastPartyOnStartupToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.AddPlayer();
            RefreshPanel();
        }

        private void startStopDeleteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pm.DeleteMode)
            {
                pm.ActivateDeleteMode();
            }
            else
            {
                pm.DeactivateDeleteMode();
            }
        }

        private void pm_PartyLoadComplete(object sender, EventArgs e)
        {
            SubscribeToPartyEvents();
            RefreshAllComponents();
        }

        private void pm_PartyCreationComplete(object sender, EventArgs e)
        {
            SubscribeToPartyEvents();
            RefreshAllComponents();
        }

        private void pm_PlayerRemoved(object sender, EventArgs e)
        {
            //refreshPanel();
        }

        private void pm_LastPlayerRemoved(object sender, EventArgs e)
        {
            pm.DeactivateDeleteMode();
        }

        private void pm_PartyNotesChanged(object sender, EventArgs e)
        {
            RefreshPartyNotes();
        }

        private void pm_PartyNameChanged(object sender, EventArgs e)
        {
            RefreshPartyName();
        }

        private void editPartyNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteEditor editor = new NoteEditor();
            string editingResult = editor.ShowDialog("Party Notes", pm.CurrentParty.PartyNotes);
            if (!string.IsNullOrEmpty(editingResult))
            {
                pm.UpdatePartyNotes(editingResult);
            }
        }

        private void createNewPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.CreateNewParty();
            RefreshAllComponents();
        }

        private void savePartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pm.CurrentParty.PartyName))
            {
                SaveForm saveWindow = new SaveForm(pm);
                string newPartyName = saveWindow.ShowDialog("Save Party As...", pm.CurrentParty.PartyName);
                if (!string.IsNullOrEmpty(newPartyName))
                {
                    pm.UpdatePartyName(newPartyName);
                }
            }

            pm.SaveParty();
        }

        private void loadPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm loadWindow = new LoadForm();
            string partyToLoad = loadWindow.ShowDialog(pm.GetPartyList());
            if (!string.IsNullOrEmpty(partyToLoad))
            {
                pm.LoadParty(partyToLoad);
            }
        }

        private void renamePartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm renameWindow = new SaveForm(pm);
            string newPartyName = renameWindow.ShowDialog("Rename Party...", pm.CurrentParty.PartyName);
            if (!string.IsNullOrWhiteSpace(newPartyName))
            {
                pm.UpdatePartyName(newPartyName);
            }
        }

        private void deleteCurrentPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pm.DeleteCurrentParty();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!pm.ChangesSaved)
            {
                DialogResult confirmResult = MessageBox.Show("You have unsaved changes. Are you sure, you wish to quit and lose any changes since the last save?",
                                     "Unsaved changes detected!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
