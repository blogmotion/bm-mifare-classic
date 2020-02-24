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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(309, 60);
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
            this.lblSource.Location = new System.Drawing.Point(13, 66);
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
            this.lblInfos.Location = new System.Drawing.Point(13, 141);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(0, 25);
            this.lblInfos.TabIndex = 2;
            // 
            // ckConvertToEml
            // 
            this.ckConvertToEml.AutoSize = true;
            this.ckConvertToEml.Location = new System.Drawing.Point(18, 95);
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
            this.btnOpenFolder.Location = new System.Drawing.Point(309, 105);
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(153, 63);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "Open target folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 38);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.blogToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 34);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.aboutToolStripMenuItem.Text = "Github link";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.blogToolStripMenuItem.Text = "Blogmotion link";
            this.blogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // FrmMct2DMpSharpGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 178);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.ckConvertToEml);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 242);
            this.Name = "FrmMct2DMpSharpGui";
            this.Text = "mct2dmpSharp Gui";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogToolStripMenuItem;
    }
}

