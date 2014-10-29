using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
//
//
namespace PROJECT
{
    public partial class FormMain : Form
    {
        public FormMain()
        {            
            InitializeComponent();            
        }
        //
        // Переменные        
        private const int CS_DROPSHADOW = 0x00020000;
        static public int VAR = -1;
        //
        // Вывод тени для формы
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ClassStyle |= CS_DROPSHADOW;
                return CP;
            }
        }  
        //
        // Загрузка формы
        private void FormMain_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            Rectangle SmallRect = BEnter.ClientRectangle;
            SmallRect.Inflate(-3, -3);
            gp.AddEllipse(SmallRect);
            BEnter.Region = new Region(gp);
            g.Dispose();
            this.TT.SetToolTip(BEnter, "Нажмите для входа в программу");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
        }
        //
        // Нажатие на кнопку "ВХОД"
        private void BEnter_Click(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                VAR = 0;
            }
            else
            {
                if (TBPass.Text == "qwerty")
                {
                    VAR = 1;                    
                }
                else
                {
                    MessageBox.Show("Неправильный пароль! Повторите ввод!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    TBPass.Text = "";
                }
            }
            if (VAR != -1)
            {               
                FormMain.ActiveForm.Visible = false;
                // Создать объект класса FormDataBase
                FormDataBase FormDataBase = new FormDataBase();                             
                FormDataBase.Show();                
            }
        }
        //
        // Режим администратора
        private void RB2_CheckedChanged(object sender, EventArgs e)
        {
            TBPass.Visible = true;
            TBPass.Focus();
        }
        //
        // Режим пользователя
        private void RB1_CheckedChanged(object sender, EventArgs e)
        {
            TBPass.Visible = false;
        }

        
    }
}
