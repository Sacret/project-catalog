using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
//
//
namespace PROJECT
{
    public partial class FormDataBase : Form
    {
        public FormDataBase()
        {
            InitializeComponent();
        }
        //
        // Переменные
        string FileName;
        string SourceFile = "source.txt";
        string Path;
        private const int CS_DROPSHADOW = 0x00020000;
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
        private void FormDataBase_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(SourceFile))
            Path = sr.ReadLine();            
            //
            if (FormMain.VAR == 0)
            {
                TBFolder.Enabled = false;
                BAddFolder.Enabled = false;
                TBFile.Enabled = false;
                BAddFile.Enabled = false;
                BBrowse.Enabled = false;
                TSBDelFile.Enabled = false;
                TSBDelFolder.Enabled = false;
                TSMEdit.Enabled = false;
                TSMOpt.Enabled = false;
            }
            //
            DateTime today = DateTime.Now;
            SL2.Text = (today.Date.ToLongDateString());
            //  
            LoadFolder();               
            LBFolder.SelectedIndexChanged += new EventHandler(LBFolder_SelectedIndexChanged);
            //
            this.TT.SetToolTip(LBFolder, "Названия всех проектов");
            this.TT.SetToolTip(LBFile, "Названия всех файлов");
            //
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        } 
        //
        // Загрузка папок
        void LoadFolder()
        {
            LBFolder.Items.Clear();                    
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(Path);
            System.IO.DirectoryInfo[] dirs = info.GetDirectories();
            LBFolder.Items.AddRange(dirs);
            LBFolder.SelectedIndex = 0;            
        }
        //
        // Выбор элемента в первом списке
        private void LBFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            LBFile.Items.Clear();
            string Path2 = Path + LBFolder.SelectedItem + "\\";
            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo(Path2);
            System.IO.FileInfo[] files = info.GetFiles();
            LBFile.Items.AddRange(files);
            if (LBFile.Items.Count > 0) LBFile.SelectedIndex = 0;
        }
        //
        // Добавление файла в папку проекта
        private void BAddFile_Click(object sender, EventArgs e)
        {
            if (TBFile.Text == "")
            {
                MessageBox.Show("Не введено имя файла!");
                return;
            }
            string sourcePath = @TBFile.Text;
            string targetPath = Path + LBFolder.SelectedItem;
            // Use Path class to manipulate file and directory paths.            
            string destFile = System.IO.Path.Combine(targetPath, FileName);            
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourcePath, destFile, true);
            TBFile.Text = "";
            LoadFolder();
        }
        //
        // Поиск файла для вставки
        private void BBrowse_Click(object sender, EventArgs e)
        {
            //Если выбран диалог открытия файла, выполняем условие
            if (OFD.ShowDialog() == DialogResult.OK)
            {                
                TBFile.Text = OFD.FileName;
                FileName = OFD.SafeFileName;
            }
        }
        //
        // Добавить папку проекта
        private void BAddFolder_Click(object sender, EventArgs e)
        {
            if (TBFolder.Text == "")
            {
                MessageBox.Show("Не введено имя папки!");
                return;
            }
            string targetPath = Path + TBFolder.Text;
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            TBFolder.Text = "";
            LoadFolder();
        }
        //
        // Открыть файл
        private void BOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                Process fl = new Process();
                fl.StartInfo.ErrorDialog = true;
                fl.StartInfo.FileName = Path + LBFolder.SelectedItem + "\\" + LBFile.SelectedItem;
                fl.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
        //
        // Закрытие формы
        private void FormDataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();            
        }
        //
        // Настройка таймера
        private void TSMExit_Click(object sender, EventArgs e)
        {
            T1.Enabled = true;
        }
        //
        // "Тикание" таймера
        private void T1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity <= 0)
            {
                Application.Exit();
            }
        }
        //
        // Удаление папки
        private void TSBDelFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить папку " + LBFolder.SelectedItem,
            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            //
            if (result == DialogResult.Yes)
            {
                System.IO.Directory.Delete(Path + LBFolder.SelectedItem, true);
                LoadFolder();
            }
            else
                MessageBox.Show("Отмена удаления данных");
        }
        //
        // Удаление файла
        private void TSBDelFile_Click(object sender, EventArgs e)
        {
            if (LBFile.Items.Count == 0)
            {
                MessageBox.Show("Файл не выбран!");
                return;
            }            
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить файл " + LBFile.SelectedItem,
            "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            //
            if (result == DialogResult.Yes)
            {
                System.IO.File.Delete(Path + LBFolder.SelectedItem + "\\" + LBFile.SelectedItem);
                LoadFolder();
            }
            else
                MessageBox.Show("Отмена удаления данных");
            
        }
        //
        // Окно настройки
        private void TSMOpt_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();            
        }
        //
        // Вызов справки
        private void TSMAboutProg_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();  
        }


    }
}
