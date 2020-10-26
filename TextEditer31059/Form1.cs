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



        private void FileSave(string fileName)
        {
            rtTextArea.SaveFile(fileName,RichTextBoxStreamType.RichText);
            /*using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(rtTextArea.Text);
                this.fileName = sfdFileSave.FileName;
            }*/
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

        //上書き保存
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
            if (rtTextArea.Text != "")
            {
                string text = "無題への変更内容を保存しますか？";
                string title = "テキストエディタ";

                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveSToolStripMenuItem_Click(sender,e);
                } else if (result == DialogResult.No)
                {
                    rtTextArea.Clear();
                    this.fileName = "";
                }
                
            } else
            {
                rtTextArea.Clear();
                this.fileName = "";
            }
            
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
            rtTextArea.SelectedText = "";
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
            DeleteToolStripMenuItem.Enabled = rtTextArea.SelectionLength > 0;
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog setcolor = new ColorDialog();
            if (setcolor.ShowDialog() == DialogResult.OK)
            {
                //選択された色の取得
                rtTextArea.SelectionColor = setcolor.Color;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();

            fontDialog1.ShowColor = true;

            fontDialog1.Font = rtTextArea.Font;
            fontDialog1.Color = rtTextArea.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtTextArea.SelectionFont = fontDialog1.Font;
                rtTextArea.SelectionColor = fontDialog1.Color;
            }
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtTextArea.Text != "")
            {
                string text = "無題への変更内容を保存しますか？";
                string title = "テキストエディタ";

                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveSToolStripMenuItem_Click(sender, e);
                    Application.Exit();
                } else if (result == DialogResult.No)
                {
                    Application.Exit();
                }

            } else
            {
                //アプリ終了
                Application.Exit();
            }

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtTextArea.Text != "")
            {
                string text = "無題への変更内容を保存しますか？";
                string title = "テキストエディタ";

                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show(text, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveSToolStripMenuItem_Click(sender, e);
                    Application.Exit();
                } else if (result == DialogResult.Cancel)
                {
                    e.Cancel = false;
                }

            } else
            {
                //アプリ終了
                Application.Exit();
            }
        }

        //バージョン情報
        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VersionForm versionForm = new VersionForm();
            VersionForm.GetInstance().Show();
            //versionForm.Show(); //モーダルダイアログとして表示
        }
    }
}
