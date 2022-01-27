namespace TrackerUI
{
    partial class BugTrackerHubForm
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
            this.hubSidePanel = new System.Windows.Forms.Panel();
            this.hubHeaderLabel = new System.Windows.Forms.Label();
            this.hubSideHeaderPanel = new System.Windows.Forms.Panel();
            this.sideHubTeamsPanel = new System.Windows.Forms.Panel();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.sideProfilePanel = new System.Windows.Forms.Panel();
            this.userProfileLabel = new System.Windows.Forms.Label();
            this.profileBtn = new System.Windows.Forms.Button();
            this.hubSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hubSidePanel
            // 
            this.hubSidePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hubSidePanel.Controls.Add(this.profileBtn);
            this.hubSidePanel.Controls.Add(this.sideHubTeamsPanel);
            this.hubSidePanel.Controls.Add(this.hubSideHeaderPanel);
            this.hubSidePanel.Controls.Add(this.teamsLabel);
            this.hubSidePanel.Controls.Add(this.hubHeaderLabel);
            this.hubSidePanel.Location = new System.Drawing.Point(2, 1);
            this.hubSidePanel.Name = "hubSidePanel";
            this.hubSidePanel.Size = new System.Drawing.Size(200, 1036);
            this.hubSidePanel.TabIndex = 0;
            // 
            // hubHeaderLabel
            // 
            this.hubHeaderLabel.AutoSize = true;
            this.hubHeaderLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hubHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hubHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.hubHeaderLabel.Location = new System.Drawing.Point(14, 8);
            this.hubHeaderLabel.Name = "hubHeaderLabel";
            this.hubHeaderLabel.Size = new System.Drawing.Size(168, 37);
            this.hubHeaderLabel.TabIndex = 1;
            this.hubHeaderLabel.Text = "Bug Tracker";
            // 
            // hubSideHeaderPanel
            // 
            this.hubSideHeaderPanel.BackColor = System.Drawing.Color.White;
            this.hubSideHeaderPanel.Location = new System.Drawing.Point(0, 58);
            this.hubSideHeaderPanel.Name = "hubSideHeaderPanel";
            this.hubSideHeaderPanel.Size = new System.Drawing.Size(200, 1);
            this.hubSideHeaderPanel.TabIndex = 1;
            // 
            // sideHubTeamsPanel
            // 
            this.sideHubTeamsPanel.BackColor = System.Drawing.Color.White;
            this.sideHubTeamsPanel.Location = new System.Drawing.Point(0, 198);
            this.sideHubTeamsPanel.Name = "sideHubTeamsPanel";
            this.sideHubTeamsPanel.Size = new System.Drawing.Size(200, 1);
            this.sideHubTeamsPanel.TabIndex = 2;
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.teamsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsLabel.ForeColor = System.Drawing.Color.White;
            this.teamsLabel.Location = new System.Drawing.Point(57, 145);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(83, 32);
            this.teamsLabel.TabIndex = 3;
            this.teamsLabel.Text = "Teams";
            // 
            // sideProfilePanel
            // 
            this.sideProfilePanel.BackColor = System.Drawing.Color.White;
            this.sideProfilePanel.Location = new System.Drawing.Point(2, 128);
            this.sideProfilePanel.Name = "sideProfilePanel";
            this.sideProfilePanel.Size = new System.Drawing.Size(200, 1);
            this.sideProfilePanel.TabIndex = 2;
            // 
            // userProfileLabel
            // 
            this.userProfileLabel.AutoSize = true;
            this.userProfileLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userProfileLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileLabel.ForeColor = System.Drawing.Color.White;
            this.userProfileLabel.Location = new System.Drawing.Point(449, 199);
            this.userProfileLabel.Name = "userProfileLabel";
            this.userProfileLabel.Size = new System.Drawing.Size(85, 32);
            this.userProfileLabel.TabIndex = 3;
            this.userProfileLabel.Text = "Profile";
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Location = new System.Drawing.Point(21, 65);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(159, 56);
            this.profileBtn.TabIndex = 3;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            // 
            // BugTrackerHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1467, 1038);
            this.Controls.Add(this.userProfileLabel);
            this.Controls.Add(this.sideProfilePanel);
            this.Controls.Add(this.hubSidePanel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BugTrackerHubForm";
            this.Text = "BugTracker Hub";
            this.hubSidePanel.ResumeLayout(false);
            this.hubSidePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel hubSidePanel;
        private System.Windows.Forms.Label hubHeaderLabel;
        private System.Windows.Forms.Panel hubSideHeaderPanel;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Panel sideHubTeamsPanel;
        private System.Windows.Forms.Label teamsLabel;
        private System.Windows.Forms.Panel sideProfilePanel;
        private System.Windows.Forms.Label userProfileLabel;
    }
}