using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//
//
namespace PROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //
        // Переменные
        string SourceFile = "source.txt";
        string Path;
        //
        // Загрузка адреса
        private void Form2_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(SourceFile))
            Path = sr.ReadLine();
            TBPath.Text = Path;
        }
        //
        // Изменение адреса
        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter outfile =
            new StreamWriter(SourceFile))
            {
                outfile.Write(TBPath.Text);
            }
            this.Close();
        }
    }
}
