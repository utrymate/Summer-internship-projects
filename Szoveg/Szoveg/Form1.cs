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

namespace Szoveg
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog megnyit = new OpenFileDialog();
            megnyit.ShowDialog();
            textBox1.Text = megnyit.FileName;
            //using (StreamReader Olvas = new StreamReader(@"c:\users\ggv2mc\documents\visual studio 2015\Projects\Szoveg\Szoveg\szoveges.txt"))
            //{
            //    while (!Olvas.EndOfStream)
            //    {
            //        richTextBox1.AppendText(Olvas.ReadLine());
            //    }
            }

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    File.ReadAllText(openFileDialog1.FileName);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //using (StreamWriter Ir = new StreamWriter(@"c:\users\ggv2mc\documents\visual studio 2015\Projects\Szoveg\Szoveg\szoveges.txt"))
        //{
        //    Ir.WriteLine(richTextBox1.Text);
        //}
        StreamReader irok = new StreamReader(textBox1)

        }
    }