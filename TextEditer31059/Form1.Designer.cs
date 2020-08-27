namespace TextEditer31059
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.rtTextArea = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveNameAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CutoutTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PastingPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字コードCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.fdFont = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // rtTextArea
            // 
            this.rtTextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtTextArea.Location = new System.Drawing.Point(0, 24);
            this.rtTextArea.Name = "rtTextArea";
            this.rtTextArea.Size = new System.Drawing.Size(800, 426);
            this.rtTextArea.TabIndex = 0;
            this.rtTextArea.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileFToolStripMenuItem,
            this.EditEToolStripMenuItem,
            this.文字コードCToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileFToolStripMenuItem
            // 
            this.FileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNToolStripMenuItem,
            this.OpenOToolStripMenuItem,
            this.SaveSToolStripMenuItem,
            this.SaveNameAToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitXToolStripMenuItem});
            this.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem";
            this.FileFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FileFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // NewNToolStripMenuItem
            // 
            this.NewNToolStripMenuItem.Name = "NewNToolStripMenuItem";
            this.NewNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewNToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.NewNToolStripMenuItem.Text = "新規作成(&N)";
            this.NewNToolStripMenuItem.Click += new System.EventHandler(this.NewNToolStripMenuItem_Click);
            // 
            // OpenOToolStripMenuItem
            // 
            this.OpenOToolStripMenuItem.Name = "OpenOToolStripMenuItem";
            this.OpenOToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenOToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.OpenOToolStripMenuItem.Text = "開く(&O)...";
            this.OpenOToolStripMenuItem.Click += new System.EventHandler(this.OpenOToolStripMenuItem_Click);
            // 
            // SaveSToolStripMenuItem
            // 
            this.SaveSToolStripMenuItem.Name = "SaveSToolStripMenuItem";
            this.SaveSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveSToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SaveSToolStripMenuItem.Text = "上書き保存(&S)";
            this.SaveSToolStripMenuItem.Click += new System.EventHandler(this.SaveSToolStripMenuItem_Click);
            // 
            // SaveNameAToolStripMenuItem
            // 
            this.SaveNameAToolStripMenuItem.Name = "SaveNameAToolStripMenuItem";
            this.SaveNameAToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.SaveNameAToolStripMenuItem.Text = "名前を付けて保存(&A)";
            this.SaveNameAToolStripMenuItem.Click += new System.EventHandler(this.SaveNameAToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // ExitXToolStripMenuItem
            // 
            this.ExitXToolStripMenuItem.Name = "ExitXToolStripMenuItem";
            this.ExitXToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitXToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.ExitXToolStripMenuItem.Text = "終了(&X)";
            this.ExitXToolStripMenuItem.Click += new System.EventHandler(this.ExitXToolStripMenuItem_Click);
            // 
            // EditEToolStripMenuItem
            // 
            this.EditEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoUToolStripMenuItem,
            this.RedoRToolStripMenuItem,
            this.toolStripSeparator2,
            this.CutoutTToolStripMenuItem,
            this.CopyCToolStripMenuItem,
            this.PastingPToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.toolStripSeparator3,
            this.ColorToolStripMenuItem,
            this.FontToolStripMenuItem});
            this.EditEToolStripMenuItem.Name = "EditEToolStripMenuItem";
            this.EditEToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.EditEToolStripMenuItem.Text = "編集(&E)";
            this.EditEToolStripMenuItem.Click += new System.EventHandler(this.EditEToolStripMenuItem_Click);
            // 
            // UndoUToolStripMenuItem
            // 
            this.UndoUToolStripMenuItem.Name = "UndoUToolStripMenuItem";
            this.UndoUToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UndoUToolStripMenuItem.Text = "元に戻す(&U)";
            this.UndoUToolStripMenuItem.Click += new System.EventHandler(this.UndoUToolStripMenuItem_Click);
            // 
            // RedoRToolStripMenuItem
            // 
            this.RedoRToolStripMenuItem.Name = "RedoRToolStripMenuItem";
            this.RedoRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RedoRToolStripMenuItem.Text = "やり直し(&R)";
            this.RedoRToolStripMenuItem.Click += new System.EventHandler(this.RedoRToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // CutoutTToolStripMenuItem
            // 
            this.CutoutTToolStripMenuItem.Name = "CutoutTToolStripMenuItem";
            this.CutoutTToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutoutTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CutoutTToolStripMenuItem.Text = "切り取り(&T)";
            this.CutoutTToolStripMenuItem.Click += new System.EventHandler(this.CutoutTToolStripMenuItem_Click);
            // 
            // CopyCToolStripMenuItem
            // 
            this.CopyCToolStripMenuItem.Name = "CopyCToolStripMenuItem";
            this.CopyCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyCToolStripMenuItem.Text = "コピー(&C)";
            this.CopyCToolStripMenuItem.Click += new System.EventHandler(this.CopyCToolStripMenuItem_Click);
            // 
            // PastingPToolStripMenuItem
            // 
            this.PastingPToolStripMenuItem.Name = "PastingPToolStripMenuItem";
            this.PastingPToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PastingPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PastingPToolStripMenuItem.Text = "貼り付け(&P)";
            this.PastingPToolStripMenuItem.Click += new System.EventHandler(this.PastingPToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "削除(&D)";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ColorToolStripMenuItem.Text = "色...";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FontToolStripMenuItem.Text = "フォント...";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // 文字コードCToolStripMenuItem
            // 
            this.文字コードCToolStripMenuItem.Name = "文字コードCToolStripMenuItem";
            this.文字コードCToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.文字コードCToolStripMenuItem.Text = "文字コード(&C)";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtTextArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "テキストエディタ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.RichTextBox rtTextArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveNameAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字コードCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoRToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.FontDialog fdFont;
        private System.Windows.Forms.ToolStripMenuItem CutoutTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PastingPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
    }
}

