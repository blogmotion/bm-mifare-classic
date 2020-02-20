using mct2dmp;
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
