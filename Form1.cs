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

namespace Class2_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true
            };

            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
                _ = fbd.RootFolder;
            }
            //try
            //{
            //    listBox1.Items.Clear();
            //    DirectoryInfo dir = new DirectoryInfo($@"C:\Users\adair\OneDrive\Desktop\castGroup\CSharp-Intermediario\Ex\{textBox1.Text}");

            //    FileInfo[] files = dir.GetFiles();

            //    foreach (var f in files)
            //    {
            //        listBox1.Items.Add(f);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Pasta não encontrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile($@"{textBox1.Text}\{listBox1.Text}");
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo($@"{textBox1.Text}");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo f in files)
            {
                listBox1.Items.Add(f);
            }
        }
    }
}
