namespace PROJECT
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PB = new System.Windows.Forms.PictureBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.BEnter = new System.Windows.Forms.Button();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.Image = ((System.Drawing.Image)(resources.GetObject("PB.Image")));
            this.PB.Location = new System.Drawing.Point(0, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(600, 375);
            this.PB.TabIndex = 4;
            this.PB.TabStop = false;
            // 
            // TBPass
            // 
            this.TBPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPass.Location = new System.Drawing.Point(71, 217);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '*';
            this.TBPass.Size = new System.Drawing.Size(223, 20);
            this.TBPass.TabIndex = 5;
            this.TBPass.Visible = false;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Location = new System.Drawing.Point(34, 128);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(14, 13);
            this.RB1.TabIndex = 6;
            this.RB1.TabStop = true;
            this.RB1.UseVisualStyleBackColor = true;
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(34, 175);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(14, 13);
            this.RB2.TabIndex = 7;
            this.RB2.UseVisualStyleBackColor = true;
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // BEnter
            // 
            this.BEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEnter.Image = ((System.Drawing.Image)(resources.GetObject("BEnter.Image")));
            this.BEnter.Location = new System.Drawing.Point(250, 254);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(107, 106);
            this.BEnter.TabIndex = 8;
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BEnter_Click);
            // 
            // TT
            // 
            this.TT.AutoPopDelay = 5000;
            this.TT.InitialDelay = 500;
            this.TT.IsBalloon = true;
            this.TT.ReshowDelay = 100;
            this.TT.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AcceptButton = this.BEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 375);
            this.ControlBox = false;
            this.Controls.Add(this.BEnter);
            this.Controls.Add(this.RB2);
            this.Controls.Add(this.RB1);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.PB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.ToolTip TT;
    }
}

