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

namespace TextEditer31059
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //アプリ終了
            Application.Exit();
        }

        private void FileSave(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(rtTextArea.Text);
                this.fileName = sfdFileSave.FileName;
            }
        }

        private void SaveNameAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdFileSave.ShowDialog() == DialogResult.OK)
            {
                FileSave(sfdFileSave.FileName);
            }
        }

        private void OpenOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdFileOpen.FileName,System.Text.Encoding.GetEncoding("utf-8"),false))
                {
                    rtTextArea.Text = sr.ReadToEnd();
                }
            }
        }

        private void SaveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fileName != "")
            {
                FileSave(fileName);
            } else
            {
                SaveNameAToolStripMenuItem_Click(sender, e);
            }
        }
        //新規作成
        private void NewNToolStripMenuItem_Click(object sender, EventArgs e)
        {
                rtTextArea.Clear();
                this.fileName = "";
        }

        private void UndoUToolStripMenuItem_Click(object sender, EventArgs e)
        {
                rtTextArea.Undo();
        }

        private void RedoRToolStripMenuItem_Click(object sender, EventArgs e)
        {
                rtTextArea.Redo();
        }

        private void CutoutTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Cut();
        }

        private void PastingPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Paste();
        }

        private void CopyCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtTextArea.Copy();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //編集メニュー項目内のマスク処理
        private void EditEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Rtf);
            UndoUToolStripMenuItem.Enabled = rtTextArea.CanUndo;
            RedoRToolStripMenuItem.Enabled = rtTextArea.CanRedo;
            CutoutTToolStripMenuItem.Enabled = rtTextArea.SelectionLength > 0;
            CopyCToolStripMenuItem.Enabled = rtTextArea.SelectionLength > 0;
            //PastingPToolStripMenuItem.Enabled = rtTextArea.CanPaste(myFormat) ? true : false;
            PastingPToolStripMenuItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Rtf);
        }
    }
}
