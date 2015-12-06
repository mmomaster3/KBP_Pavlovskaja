using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_WindowsForm
{
    public partial class Form1 : Form
    {
        Color stnMenu;

        public Form1()
        {
            InitializeComponent();
            stnMenu = menuStrip1.BackColor;
        }

        private void inputColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = colorDialog1.Color;
            if (checkBox1.Checked == true)
                menuStrip1.BackColor = s;
            if (checkBox2.Checked == true)
                this.BackColor = s;
            toolStripStatusLabel1.Text = s.ToString();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = stnMenu;
            this.BackColor = Form.DefaultBackColor;
            toolStripStatusLabel1.Text = "";
        }
    }
}
