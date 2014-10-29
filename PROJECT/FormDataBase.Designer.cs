namespace PROJECT
{
    partial class FormDataBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBase));
            this.MS = new System.Windows.Forms.MenuStrip();
            this.TSMFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDelFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOpt = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAboutProg = new System.Windows.Forms.ToolStripMenuItem();
            this.SS = new System.Windows.Forms.StatusStrip();
            this.SL1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SL2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.TSBDelFolder = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBDelFile = new System.Windows.Forms.ToolStripButton();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBHelp = new System.Windows.Forms.ToolStripButton();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BOpenFile = new System.Windows.Forms.Button();
            this.TBFolder = new System.Windows.Forms.TextBox();
            this.BAddFolder = new System.Windows.Forms.Button();
            this.BBrowse = new System.Windows.Forms.Button();
            this.TBFile = new System.Windows.Forms.TextBox();
            this.BAddFile = new System.Windows.Forms.Button();
            this.LBFile = new System.Windows.Forms.ListBox();
            this.LBFolder = new System.Windows.Forms.ListBox();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.MS.SuspendLayout();
            this.SS.SuspendLayout();
            this.TS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MS
            // 
            this.MS.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFile,
            this.TSMEdit,
            this.TSMOpt,
            this.TSMHelp});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(994, 24);
            this.MS.TabIndex = 0;
            // 
            // TSMFile
            // 
            this.TSMFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMExit});
            this.TSMFile.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMFile.Name = "TSMFile";
            this.TSMFile.Size = new System.Drawing.Size(50, 20);
            this.TSMFile.Text = "Файл";
            this.TSMFile.ToolTipText = "Меню ~Файл~";
            // 
            // TSMExit
            // 
            this.TSMExit.Name = "TSMExit";
            this.TSMExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.TSMExit.Size = new System.Drawing.Size(167, 22);
            this.TSMExit.Text = "Выход";
            this.TSMExit.ToolTipText = "Нажмите для выхода из программы";
            this.TSMExit.Click += new System.EventHandler(this.TSMExit_Click);
            // 
            // TSMEdit
            // 
            this.TSMEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDelFolder,
            this.TSMDelFile});
            this.TSMEdit.Name = "TSMEdit";
            this.TSMEdit.Size = new System.Drawing.Size(116, 20);
            this.TSMEdit.Text = "Редактирование";
            this.TSMEdit.ToolTipText = "Меню ~Редактирование~";
            // 
            // TSMDelFolder
            // 
            this.TSMDelFolder.Image = ((System.Drawing.Image)(resources.GetObject("TSMDelFolder.Image")));
            this.TSMDelFolder.Name = "TSMDelFolder";
            this.TSMDelFolder.Size = new System.Drawing.Size(177, 22);
            this.TSMDelFolder.Text = "Удалить папку";
            this.TSMDelFolder.ToolTipText = "~Удалить папку~";
            this.TSMDelFolder.Click += new System.EventHandler(this.TSBDelFolder_Click);
            // 
            // TSMDelFile
            // 
            this.TSMDelFile.Image = ((System.Drawing.Image)(resources.GetObject("TSMDelFile.Image")));
            this.TSMDelFile.Name = "TSMDelFile";
            this.TSMDelFile.Size = new System.Drawing.Size(177, 22);
            this.TSMDelFile.Text = "Удалить файл";
            this.TSMDelFile.ToolTipText = "~Удалить файл~";
            this.TSMDelFile.Click += new System.EventHandler(this.TSBDelFile_Click);
            // 
            // TSMOpt
            // 
            this.TSMOpt.Name = "TSMOpt";
            this.TSMOpt.Size = new System.Drawing.Size(83, 20);
            this.TSMOpt.Text = "Настройка";
            this.TSMOpt.ToolTipText = "Меню ~Настройка~";
            this.TSMOpt.Click += new System.EventHandler(this.TSMOpt_Click);
            // 
            // TSMHelp
            // 
            this.TSMHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAboutProg});
            this.TSMHelp.Name = "TSMHelp";
            this.TSMHelp.Size = new System.Drawing.Size(70, 20);
            this.TSMHelp.Text = "Справка";
            this.TSMHelp.ToolTipText = "Меню ~Справка~";
            // 
            // TSMAboutProg
            // 
            this.TSMAboutProg.Image = ((System.Drawing.Image)(resources.GetObject("TSMAboutProg.Image")));
            this.TSMAboutProg.Name = "TSMAboutProg";
            this.TSMAboutProg.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.TSMAboutProg.Size = new System.Drawing.Size(185, 22);
            this.TSMAboutProg.Text = "О программе";
            this.TSMAboutProg.Click += new System.EventHandler(this.TSMAboutProg_Click);
            // 
            // SS
            // 
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SL1,
            this.SL2});
            this.SS.Location = new System.Drawing.Point(0, 577);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(994, 24);
            this.SS.TabIndex = 1;
            // 
            // SL1
            // 
            this.SL1.AutoSize = false;
            this.SL1.Name = "SL1";
            this.SL1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SL1.Size = new System.Drawing.Size(860, 19);
            // 
            // SL2
            // 
            this.SL2.AutoSize = false;
            this.SL2.Name = "SL2";
            this.SL2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SL2.Size = new System.Drawing.Size(109, 19);
            // 
            // TS
            // 
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBDelFolder,
            this.Sep1,
            this.TSBDelFile,
            this.Sep2,
            this.TSBHelp});
            this.TS.Location = new System.Drawing.Point(0, 24);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(994, 25);
            this.TS.TabIndex = 2;
            this.TS.Text = "~Каталог проектов~ by Sacret^^";
            // 
            // TSBDelFolder
            // 
            this.TSBDelFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBDelFolder.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelFolder.Image")));
            this.TSBDelFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelFolder.Name = "TSBDelFolder";
            this.TSBDelFolder.Size = new System.Drawing.Size(23, 22);
            this.TSBDelFolder.ToolTipText = "Удалить папку";
            this.TSBDelFolder.Click += new System.EventHandler(this.TSBDelFolder_Click);
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBDelFile
            // 
            this.TSBDelFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBDelFile.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelFile.Image")));
            this.TSBDelFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelFile.Name = "TSBDelFile";
            this.TSBDelFile.Size = new System.Drawing.Size(23, 22);
            this.TSBDelFile.ToolTipText = "Удалить файл";
            this.TSBDelFile.Click += new System.EventHandler(this.TSBDelFile_Click);
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBHelp
            // 
            this.TSBHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBHelp.Image = ((System.Drawing.Image)(resources.GetObject("TSBHelp.Image")));
            this.TSBHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBHelp.Name = "TSBHelp";
            this.TSBHelp.Size = new System.Drawing.Size(23, 22);
            this.TSBHelp.ToolTipText = "Справка - О программе";
            this.TSBHelp.Click += new System.EventHandler(this.TSMAboutProg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 530);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BOpenFile
            // 
            this.BOpenFile.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BOpenFile.Location = new System.Drawing.Point(700, 293);
            this.BOpenFile.Name = "BOpenFile";
            this.BOpenFile.Size = new System.Drawing.Size(230, 20);
            this.BOpenFile.TabIndex = 18;
            this.BOpenFile.Text = "ОТКРЫТЬ ФАЙЛ";
            this.BOpenFile.UseVisualStyleBackColor = true;
            this.BOpenFile.Click += new System.EventHandler(this.BOpenFile_Click);
            // 
            // TBFolder
            // 
            this.TBFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFolder.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBFolder.Location = new System.Drawing.Point(700, 143);
            this.TBFolder.Name = "TBFolder";
            this.TBFolder.Size = new System.Drawing.Size(230, 20);
            this.TBFolder.TabIndex = 17;
            // 
            // BAddFolder
            // 
            this.BAddFolder.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddFolder.Location = new System.Drawing.Point(700, 179);
            this.BAddFolder.Name = "BAddFolder";
            this.BAddFolder.Size = new System.Drawing.Size(230, 20);
            this.BAddFolder.TabIndex = 16;
            this.BAddFolder.Text = "ДОБАВИТЬ ПАПКУ";
            this.BAddFolder.UseVisualStyleBackColor = true;
            this.BAddFolder.Click += new System.EventHandler(this.BAddFolder_Click);
            // 
            // BBrowse
            // 
            this.BBrowse.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBrowse.Location = new System.Drawing.Point(876, 215);
            this.BBrowse.Name = "BBrowse";
            this.BBrowse.Size = new System.Drawing.Size(54, 20);
            this.BBrowse.TabIndex = 15;
            this.BBrowse.Text = "ОБЗОР";
            this.BBrowse.UseVisualStyleBackColor = true;
            this.BBrowse.Click += new System.EventHandler(this.BBrowse_Click);
            // 
            // TBFile
            // 
            this.TBFile.BackColor = System.Drawing.SystemColors.Window;
            this.TBFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFile.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBFile.Location = new System.Drawing.Point(700, 215);
            this.TBFile.Name = "TBFile";
            this.TBFile.ReadOnly = true;
            this.TBFile.Size = new System.Drawing.Size(156, 20);
            this.TBFile.TabIndex = 14;
            // 
            // BAddFile
            // 
            this.BAddFile.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAddFile.Location = new System.Drawing.Point(700, 254);
            this.BAddFile.Name = "BAddFile";
            this.BAddFile.Size = new System.Drawing.Size(230, 20);
            this.BAddFile.TabIndex = 13;
            this.BAddFile.Text = "ДОБАВИТЬ ФАЙЛ";
            this.BAddFile.UseVisualStyleBackColor = true;
            this.BAddFile.Click += new System.EventHandler(this.BAddFile_Click);
            // 
            // LBFile
            // 
            this.LBFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBFile.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBFile.FormattingEnabled = true;
            this.LBFile.ItemHeight = 16;
            this.LBFile.Location = new System.Drawing.Point(410, 143);
            this.LBFile.Name = "LBFile";
            this.LBFile.Size = new System.Drawing.Size(230, 370);
            this.LBFile.TabIndex = 12;
            // 
            // LBFolder
            // 
            this.LBFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBFolder.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBFolder.FormattingEnabled = true;
            this.LBFolder.ItemHeight = 16;
            this.LBFolder.Location = new System.Drawing.Point(65, 143);
            this.LBFolder.Name = "LBFolder";
            this.LBFolder.Size = new System.Drawing.Size(230, 370);
            this.LBFolder.TabIndex = 11;
            this.LBFolder.SelectedIndexChanged += new System.EventHandler(this.LBFolder_SelectedIndexChanged);
            // 
            // T1
            // 
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // TT
            // 
            this.TT.IsBalloon = true;
            this.TT.ToolTipTitle = "Подсказка";
            // 
            // FormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 601);
            this.Controls.Add(this.BOpenFile);
            this.Controls.Add(this.TBFolder);
            this.Controls.Add(this.BAddFolder);
            this.Controls.Add(this.BBrowse);
            this.Controls.Add(this.TBFile);
            this.Controls.Add(this.BAddFile);
            this.Controls.Add(this.LBFile);
            this.Controls.Add(this.LBFolder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TS);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.MS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS;
            this.MaximizeBox = false;
            this.Name = "FormDataBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~Каталог проектов~ by Sacret^^";
            this.Load += new System.EventHandler(this.FormDataBase_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDataBase_FormClosed);
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ToolStripMenuItem TSMFile;
        private System.Windows.Forms.ToolStripMenuItem TSMEdit;
        private System.Windows.Forms.ToolStripMenuItem TSMHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BOpenFile;
        private System.Windows.Forms.TextBox TBFolder;
        private System.Windows.Forms.Button BAddFolder;
        private System.Windows.Forms.Button BBrowse;
        private System.Windows.Forms.TextBox TBFile;
        private System.Windows.Forms.Button BAddFile;
        private System.Windows.Forms.ListBox LBFile;
        private System.Windows.Forms.ListBox LBFolder;
        private System.Windows.Forms.ToolStripMenuItem TSMAboutProg;
        private System.Windows.Forms.ToolStripMenuItem TSMExit;
        private System.Windows.Forms.ToolStripStatusLabel SL1;
        private System.Windows.Forms.ToolStripStatusLabel SL2;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.ToolTip TT;
        private System.Windows.Forms.ToolStripMenuItem TSMOpt;
        private System.Windows.Forms.ToolStripButton TSBDelFolder;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripButton TSBDelFile;
        private System.Windows.Forms.ToolStripSeparator Sep2;
        private System.Windows.Forms.ToolStripButton TSBHelp;
        private System.Windows.Forms.ToolStripMenuItem TSMDelFolder;
        private System.Windows.Forms.ToolStripMenuItem TSMDelFile;
    }
}