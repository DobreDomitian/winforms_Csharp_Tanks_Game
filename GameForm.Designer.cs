

namespace TanksGame
{
    partial class GameForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainExit = new System.Windows.Forms.Button();
            this.mainOptions = new System.Windows.Forms.Button();
            this.mainLANMultiplayer = new System.Windows.Forms.Button();
            this.mainLOCMultiplayer = new System.Windows.Forms.Button();
            this.locmpPanel = new System.Windows.Forms.Panel();
            this.locmpBack = new System.Windows.Forms.Button();
            this.locmpPlayerNumber4 = new System.Windows.Forms.Button();
            this.locmpPlayerNumber3 = new System.Windows.Forms.Button();
            this.locmpPlayerNumber2 = new System.Windows.Forms.Button();
            this.locmpLabel = new System.Windows.Forms.Label();
            this.lanmpPanel = new System.Windows.Forms.Panel();
            this.lanmpBack = new System.Windows.Forms.Button();
            this.lanmpJoin = new System.Windows.Forms.Button();
            this.lanmpHost = new System.Windows.Forms.Button();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.optionsSave = new System.Windows.Forms.Button();
            this.kybBindingsSetting = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Key = new System.Windows.Forms.DataGridViewButtonColumn();
            this.optionsEdit = new System.Windows.Forms.Button();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.optionsBack = new System.Windows.Forms.Button();
            this.Host4Player = new System.Windows.Forms.Button();
            this.Host3Player = new System.Windows.Forms.Button();
            this.HostPanel = new System.Windows.Forms.Panel();
            this.Host2Player = new System.Windows.Forms.Button();
            this.HostBack = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.locmpPanel.SuspendLayout();
            this.lanmpPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kybBindingsSetting)).BeginInit();
            this.HostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.mainExit);
            this.mainPanel.Controls.Add(this.mainOptions);
            this.mainPanel.Controls.Add(this.mainLANMultiplayer);
            this.mainPanel.Controls.Add(this.mainLOCMultiplayer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(909, 521);
            this.mainPanel.TabIndex = 0;
            // 
            // mainExit
            // 
            this.mainExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExit.Location = new System.Drawing.Point(328, 396);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(243, 76);
            this.mainExit.TabIndex = 3;
            this.mainExit.Text = "Exit";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.main_exit_Click);
            // 
            // mainOptions
            // 
            this.mainOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainOptions.Location = new System.Drawing.Point(328, 234);
            this.mainOptions.Name = "mainOptions";
            this.mainOptions.Size = new System.Drawing.Size(243, 76);
            this.mainOptions.TabIndex = 2;
            this.mainOptions.Text = "Options";
            this.mainOptions.UseVisualStyleBackColor = true;
            this.mainOptions.Click += new System.EventHandler(this.mainOptions_Click);
            // 
            // mainLANMultiplayer
            // 
            this.mainLANMultiplayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLANMultiplayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLANMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLANMultiplayer.Location = new System.Drawing.Point(328, 125);
            this.mainLANMultiplayer.Name = "mainLANMultiplayer";
            this.mainLANMultiplayer.Size = new System.Drawing.Size(243, 76);
            this.mainLANMultiplayer.TabIndex = 1;
            this.mainLANMultiplayer.Text = "LAN Multiplayer";
            this.mainLANMultiplayer.UseVisualStyleBackColor = true;
            this.mainLANMultiplayer.Click += new System.EventHandler(this.mainLANMultiplayer_Click);
            // 
            // mainLOCMultiplayer
            // 
            this.mainLOCMultiplayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLOCMultiplayer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLOCMultiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLOCMultiplayer.Location = new System.Drawing.Point(328, 41);
            this.mainLOCMultiplayer.Name = "mainLOCMultiplayer";
            this.mainLOCMultiplayer.Size = new System.Drawing.Size(243, 76);
            this.mainLOCMultiplayer.TabIndex = 0;
            this.mainLOCMultiplayer.Text = "Local Multiplayer";
            this.mainLOCMultiplayer.UseVisualStyleBackColor = true;
            this.mainLOCMultiplayer.Click += new System.EventHandler(this.main_locmp_Click);
            // 
            // locmpPanel
            // 
            this.locmpPanel.AutoSize = true;
            this.locmpPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locmpPanel.Controls.Add(this.locmpBack);
            this.locmpPanel.Controls.Add(this.locmpPlayerNumber4);
            this.locmpPanel.Controls.Add(this.locmpPlayerNumber3);
            this.locmpPanel.Controls.Add(this.locmpPlayerNumber2);
            this.locmpPanel.Controls.Add(this.locmpLabel);
            this.locmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locmpPanel.Location = new System.Drawing.Point(0, 0);
            this.locmpPanel.Name = "locmpPanel";
            this.locmpPanel.Size = new System.Drawing.Size(909, 521);
            this.locmpPanel.TabIndex = 4;
            this.locmpPanel.Visible = false;
            // 
            // locmpBack
            // 
            this.locmpBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locmpBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locmpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locmpBack.Location = new System.Drawing.Point(380, 392);
            this.locmpBack.Name = "locmpBack";
            this.locmpBack.Size = new System.Drawing.Size(148, 46);
            this.locmpBack.TabIndex = 4;
            this.locmpBack.Text = "Back";
            this.locmpBack.UseVisualStyleBackColor = true;
            this.locmpBack.Click += new System.EventHandler(this.locmp_back_Click);
            // 
            // locmpPlayerNumber4
            // 
            this.locmpPlayerNumber4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locmpPlayerNumber4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locmpPlayerNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locmpPlayerNumber4.Location = new System.Drawing.Point(534, 140);
            this.locmpPlayerNumber4.Name = "locmpPlayerNumber4";
            this.locmpPlayerNumber4.Size = new System.Drawing.Size(148, 46);
            this.locmpPlayerNumber4.TabIndex = 3;
            this.locmpPlayerNumber4.Text = "4 Players";
            this.locmpPlayerNumber4.UseVisualStyleBackColor = true;
            this.locmpPlayerNumber4.Click += new System.EventHandler(this.locmpPlayerNumber4_Click);
            // 
            // locmpPlayerNumber3
            // 
            this.locmpPlayerNumber3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locmpPlayerNumber3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locmpPlayerNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locmpPlayerNumber3.Location = new System.Drawing.Point(380, 140);
            this.locmpPlayerNumber3.Name = "locmpPlayerNumber3";
            this.locmpPlayerNumber3.Size = new System.Drawing.Size(148, 46);
            this.locmpPlayerNumber3.TabIndex = 2;
            this.locmpPlayerNumber3.Text = "3 Players";
            this.locmpPlayerNumber3.UseVisualStyleBackColor = true;
            this.locmpPlayerNumber3.Click += new System.EventHandler(this.locmpPlayerNumber3_Click);
            // 
            // locmpPlayerNumber2
            // 
            this.locmpPlayerNumber2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locmpPlayerNumber2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locmpPlayerNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locmpPlayerNumber2.Location = new System.Drawing.Point(225, 140);
            this.locmpPlayerNumber2.Name = "locmpPlayerNumber2";
            this.locmpPlayerNumber2.Size = new System.Drawing.Size(148, 46);
            this.locmpPlayerNumber2.TabIndex = 1;
            this.locmpPlayerNumber2.Text = "2 Players";
            this.locmpPlayerNumber2.UseVisualStyleBackColor = true;
            this.locmpPlayerNumber2.Click += new System.EventHandler(this.locmpPlayerNumber2_Click);
            // 
            // locmpLabel
            // 
            this.locmpLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locmpLabel.AutoSize = true;
            this.locmpLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locmpLabel.Location = new System.Drawing.Point(218, 9);
            this.locmpLabel.Name = "locmpLabel";
            this.locmpLabel.Size = new System.Drawing.Size(417, 36);
            this.locmpLabel.TabIndex = 0;
            this.locmpLabel.Text = "Select the number of players";
            // 
            // lanmpPanel
            // 
            this.lanmpPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lanmpPanel.Controls.Add(this.lanmpBack);
            this.lanmpPanel.Controls.Add(this.lanmpJoin);
            this.lanmpPanel.Controls.Add(this.lanmpHost);
            this.lanmpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lanmpPanel.Location = new System.Drawing.Point(0, 0);
            this.lanmpPanel.Name = "lanmpPanel";
            this.lanmpPanel.Size = new System.Drawing.Size(909, 521);
            this.lanmpPanel.TabIndex = 0;
            this.lanmpPanel.Visible = false;
            // 
            // lanmpBack
            // 
            this.lanmpBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanmpBack.Location = new System.Drawing.Point(319, 379);
            this.lanmpBack.Name = "lanmpBack";
            this.lanmpBack.Size = new System.Drawing.Size(223, 44);
            this.lanmpBack.TabIndex = 2;
            this.lanmpBack.Text = "Back";
            this.lanmpBack.UseVisualStyleBackColor = true;
            this.lanmpBack.Click += new System.EventHandler(this.lanmpBack_Click);
            // 
            // lanmpJoin
            // 
            this.lanmpJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanmpJoin.Location = new System.Drawing.Point(319, 52);
            this.lanmpJoin.Name = "lanmpJoin";
            this.lanmpJoin.Size = new System.Drawing.Size(223, 66);
            this.lanmpJoin.TabIndex = 1;
            this.lanmpJoin.Text = "Join Server";
            this.lanmpJoin.UseVisualStyleBackColor = true;
            // 
            // lanmpHost
            // 
            this.lanmpHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanmpHost.Location = new System.Drawing.Point(319, 147);
            this.lanmpHost.Name = "lanmpHost";
            this.lanmpHost.Size = new System.Drawing.Size(223, 66);
            this.lanmpHost.TabIndex = 0;
            this.lanmpHost.Text = "Create Server";
            this.lanmpHost.UseVisualStyleBackColor = true;
            this.lanmpHost.Click += new System.EventHandler(this.lanmpHost_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.optionsSave);
            this.optionsPanel.Controls.Add(this.kybBindingsSetting);
            this.optionsPanel.Controls.Add(this.optionsEdit);
            this.optionsPanel.Controls.Add(this.optionsLabel);
            this.optionsPanel.Controls.Add(this.optionsBack);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(909, 521);
            this.optionsPanel.TabIndex = 4;
            this.optionsPanel.Visible = false;
            // 
            // optionsSave
            // 
            this.optionsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsSave.Location = new System.Drawing.Point(502, 468);
            this.optionsSave.Name = "optionsSave";
            this.optionsSave.Size = new System.Drawing.Size(132, 40);
            this.optionsSave.TabIndex = 6;
            this.optionsSave.Text = "Save";
            this.optionsSave.UseVisualStyleBackColor = true;
            this.optionsSave.Visible = false;
            // 
            // kybBindingsSetting
            // 
            this.kybBindingsSetting.AllowUserToAddRows = false;
            this.kybBindingsSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.kybBindingsSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kybBindingsSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Key});
            this.kybBindingsSetting.Location = new System.Drawing.Point(287, 113);
            this.kybBindingsSetting.Name = "kybBindingsSetting";
            this.kybBindingsSetting.Size = new System.Drawing.Size(348, 325);
            this.kybBindingsSetting.TabIndex = 5;
            this.kybBindingsSetting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContentClick);
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.FillWeight = 23.35025F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Key
            // 
            this.Key.FillWeight = 176.6497F;
            this.Key.HeaderText = "Assigned Key";
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Width = 77;
            // 
            // optionsEdit
            // 
            this.optionsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsEdit.Location = new System.Drawing.Point(502, 468);
            this.optionsEdit.Name = "optionsEdit";
            this.optionsEdit.Size = new System.Drawing.Size(132, 40);
            this.optionsEdit.TabIndex = 4;
            this.optionsEdit.Text = "Edit";
            this.optionsEdit.UseVisualStyleBackColor = true;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsLabel.Location = new System.Drawing.Point(396, 41);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(132, 37);
            this.optionsLabel.TabIndex = 2;
            this.optionsLabel.Text = "Settings";
            // 
            // optionsBack
            // 
            this.optionsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBack.Location = new System.Drawing.Point(287, 468);
            this.optionsBack.Name = "optionsBack";
            this.optionsBack.Size = new System.Drawing.Size(148, 41);
            this.optionsBack.TabIndex = 0;
            this.optionsBack.Text = "Back";
            this.optionsBack.UseVisualStyleBackColor = true;
            this.optionsBack.Click += new System.EventHandler(this.optionsBack_Click);
            // 
            // Host4Player
            // 
            this.Host4Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Host4Player.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Host4Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host4Player.Location = new System.Drawing.Point(603, 140);
            this.Host4Player.Name = "Host4Player";
            this.Host4Player.Size = new System.Drawing.Size(148, 46);
            this.Host4Player.TabIndex = 4;
            this.Host4Player.Text = "4 Players";
            this.Host4Player.UseVisualStyleBackColor = true;
            // 
            // Host3Player
            // 
            this.Host3Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Host3Player.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Host3Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host3Player.Location = new System.Drawing.Point(394, 140);
            this.Host3Player.Name = "Host3Player";
            this.Host3Player.Size = new System.Drawing.Size(148, 46);
            this.Host3Player.TabIndex = 5;
            this.Host3Player.Text = "3 Players";
            this.Host3Player.UseVisualStyleBackColor = true;
            // 
            // HostPanel
            // 
            this.HostPanel.Controls.Add(this.HostBack);
            this.HostPanel.Controls.Add(this.Host2Player);
            this.HostPanel.Controls.Add(this.Host3Player);
            this.HostPanel.Controls.Add(this.Host4Player);
            this.HostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostPanel.Location = new System.Drawing.Point(0, 0);
            this.HostPanel.Name = "HostPanel";
            this.HostPanel.Size = new System.Drawing.Size(909, 521);
            this.HostPanel.TabIndex = 3;
            this.HostPanel.Visible = false;
            // 
            // Host2Player
            // 
            this.Host2Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Host2Player.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Host2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host2Player.Location = new System.Drawing.Point(174, 140);
            this.Host2Player.Name = "Host2Player";
            this.Host2Player.Size = new System.Drawing.Size(148, 46);
            this.Host2Player.TabIndex = 6;
            this.Host2Player.Text = "2 Players";
            this.Host2Player.UseVisualStyleBackColor = true;
            // 
            // HostBack
            // 
            this.HostBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HostBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HostBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostBack.Location = new System.Drawing.Point(403, 396);
            this.HostBack.Name = "HostBack";
            this.HostBack.Size = new System.Drawing.Size(148, 46);
            this.HostBack.TabIndex = 7;
            this.HostBack.Text = "Back";
            this.HostBack.UseVisualStyleBackColor = true;
            this.HostBack.Click += new System.EventHandler(this.HostBack_Click);
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(909, 521);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.locmpPanel);
            this.Controls.Add(this.lanmpPanel);
            this.Controls.Add(this.HostPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(925, 560);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TanksGame";
            this.mainPanel.ResumeLayout(false);
            this.locmpPanel.ResumeLayout(false);
            this.locmpPanel.PerformLayout();
            this.lanmpPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kybBindingsSetting)).EndInit();
            this.HostPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainLANMultiplayer;
        private System.Windows.Forms.Button mainLOCMultiplayer;
        private System.Windows.Forms.Button mainOptions;
        protected System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Panel locmpPanel;
        private System.Windows.Forms.Label locmpLabel;
        private System.Windows.Forms.Button locmpBack;
        private System.Windows.Forms.Button locmpPlayerNumber4;
        private System.Windows.Forms.Button locmpPlayerNumber3;
        private System.Windows.Forms.Button locmpPlayerNumber2;
        private System.Windows.Forms.Panel lanmpPanel;
        private System.Windows.Forms.Button lanmpBack;
        private System.Windows.Forms.Button lanmpJoin;
        private System.Windows.Forms.Button lanmpHost;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button optionsBack;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Button optionsEdit;
        private System.Windows.Forms.DataGridView kybBindingsSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewButtonColumn Key;
        private System.Windows.Forms.Button optionsSave;
        private System.Windows.Forms.Button Host4Player;
        private System.Windows.Forms.Button Host3Player;
        private System.Windows.Forms.Panel HostPanel;
        private System.Windows.Forms.Button HostBack;
        private System.Windows.Forms.Button Host2Player;
    }
}

