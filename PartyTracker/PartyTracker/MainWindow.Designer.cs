﻿namespace PartyTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLastPartyOnStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopDeleteModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renamePartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPartyNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.partyNoteBox = new System.Windows.Forms.WebBrowser();
            this.partyNameLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.managePartyToolStripMenuItem,
            this.editPartyNotesToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1184, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewPartyToolStripMenuItem,
            this.savePartyToolStripMenuItem,
            this.loadPartyToolStripMenuItem,
            this.deleteCurrentPartyToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewPartyToolStripMenuItem
            // 
            this.createNewPartyToolStripMenuItem.Name = "createNewPartyToolStripMenuItem";
            this.createNewPartyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewPartyToolStripMenuItem.Text = "Create New Party";
            this.createNewPartyToolStripMenuItem.Click += new System.EventHandler(this.createNewPartyToolStripMenuItem_Click);
            // 
            // savePartyToolStripMenuItem
            // 
            this.savePartyToolStripMenuItem.Name = "savePartyToolStripMenuItem";
            this.savePartyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savePartyToolStripMenuItem.Text = "Save Current Party";
            this.savePartyToolStripMenuItem.Click += new System.EventHandler(this.savePartyToolStripMenuItem_Click);
            // 
            // loadPartyToolStripMenuItem
            // 
            this.loadPartyToolStripMenuItem.Name = "loadPartyToolStripMenuItem";
            this.loadPartyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadPartyToolStripMenuItem.Text = "Load Party...";
            this.loadPartyToolStripMenuItem.Click += new System.EventHandler(this.loadPartyToolStripMenuItem_Click);
            // 
            // deleteCurrentPartyToolStripMenuItem
            // 
            this.deleteCurrentPartyToolStripMenuItem.Name = "deleteCurrentPartyToolStripMenuItem";
            this.deleteCurrentPartyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteCurrentPartyToolStripMenuItem.Text = "Delete Current Party";
            this.deleteCurrentPartyToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentPartyToolStripMenuItem_Click);
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
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autosaveChangesToolStripMenuItem,
            this.loadLastPartyOnStartupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // autosaveChangesToolStripMenuItem
            // 
            this.autosaveChangesToolStripMenuItem.Checked = true;
            this.autosaveChangesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autosaveChangesToolStripMenuItem.Name = "autosaveChangesToolStripMenuItem";
            this.autosaveChangesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.autosaveChangesToolStripMenuItem.Text = "Autosave Changes";
            this.autosaveChangesToolStripMenuItem.Click += new System.EventHandler(this.autosaveChangesToolStripMenuItem_Click);
            // 
            // loadLastPartyOnStartupToolStripMenuItem
            // 
            this.loadLastPartyOnStartupToolStripMenuItem.Checked = true;
            this.loadLastPartyOnStartupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.loadLastPartyOnStartupToolStripMenuItem.Name = "loadLastPartyOnStartupToolStripMenuItem";
            this.loadLastPartyOnStartupToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.loadLastPartyOnStartupToolStripMenuItem.Text = "Load Last Party on Startup";
            this.loadLastPartyOnStartupToolStripMenuItem.Click += new System.EventHandler(this.loadLastPartyOnStartupToolStripMenuItem_Click);
            // 
            // managePartyToolStripMenuItem
            // 
            this.managePartyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.startStopDeleteModeToolStripMenuItem,
            this.renamePartyToolStripMenuItem});
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
            // renamePartyToolStripMenuItem
            // 
            this.renamePartyToolStripMenuItem.Name = "renamePartyToolStripMenuItem";
            this.renamePartyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.renamePartyToolStripMenuItem.Text = "Rename Party";
            this.renamePartyToolStripMenuItem.Click += new System.EventHandler(this.renamePartyToolStripMenuItem_Click);
            // 
            // editPartyNotesToolStripMenuItem
            // 
            this.editPartyNotesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.editPartyNotesToolStripMenuItem.Name = "editPartyNotesToolStripMenuItem";
            this.editPartyNotesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.editPartyNotesToolStripMenuItem.Text = "Edit Party Notes";
            this.editPartyNotesToolStripMenuItem.Click += new System.EventHandler(this.editPartyNotesToolStripMenuItem_Click);
            // 
            // playerFlowPanel
            // 
            this.playerFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerFlowPanel.Location = new System.Drawing.Point(12, 51);
            this.playerFlowPanel.Name = "playerFlowPanel";
            this.playerFlowPanel.Size = new System.Drawing.Size(916, 598);
            this.playerFlowPanel.TabIndex = 1;
            // 
            // partyNoteBox
            // 
            this.partyNoteBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.partyNoteBox.Location = new System.Drawing.Point(934, 24);
            this.partyNoteBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.partyNoteBox.Name = "partyNoteBox";
            this.partyNoteBox.Size = new System.Drawing.Size(250, 637);
            this.partyNoteBox.TabIndex = 2;
            // 
            // partyNameLabel
            // 
            this.partyNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.partyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyNameLabel.Location = new System.Drawing.Point(0, 24);
            this.partyNameLabel.Name = "partyNameLabel";
            this.partyNameLabel.Size = new System.Drawing.Size(934, 24);
            this.partyNameLabel.TabIndex = 3;
            this.partyNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.partyNameLabel);
            this.Controls.Add(this.partyNoteBox);
            this.Controls.Add(this.playerFlowPanel);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainWindow";
            this.Text = "Party Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
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
        private System.Windows.Forms.FlowLayoutPanel playerFlowPanel;
        private System.Windows.Forms.WebBrowser partyNoteBox;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosaveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPartyNotesToolStripMenuItem;
        private System.Windows.Forms.Label partyNameLabel;
        private System.Windows.Forms.ToolStripMenuItem renamePartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLastPartyOnStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentPartyToolStripMenuItem;
    }
}

