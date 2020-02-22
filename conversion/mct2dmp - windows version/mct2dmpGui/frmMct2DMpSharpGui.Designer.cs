namespace mct2dmpGui
{
    partial class FrmMct2DMpSharpGui
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
            this.components = new System.ComponentModel.Container();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.lblInfos = new System.Windows.Forms.Label();
            this.ckConvertToEml = new System.Windows.Forms.CheckBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(307, 13);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(153, 37);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(13, 13);
            this.lblSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(233, 25);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "MCT or MFC Classic File";
            // 
            // ofd1
            // 
            this.ofd1.Filter = "MCT File|*.mct|Mifare dump|*.dmp|MFD Files|*.mfd|IMG Files|*.img|Proxmark eml Fil" +
    "es|*.eml|Dump File|*.mfd|All Files|*.*";
            this.ofd1.FilterIndex = 7;
            this.ofd1.ReadOnlyChecked = true;
            this.ofd1.RestoreDirectory = true;
            this.ofd1.ShowReadOnly = true;
            this.ofd1.SupportMultiDottedExtensions = true;
            // 
            // sfd1
            // 
            this.sfd1.Filter = "MFD File|*.mfd|IMG File|*.img|Proxmark eml File|*.eml|Dump File|*.dump|All Files|" +
    "*.*";
            this.sfd1.RestoreDirectory = true;
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Location = new System.Drawing.Point(13, 81);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(0, 25);
            this.lblInfos.TabIndex = 2;
            // 
            // ckConvertToEml
            // 
            this.ckConvertToEml.AutoSize = true;
            this.ckConvertToEml.Location = new System.Drawing.Point(18, 42);
            this.ckConvertToEml.Name = "ckConvertToEml";
            this.ckConvertToEml.Size = new System.Drawing.Size(255, 29);
            this.ckConvertToEml.TabIndex = 3;
            this.ckConvertToEml.Text = "Convert to proxmark .eml";
            this.toolTip1.SetToolTip(this.ckConvertToEml, "Check this if you are using a proxmark3 tag reader\r\nProxmark3 .eml (text dump) fo" +
        "rmat is different from Mifare Classic Tool (text dump) format");
            this.ckConvertToEml.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Enabled = false;
            this.btnOpenFolder.Location = new System.Drawing.Point(307, 58);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(153, 63);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "Open target folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // FrmMct2DMpSharpGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 124);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.ckConvertToEml);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMct2DMpSharpGui";
            this.Text = "mct2dmpSharp Gui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.CheckBox ckConvertToEml;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

