<<<<<<< HEAD:conversion/mct2dmp - windows version/mct2dmpGui/frmMct2DMpSharpGui.cs
﻿using mct2dmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mct2dmpGui
{
    public partial class FrmMct2DMpSharpGui : Form
    {
        public FrmMct2DMpSharpGui()
        {
            InitializeComponent();
            Text += " " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var ret = ofd1.ShowDialog();
                if (ret == DialogResult.OK)
                {
                    Dump dump = null;
                    DumpConverter converter = new DumpConverter();
                    var inputFileType = converter.CheckDump(ofd1.FileName);
                    if (inputFileType == FileType.Text)
                    {
                        lblInfos.Text = "text dump detected";
                        dump = converter.ConvertToBinaryDump();
                        sfd1.FileName = Path.GetFileNameWithoutExtension(ofd1.FileName) + ".mfd";
                        sfd1.FilterIndex = 1;
                    }
                    else
                    {
                        lblInfos.Text = "binary dump detected";
                        dump = converter.ConvertToTextDump(ofd1.FileName, !ckConvertToEml.Checked);
                        sfd1.FileName = Path.GetFileNameWithoutExtension(ofd1.FileName) + (ckConvertToEml.Checked ? ".eml" : ".txt");
                        sfd1.FilterIndex = 2;
                    }
                    if (ckConvertToEml.Checked)
                    {
                        sfd1.FilterIndex = 3;
                    }
                    sfd1.InitialDirectory = ofd1.InitialDirectory;
                    ret = sfd1.ShowDialog();
                    if (ret == DialogResult.OK)
                    {
                        btnOpenFolder.Enabled = true;
                        if (inputFileType == FileType.Text)
                        {
                            File.WriteAllBytes(sfd1.FileName, dump.BinaryOutput.ToArray());
                        }
                        else
                        {
                            if (sfd1.FileName.EndsWith(".eml"))
                            {
                                ckConvertToEml.Checked = true;
                                dump = converter.ConvertToTextDump(ofd1.FileName, !ckConvertToEml.Checked);
                            }
                            File.WriteAllText(sfd1.FileName, dump.TextOutput);

                        }

                        MessageBox.Show($"Conversion to {(inputFileType == FileType.Text ? "Text dump" : "Binary dump")}: Done");
                        lblInfos.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (File.Exists(sfd1.FileName))
                Process.Start("explorer.exe", $"/select, {sfd1.FileName}");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/blogmotion/bm-mifare-classic");
            
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://blogmotion.fr/programmation/mct2dmpgui-windows-18235");
        }
    }
}
=======
﻿using mct2dmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mct2dmpGui
{
    public partial class FrmMct2DMpSharpGui : Form
    {
        public FrmMct2DMpSharpGui()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                var ret = ofd1.ShowDialog();
                if (ret == DialogResult.OK)
                {
                    Dump dump = null;
                    DumpConverter converter = new DumpConverter();
                    var inputFileType = converter.CheckDump(ofd1.FileName);
                    if (inputFileType == FileType.Text)
                    {
                        dump = converter.ConvertToBinaryDump();
                        sfd1.FileName = Path.GetFileNameWithoutExtension(ofd1.FileName) + ".mfd";
                        sfd1.FilterIndex = 1;
                    }
                    else
                    {
                        dump = converter.ConvertToTextDump(ofd1.FileName);
                        sfd1.FileName = Path.GetFileNameWithoutExtension(ofd1.FileName) + ".txt";
                        sfd1.FilterIndex = 2;
                    }

                    ret = sfd1.ShowDialog();
                    if (ret == DialogResult.OK)
                    {
                        if (inputFileType == FileType.Text)
                            File.WriteAllBytes(sfd1.FileName, dump.BinaryOutput.ToArray());
                        else
                            File.WriteAllText(sfd1.FileName, dump.TextOutput);

                        MessageBox.Show($"Conversion to {(inputFileType == FileType.Text ? "mfc classic" : "MCT")}: Done");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
>>>>>>> upstream/master:conversion/mct2dmp - windows version/code source/mct2dmpGui/frmMct2DMpSharpGui.cs
