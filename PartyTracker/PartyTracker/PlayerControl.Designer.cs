namespace PartyTracker
{
    partial class PlayerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.namePanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.expandButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.raceBox = new System.Windows.Forms.TextBox();
            this.charNameLabel = new System.Windows.Forms.Label();
            this.charNameBox = new System.Windows.Forms.TextBox();
            this.classPanel = new System.Windows.Forms.Panel();
            this.alignmentLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.alignmentBox = new System.Windows.Forms.TextBox();
            this.backgroundBox = new System.Windows.Forms.TextBox();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.classBox = new System.Windows.Forms.TextBox();
            this.statPanel = new System.Windows.Forms.Panel();
            this.maxHPLabel = new System.Windows.Forms.Label();
            this.passivePerceptionLabel = new System.Windows.Forms.Label();
            this.acLabel = new System.Windows.Forms.Label();
            this.maxHPBox = new System.Windows.Forms.NumericUpDown();
            this.passivePerceptionBox = new System.Windows.Forms.NumericUpDown();
            this.acBox = new System.Windows.Forms.NumericUpDown();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.noteBrowser = new System.Windows.Forms.WebBrowser();
            this.noteEditButton = new System.Windows.Forms.Button();
            this.playerFlowPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.classPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            this.statPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passivePerceptionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acBox)).BeginInit();
            this.notesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerFlowPanel
            // 
            this.playerFlowPanel.AutoSize = true;
            this.playerFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerFlowPanel.Controls.Add(this.namePanel);
            this.playerFlowPanel.Controls.Add(this.classPanel);
            this.playerFlowPanel.Controls.Add(this.statPanel);
            this.playerFlowPanel.Controls.Add(this.notesPanel);
            this.playerFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.playerFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.playerFlowPanel.Name = "playerFlowPanel";
            this.playerFlowPanel.Size = new System.Drawing.Size(320, 524);
            this.playerFlowPanel.TabIndex = 0;
            // 
            // namePanel
            // 
            this.namePanel.AutoSize = true;
            this.namePanel.Controls.Add(this.deleteButton);
            this.namePanel.Controls.Add(this.expandButton);
            this.namePanel.Controls.Add(this.playerNameLabel);
            this.namePanel.Controls.Add(this.raceLabel);
            this.namePanel.Controls.Add(this.playerNameBox);
            this.namePanel.Controls.Add(this.raceBox);
            this.namePanel.Controls.Add(this.charNameLabel);
            this.namePanel.Controls.Add(this.charNameBox);
            this.namePanel.Location = new System.Drawing.Point(3, 3);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(312, 122);
            this.namePanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(259, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // expandButton
            // 
            this.expandButton.Location = new System.Drawing.Point(3, 99);
            this.expandButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(305, 20);
            this.expandButton.TabIndex = 6;
            this.expandButton.Text = "...";
            this.expandButton.UseVisualStyleBackColor = true;
            this.expandButton.Click += new System.EventHandler(this.expandButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(159, 80);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(67, 13);
            this.playerNameLabel.TabIndex = 5;
            this.playerNameLabel.Text = "Player Name";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(3, 80);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(82, 13);
            this.raceLabel.TabIndex = 4;
            this.raceLabel.Text = "Character Race";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameBox.Location = new System.Drawing.Point(159, 54);
            this.playerNameBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(150, 20);
            this.playerNameBox.TabIndex = 3;
            this.playerNameBox.ModifiedChanged += new System.EventHandler(this.playerNameBox_ModifiedChanged);
            // 
            // raceBox
            // 
            this.raceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBox.Location = new System.Drawing.Point(3, 54);
            this.raceBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(150, 20);
            this.raceBox.TabIndex = 2;
            this.raceBox.ModifiedChanged += new System.EventHandler(this.raceBox_ModifiedChanged);
            // 
            // charNameLabel
            // 
            this.charNameLabel.AutoSize = true;
            this.charNameLabel.Location = new System.Drawing.Point(3, 35);
            this.charNameLabel.Name = "charNameLabel";
            this.charNameLabel.Size = new System.Drawing.Size(84, 13);
            this.charNameLabel.TabIndex = 1;
            this.charNameLabel.Text = "Character Name";
            this.charNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // charNameBox
            // 
            this.charNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charNameBox.Location = new System.Drawing.Point(3, 3);
            this.charNameBox.Name = "charNameBox";
            this.charNameBox.Size = new System.Drawing.Size(306, 29);
            this.charNameBox.TabIndex = 0;
            this.charNameBox.ModifiedChanged += new System.EventHandler(this.charNameBox_ModifiedChanged);
            // 
            // classPanel
            // 
            this.classPanel.AutoSize = true;
            this.classPanel.Controls.Add(this.alignmentLabel);
            this.classPanel.Controls.Add(this.backgroundLabel);
            this.classPanel.Controls.Add(this.levelLabel);
            this.classPanel.Controls.Add(this.classLabel);
            this.classPanel.Controls.Add(this.alignmentBox);
            this.classPanel.Controls.Add(this.backgroundBox);
            this.classPanel.Controls.Add(this.levelBox);
            this.classPanel.Controls.Add(this.classBox);
            this.classPanel.Location = new System.Drawing.Point(3, 131);
            this.classPanel.Name = "classPanel";
            this.classPanel.Size = new System.Drawing.Size(312, 89);
            this.classPanel.TabIndex = 1;
            // 
            // alignmentLabel
            // 
            this.alignmentLabel.AutoSize = true;
            this.alignmentLabel.Location = new System.Drawing.Point(162, 76);
            this.alignmentLabel.Name = "alignmentLabel";
            this.alignmentLabel.Size = new System.Drawing.Size(53, 13);
            this.alignmentLabel.TabIndex = 7;
            this.alignmentLabel.Text = "Alignment";
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.AutoSize = true;
            this.backgroundLabel.Location = new System.Drawing.Point(3, 76);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(65, 13);
            this.backgroundLabel.TabIndex = 6;
            this.backgroundLabel.Text = "Background";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(159, 29);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "Level";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(3, 29);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(81, 13);
            this.classLabel.TabIndex = 4;
            this.classLabel.Text = "Character Class";
            // 
            // alignmentBox
            // 
            this.alignmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignmentBox.Location = new System.Drawing.Point(159, 48);
            this.alignmentBox.Name = "alignmentBox";
            this.alignmentBox.Size = new System.Drawing.Size(150, 23);
            this.alignmentBox.TabIndex = 3;
            this.alignmentBox.ModifiedChanged += new System.EventHandler(this.alignmentBox_ModifiedChanged);
            // 
            // backgroundBox
            // 
            this.backgroundBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundBox.Location = new System.Drawing.Point(3, 48);
            this.backgroundBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(150, 23);
            this.backgroundBox.TabIndex = 2;
            this.backgroundBox.ModifiedChanged += new System.EventHandler(this.backgroundBox_ModifiedChanged);
            // 
            // levelBox
            // 
            this.levelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.Location = new System.Drawing.Point(159, 3);
            this.levelBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.levelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(52, 23);
            this.levelBox.TabIndex = 1;
            this.levelBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelBox.ValueChanged += new System.EventHandler(this.levelBox_ValueChanged);
            // 
            // classBox
            // 
            this.classBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classBox.Location = new System.Drawing.Point(3, 3);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(150, 23);
            this.classBox.TabIndex = 0;
            this.classBox.ModifiedChanged += new System.EventHandler(this.classBox_ModifiedChanged);
            // 
            // statPanel
            // 
            this.statPanel.AutoSize = true;
            this.statPanel.Controls.Add(this.maxHPLabel);
            this.statPanel.Controls.Add(this.passivePerceptionLabel);
            this.statPanel.Controls.Add(this.acLabel);
            this.statPanel.Controls.Add(this.maxHPBox);
            this.statPanel.Controls.Add(this.passivePerceptionBox);
            this.statPanel.Controls.Add(this.acBox);
            this.statPanel.Location = new System.Drawing.Point(3, 226);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(306, 48);
            this.statPanel.TabIndex = 2;
            // 
            // maxHPLabel
            // 
            this.maxHPLabel.AutoSize = true;
            this.maxHPLabel.Location = new System.Drawing.Point(243, 35);
            this.maxHPLabel.Name = "maxHPLabel";
            this.maxHPLabel.Size = new System.Drawing.Size(45, 13);
            this.maxHPLabel.TabIndex = 5;
            this.maxHPLabel.Text = "Max HP";
            // 
            // passivePerceptionLabel
            // 
            this.passivePerceptionLabel.AutoSize = true;
            this.passivePerceptionLabel.Location = new System.Drawing.Point(123, 35);
            this.passivePerceptionLabel.Name = "passivePerceptionLabel";
            this.passivePerceptionLabel.Size = new System.Drawing.Size(98, 13);
            this.passivePerceptionLabel.TabIndex = 4;
            this.passivePerceptionLabel.Text = "Passive Perception";
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(3, 35);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(21, 13);
            this.acLabel.TabIndex = 3;
            this.acLabel.Text = "AC";
            // 
            // maxHPBox
            // 
            this.maxHPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHPBox.Location = new System.Drawing.Point(243, 4);
            this.maxHPBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.maxHPBox.Name = "maxHPBox";
            this.maxHPBox.Size = new System.Drawing.Size(60, 29);
            this.maxHPBox.TabIndex = 2;
            this.maxHPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxHPBox.ValueChanged += new System.EventHandler(this.maxHPBox_ValueChanged);
            // 
            // passivePerceptionBox
            // 
            this.passivePerceptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passivePerceptionBox.Location = new System.Drawing.Point(123, 4);
            this.passivePerceptionBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.passivePerceptionBox.Name = "passivePerceptionBox";
            this.passivePerceptionBox.Size = new System.Drawing.Size(60, 29);
            this.passivePerceptionBox.TabIndex = 1;
            this.passivePerceptionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passivePerceptionBox.ValueChanged += new System.EventHandler(this.passivePerceptionBox_ValueChanged);
            // 
            // acBox
            // 
            this.acBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acBox.Location = new System.Drawing.Point(3, 4);
            this.acBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.acBox.Name = "acBox";
            this.acBox.Size = new System.Drawing.Size(60, 29);
            this.acBox.TabIndex = 0;
            this.acBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.acBox.ValueChanged += new System.EventHandler(this.acBox_ValueChanged);
            // 
            // notesPanel
            // 
            this.notesPanel.AutoSize = true;
            this.notesPanel.Controls.Add(this.noteBrowser);
            this.notesPanel.Controls.Add(this.noteEditButton);
            this.notesPanel.Location = new System.Drawing.Point(3, 280);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(312, 239);
            this.notesPanel.TabIndex = 3;
            // 
            // noteBrowser
            // 
            this.noteBrowser.Location = new System.Drawing.Point(3, 3);
            this.noteBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.noteBrowser.Name = "noteBrowser";
            this.noteBrowser.Size = new System.Drawing.Size(250, 233);
            this.noteBrowser.TabIndex = 1;
            // 
            // noteEditButton
            // 
            this.noteEditButton.Location = new System.Drawing.Point(259, 3);
            this.noteEditButton.Name = "noteEditButton";
            this.noteEditButton.Size = new System.Drawing.Size(50, 23);
            this.noteEditButton.TabIndex = 0;
            this.noteEditButton.Text = "Edit";
            this.noteEditButton.UseVisualStyleBackColor = true;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.playerFlowPanel);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(326, 530);
            this.playerFlowPanel.ResumeLayout(false);
            this.playerFlowPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.classPanel.ResumeLayout(false);
            this.classPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passivePerceptionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acBox)).EndInit();
            this.notesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel playerFlowPanel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Panel classPanel;
        private System.Windows.Forms.Panel statPanel;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.TextBox raceBox;
        private System.Windows.Forms.Label charNameLabel;
        private System.Windows.Forms.TextBox charNameBox;
        private System.Windows.Forms.Button expandButton;
        private System.Windows.Forms.Label alignmentLabel;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox alignmentBox;
        private System.Windows.Forms.TextBox backgroundBox;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.Label maxHPLabel;
        private System.Windows.Forms.Label passivePerceptionLabel;
        private System.Windows.Forms.Label acLabel;
        private System.Windows.Forms.NumericUpDown maxHPBox;
        private System.Windows.Forms.NumericUpDown passivePerceptionBox;
        private System.Windows.Forms.NumericUpDown acBox;
        private System.Windows.Forms.WebBrowser noteBrowser;
        private System.Windows.Forms.Button noteEditButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
