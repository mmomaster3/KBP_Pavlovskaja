using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Thash_device
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxOutput.ScrollBars = ScrollBars.Both;
            textBoxOutput.WordWrap = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo[] info = DriveInfo.GetDrives();
            

            foreach (var item in info)
            {
                textBoxOutput.Text += item.Name + " " + item.DriveType + Environment.NewLine;
            }
        }
    }
}
