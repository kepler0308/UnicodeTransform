using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "E:\\Test\\C#\\test.c";

            string content = File.ReadAllText(path,Encoding.Default);

            textBox1.Text = content;

            File.WriteAllText(path,content,Encoding.ASCII);
        }
    }
}
