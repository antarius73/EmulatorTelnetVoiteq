namespace TelNetEmulatorVoiteq
{
    partial class EmulatorMainFrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = new System.Windows.Forms.TabControl();
            this.terminalSurveyTap = new System.Windows.Forms.TabPage();
            this.projectLbl = new System.Windows.Forms.Label();
            this.currentProjectCbx = new System.Windows.Forms.ComboBox();
            this.clearTelnetDialogueBtn = new System.Windows.Forms.Button();
            this.LogDgv = new System.Windows.Forms.DataGridView();
            this.terminalDataFluxRtb = new System.Windows.Forms.RichTextBox();
            this.hostPortTxt = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.hostLbl = new System.Windows.Forms.Label();
            this.stopServerBtn = new System.Windows.Forms.Button();
            this.startServerBtn = new System.Windows.Forms.Button();
            this.TelnetProjectTap = new System.Windows.Forms.TabPage();
            this.mainTab.SuspendLayout();
            this.terminalSurveyTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add(this.terminalSurveyTap);
            this.mainTab.Controls.Add(this.TelnetProjectTap);
            this.mainTab.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTab.Location = new System.Drawing.Point(0, 0);
            this.mainTab.Margin = new System.Windows.Forms.Padding(2);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(973, 652);
            this.mainTab.TabIndex = 0;
            // 
            // terminalSurveyTap
            // 
            this.terminalSurveyTap.Controls.Add(this.projectLbl);
            this.terminalSurveyTap.Controls.Add(this.currentProjectCbx);
            this.terminalSurveyTap.Controls.Add(this.clearTelnetDialogueBtn);
            this.terminalSurveyTap.Controls.Add(this.LogDgv);
            this.terminalSurveyTap.Controls.Add(this.terminalDataFluxRtb);
            this.terminalSurveyTap.Controls.Add(this.hostPortTxt);
            this.terminalSurveyTap.Controls.Add(this.portLbl);
            this.terminalSurveyTap.Controls.Add(this.hostLbl);
            this.terminalSurveyTap.Controls.Add(this.stopServerBtn);
            this.terminalSurveyTap.Controls.Add(this.startServerBtn);
            this.terminalSurveyTap.Location = new System.Drawing.Point(4, 22);
            this.terminalSurveyTap.Margin = new System.Windows.Forms.Padding(2);
            this.terminalSurveyTap.Name = "terminalSurveyTap";
            this.terminalSurveyTap.Padding = new System.Windows.Forms.Padding(2);
            this.terminalSurveyTap.Size = new System.Drawing.Size(965, 626);
            this.terminalSurveyTap.TabIndex = 0;
            this.terminalSurveyTap.Text = "Terminal Survey";
            this.terminalSurveyTap.UseVisualStyleBackColor = true;
            // 
            // projectLbl
            // 
            this.projectLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectLbl.AutoSize = true;
            this.projectLbl.Location = new System.Drawing.Point(611, 37);
            this.projectLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLbl.Name = "projectLbl";
            this.projectLbl.Size = new System.Drawing.Size(85, 14);
            this.projectLbl.TabIndex = 53;
            this.projectLbl.Text = "Current project :";
            // 
            // currentProjectCbx
            // 
            this.currentProjectCbx.FormattingEnabled = true;
            this.currentProjectCbx.Location = new System.Drawing.Point(326, 34);
            this.currentProjectCbx.Name = "currentProjectCbx";
            this.currentProjectCbx.Size = new System.Drawing.Size(259, 21);
            this.currentProjectCbx.TabIndex = 52;
            // 
            // clearTelnetDialogueBtn
            // 
            this.clearTelnetDialogueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearTelnetDialogueBtn.Location = new System.Drawing.Point(7, 604);
            this.clearTelnetDialogueBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearTelnetDialogueBtn.Name = "clearTelnetDialogueBtn";
            this.clearTelnetDialogueBtn.Size = new System.Drawing.Size(85, 20);
            this.clearTelnetDialogueBtn.TabIndex = 51;
            this.clearTelnetDialogueBtn.Text = "Clear";
            this.clearTelnetDialogueBtn.UseVisualStyleBackColor = true;
            // 
            // LogDgv
            // 
            this.LogDgv.AllowUserToAddRows = false;
            this.LogDgv.AllowUserToDeleteRows = false;
            this.LogDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.LogDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LogDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LogDgv.Location = new System.Drawing.Point(7, 355);
            this.LogDgv.MultiSelect = false;
            this.LogDgv.Name = "LogDgv";
            this.LogDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LogDgv.RowHeadersVisible = false;
            this.LogDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogDgv.Size = new System.Drawing.Size(955, 240);
            this.LogDgv.TabIndex = 50;
            // 
            // terminalDataFluxRtb
            // 
            this.terminalDataFluxRtb.AcceptsTab = true;
            this.terminalDataFluxRtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terminalDataFluxRtb.BackColor = System.Drawing.Color.Black;
            this.terminalDataFluxRtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.terminalDataFluxRtb.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminalDataFluxRtb.ForeColor = System.Drawing.Color.White;
            this.terminalDataFluxRtb.Location = new System.Drawing.Point(7, 61);
            this.terminalDataFluxRtb.Name = "terminalDataFluxRtb";
            this.terminalDataFluxRtb.ReadOnly = true;
            this.terminalDataFluxRtb.Size = new System.Drawing.Size(955, 288);
            this.terminalDataFluxRtb.TabIndex = 6;
            this.terminalDataFluxRtb.Text = "";
            this.terminalDataFluxRtb.WordWrap = false;
            // 
            // hostPortTxt
            // 
            this.hostPortTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hostPortTxt.Location = new System.Drawing.Point(850, 10);
            this.hostPortTxt.Margin = new System.Windows.Forms.Padding(2);
            this.hostPortTxt.Name = "hostPortTxt";
            this.hostPortTxt.Size = new System.Drawing.Size(111, 19);
            this.hostPortTxt.TabIndex = 5;
            // 
            // portLbl
            // 
            this.portLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(816, 13);
            this.portLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(32, 14);
            this.portLbl.TabIndex = 4;
            this.portLbl.Text = "Port :";
            // 
            // hostLbl
            // 
            this.hostLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hostLbl.AutoSize = true;
            this.hostLbl.Location = new System.Drawing.Point(661, 13);
            this.hostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostLbl.Name = "hostLbl";
            this.hostLbl.Size = new System.Drawing.Size(35, 14);
            this.hostLbl.TabIndex = 2;
            this.hostLbl.Text = "Host :";
            // 
            // stopServerBtn
            // 
            this.stopServerBtn.Enabled = false;
            this.stopServerBtn.Location = new System.Drawing.Point(96, 5);
            this.stopServerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stopServerBtn.Name = "stopServerBtn";
            this.stopServerBtn.Size = new System.Drawing.Size(81, 28);
            this.stopServerBtn.TabIndex = 1;
            this.stopServerBtn.Text = "Stop server";
            this.stopServerBtn.UseVisualStyleBackColor = true;
            this.stopServerBtn.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // startServerBtn
            // 
            this.startServerBtn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startServerBtn.Location = new System.Drawing.Point(6, 5);
            this.startServerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(86, 28);
            this.startServerBtn.TabIndex = 0;
            this.startServerBtn.Text = "Start server";
            this.startServerBtn.UseVisualStyleBackColor = true;
            this.startServerBtn.Click += new System.EventHandler(this.startServer_Click);
            // 
            // TelnetProjectTap
            // 
            this.TelnetProjectTap.Location = new System.Drawing.Point(4, 22);
            this.TelnetProjectTap.Margin = new System.Windows.Forms.Padding(2);
            this.TelnetProjectTap.Name = "TelnetProjectTap";
            this.TelnetProjectTap.Padding = new System.Windows.Forms.Padding(2);
            this.TelnetProjectTap.Size = new System.Drawing.Size(590, 626);
            this.TelnetProjectTap.TabIndex = 1;
            this.TelnetProjectTap.Text = "TelNet Project";
            this.TelnetProjectTap.UseVisualStyleBackColor = true;
            // 
            // EmulatorMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 652);
            this.Controls.Add(this.mainTab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmulatorMainFrm";
            this.Text = "Telnet Emulator";
            this.mainTab.ResumeLayout(false);
            this.terminalSurveyTap.ResumeLayout(false);
            this.terminalSurveyTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage terminalSurveyTap;
        private System.Windows.Forms.TabPage TelnetProjectTap;
        private System.Windows.Forms.Button stopServerBtn;
        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.TextBox hostPortTxt;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label hostLbl;
        public System.Windows.Forms.RichTextBox terminalDataFluxRtb;
        private System.Windows.Forms.DataGridView LogDgv;
        private System.Windows.Forms.Button clearTelnetDialogueBtn;
        private System.Windows.Forms.Label projectLbl;
        private System.Windows.Forms.ComboBox currentProjectCbx;
    }
}

