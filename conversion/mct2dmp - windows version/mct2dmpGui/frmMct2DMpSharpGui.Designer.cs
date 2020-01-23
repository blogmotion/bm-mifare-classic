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
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(206, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(125, 42);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 23);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(181, 20);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "MCT or MFC Classic File";
            // 
            // ofd1
            // 
            this.ofd1.Filter = "MCT Files|*.mct|Mifare dumps|*.dmp|MFD Files|*.mfd|IMG Files|*.img|All Files|*.*";
            this.ofd1.FilterIndex = 5;
            this.ofd1.ReadOnlyChecked = true;
            this.ofd1.RestoreDirectory = true;
            this.ofd1.ShowReadOnly = true;
            this.ofd1.SupportMultiDottedExtensions = true;
            // 
            // sfd1
            // 
            this.sfd1.Filter = "MFD Files|*.mfd|IMG Files|*.img|All Files|*.*";
            this.sfd1.RestoreDirectory = true;
            // 
            // FrmMct2DMpSharpGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 71);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
    }
}

