using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paraps_Collection
{
    [Serializable]
    public struct MARSH : IComparable
    {
        public string beginPoint
        {
            get;
            set;
        }
        public string endPoint;
        public int routeNumber;

        public int CompareTo(object obj)
        {
            var tmp = (MARSH)obj;
            if (this.routeNumber > tmp.routeNumber) return 1;
            if (this.routeNumber < tmp.routeNumber) return -1;
            return 0;
        }

        public override string ToString()
        {
            return string.Format(beginPoint + " " + endPoint + " " + routeNumber);
        }
    }

    public partial class Form1 : Form
    {
        List<MARSH> list;
        BinaryFormatter formatter;

        public Form1()
        {
            InitializeComponent();
            list = new List<MARSH>();
            formatter = new BinaryFormatter(); //иницилизация бинарной сериализации
        }

        private void button1_Click(object sender, EventArgs e) //добавление в лист
        {
            list.Add(new MARSH() { beginPoint = textBox1.Text, endPoint = textBox2.Text, routeNumber = int.Parse(textBox3.Text) }); 
        }

        private void button3_Click(object sender, EventArgs e)// отчистить поле вывода
        {
            textBox4.Clear();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) //сохранение данных
        {
            using (FileStream fs = new FileStream("Text.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
                MessageBox.Show("Сохранено!", "Сохранение...", MessageBoxButtons.OK);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e) //открыть ранее сох-ый файл
        {
            using (FileStream fs = new FileStream("Text.dat", FileMode.OpenOrCreate))
            {
                List<MARSH> newList = (List<MARSH>)formatter.Deserialize(fs);
                list.AddRange(newList);
                foreach (var item in list)
                {
                    textBox4.Text += item.ToString() + "\n";
                    textBox4.Text += new string('-', 83);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //удаление эл-та
        {
            if (list.Any())
            {
                list.RemoveAt(0);
            }
            else { MessageBox.Show("Список пуст!", "Уведомление", MessageBoxButtons.OK); }
        }

        private void button4_Click(object sender, EventArgs e)//сортировка
        {
            if (list.Any())
            { list.Sort(); }
            else { MessageBox.Show("Список пуст!", "Уведомление", MessageBoxButtons.OK); }
        }

        private void button5_Click(object sender, EventArgs e)//поиск по критерию
        {
            textBox4.Clear();

            var Match = list.FindAll(delegate (MARSH x) { return x.routeNumber == int.Parse(textBox5.Text); });
            foreach (var item in Match)
            {
                textBox4.Text += item.ToString() + "\n";
                textBox4.Text += new string('-', 83);
            }
        }

        private void button6_Click(object sender, EventArgs e)//вывод данных
        {
            textBox4.Clear();
            foreach (var i in list)
            {
                textBox4.Text += i.ToString();
                textBox4.Text += new string('-', 83);
            }
        }
    }
}
