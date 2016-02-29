using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Runtime.InteropServices;

namespace Audio
{
    public partial class Form1 : Form
    {
        IWavePlayer player = new WaveOut();
        static string file;
        AudioFileReader reader;

        bool click = true;
        int w1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                if (player.PlaybackState == PlaybackState.Stopped)
                {
                    player.Init(reader);
                    player.Play();
                }
                else
                {
                    if (player.PlaybackState == PlaybackState.Paused) { player.Play(); }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());                               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
            timer1.Stop();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Pause();
            timer1.Stop();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OFD.FileName = "";
            OFD.Title = "Выберите файл с музыкой";
            OFD.Filter = "Файл .mp3 | *.mp3";
            if (OFD.ShowDialog() == DialogResult.OK)
            {               
                listBox1.Items.AddRange(OFD.FileNames);
                file = listBox1.Items[0].ToString();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            player.Volume = trackBar1.Value * 0.1f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar2.Value = (int)reader.CurrentTime.TotalSeconds;
            progressBar1.Value = trackBar2.Value + 2;
            progressBar1.Value = trackBar2.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            int seconds = trackBar2.Value;
            int hours = (int)seconds / 3600;
            seconds %= 3600;
            int minutes = seconds / 60;
            seconds %= 60;
            TimeSpan time = new TimeSpan(hours, minutes, seconds);
            reader.CurrentTime = time;
            //if (trackBar2.Value > reader.CurrentTime.TotalSeconds)
            //{ reader.Seek(trackBar1.Value); }
            //else { reader.Seek(-1); }
            timer1.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                reader.Volume = 0;
            }
            else { reader.Volume = 20; }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = reader.CurrentTime.Minutes.ToString().PadLeft(2, '0') + ':' + reader.CurrentTime.Seconds.ToString().PadLeft(2,'0');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click == true)
            {
                panel1.Visible = true;
                click = false;
                button4.Image = Properties.Resources.control_right;
            }
            else
            {
                panel1.Visible = false;
                click = true;
                button4.Image = Properties.Resources.control_left;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            file = listBox1.SelectedIndex.ToString();
            reader = new AudioFileReader(file);
            progressBar1.Maximum = (int)reader.TotalTime.TotalSeconds;
            trackBar2.Maximum = (int)reader.TotalTime.TotalSeconds;
            label3.Text = reader.TotalTime.Minutes.ToString().PadLeft(2, '0') + ':' + reader.TotalTime.Seconds.ToString().PadLeft(2, '0');
        }
    }
}

