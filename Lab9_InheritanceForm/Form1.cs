using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_InheritanceForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] colorName = Enum.GetNames(typeof(KnownColor));
            comboBox1.Items.AddRange(colorName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = CreateGraphics();
            formGraphics.Clear(Color.Gray);
            

            int x = Convert.ToInt32(textBoxX.Text != "" ? textBoxX.Text : null);
            int y = Convert.ToInt32(textBoxY.Text != "" ? textBoxY.Text : null);
            int z = Convert.ToInt32(textBoxZ.Text != "" ? textBoxY.Text : null);
            textBoxZ.Enabled = false;

            Color clr = Color.FromName((string)(comboBox1.SelectedItem != null ? comboBox1.SelectedItem : "Red"));

            ColorPoint clrpoint = new ColorPoint(x, clr);
            ColorLine clrline = new ColorLine(x, y, clr);
            PolyLine poly = new PolyLine(x, y, z);
            Pen Pen = new Pen(clrpoint.clr);
            if (textBoxY.Text != "")
            {
                formGraphics.DrawLine(Pen, clrpoint.X, clrpoint.X, clrline.Y, clrline.X);

                if (textBoxZ.Text != "")
                {
                    formGraphics.DrawLine(Pen, clrpoint.X, poly.Z, clrline.Y, poly.Z);
                    formGraphics.DrawLine(Pen, clrpoint.X, clrpoint.X, clrpoint.X, clrline.Y);
                    formGraphics.DrawLine(Pen, clrline.Y, clrpoint.X, clrline.Y, clrline.Y);
                }
            }
            else
            {
                formGraphics.DrawLine(Pen, clrpoint.X, 50, clrpoint.X + 1, 50);
            }
            Pen.Dispose();
            formGraphics.Dispose();
        }
    }
}
