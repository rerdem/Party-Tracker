namespace PartyTracker
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopDeleteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPartyNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.partyNoteBox = new System.Windows.Forms.WebBrowser();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managePartyToolStripMenuItem,
            this.editPartyNotesToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(984, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autosaveChangesToolStripMenuItem,
            this.savePartyToolStripMenuItem,
            this.loadPartyToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // autosaveChangesToolStripMenuItem
            // 
            this.autosaveChangesToolStripMenuItem.Checked = true;
            this.autosaveChangesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosaveChangesToolStripMenuItem.Name = "autosaveChangesToolStripMenuItem";
            this.autosaveChangesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autosaveChangesToolStripMenuItem.Text = "Autosave Changes";
            this.autosaveChangesToolStripMenuItem.Click += new System.EventHandler(this.autosaveChangesToolStripMenuItem_Click);
            // 
            // savePartyToolStripMenuItem
            // 
            this.savePartyToolStripMenuItem.Name = "savePartyToolStripMenuItem";
            this.savePartyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savePartyToolStripMenuItem.Text = "Save Party";
            // 
            // loadPartyToolStripMenuItem
            // 
            this.loadPartyToolStripMenuItem.Name = "loadPartyToolStripMenuItem";
            this.loadPartyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadPartyToolStripMenuItem.Text = "Load Party";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // managePartyToolStripMenuItem
            // 
            this.managePartyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.startStopDeleteModeToolStripMenuItem});
            this.managePartyToolStripMenuItem.Name = "managePartyToolStripMenuItem";
            this.managePartyToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.managePartyToolStripMenuItem.Text = "Manage Party";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // startStopDeleteModeToolStripMenuItem
            // 
            this.startStopDeleteModeToolStripMenuItem.Name = "startStopDeleteModeToolStripMenuItem";
            this.startStopDeleteModeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.startStopDeleteModeToolStripMenuItem.Text = "Start/Stop Delete Mode";
            this.startStopDeleteModeToolStripMenuItem.Click += new System.EventHandler(this.startStopDeleteModeToolStripMenuItem_Click);
            // 
            // editPartyNotesToolStripMenuItem
            // 
            this.editPartyNotesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editPartyNotesToolStripMenuItem.Name = "editPartyNotesToolStripMenuItem";
            this.editPartyNotesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.editPartyNotesToolStripMenuItem.Text = "Edit Party Notes";
            // 
            // playerFlowPanel
            // 
            this.playerFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerFlowPanel.Location = new System.Drawing.Point(12, 28);
            this.playerFlowPanel.Name = "playerFlowPanel";
            this.playerFlowPanel.Size = new System.Drawing.Size(716, 521);
            this.playerFlowPanel.TabIndex = 1;
            // 
            // partyNoteBox
            // 
            this.partyNoteBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.partyNoteBox.Location = new System.Drawing.Point(734, 24);
            this.partyNoteBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.partyNoteBox.Name = "partyNoteBox";
            this.partyNoteBox.Size = new System.Drawing.Size(250, 537);
            this.partyNoteBox.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.partyNoteBox);
            this.Controls.Add(this.playerFlowPanel);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "Party Tracker";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopDeleteModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPartyNotesToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel playerFlowPanel;
        private System.Windows.Forms.WebBrowser partyNoteBox;
        private System.Windows.Forms.ToolStripMenuItem autosaveChangesToolStripMenuItem;
    }
}

