using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

using NAudio.Wave;

namespace Audio
{
    public partial class Form1 : Form
    {
        IWavePlayer player = new WaveOut();
        AudioFileReader reader;
        int index;
        List<string> ListOfSong;

        bool panelButton = true;
        bool repeat = false;
        bool voice = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();


            if (player.PlaybackState == PlaybackState.Stopped)
            {
                listBoxPL_SelectedIndexChanged(sender, e);
                index = index == -1 ? index = 0 : index;
                string file = ListOfSong[index].ToString();
                reader = new AudioFileReader(file);
                player.Init(reader);
                player.Play();
                progressBarTimeOfSong.Maximum = (int)reader.TotalTime.TotalSeconds + 1;
                trackBarTimeOfSong.Maximum = (int)reader.TotalTime.TotalSeconds;
                label3.Text = reader.TotalTime.Minutes.ToString().PadLeft(2, '0') + ':' + reader.TotalTime.Seconds.ToString().PadLeft(2, '0');
                label1.Text = listBoxPL.Items[index].ToString();
            }
            else
            {
                if (player.PlaybackState == PlaybackState.Playing && index != -1)
                {
                    buttonStop_Click(sender, e);
                    buttonPlay_Click(sender, e);
                }
                if (player.PlaybackState == PlaybackState.Paused) { player.Play(); }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (player.PlaybackState == PlaybackState.Playing || player.PlaybackState == PlaybackState.Paused)
            {

                trackBarTimeOfSong.Value = 0;
                progressBarTimeOfSong.Value = 0;
                reader.CurrentTime = new TimeSpan(0, 0, 0);

                player.Stop();
                timer1.Stop();
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
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
                Clear();
                EnableButton(true);
                label4.Text = "";
                ListOfSong = new List<string>(OFD.FileNames);
                listBoxPL.Items.AddRange(OFD.FileNames);
                for (int i = 0; i < ListOfSong.Count; i++)
                {
                    listBoxPL.Items[i] = Path.GetFileName(ListOfSong[i]);
                }
            }
        }

        private void trackBarVol_Scroll(object sender, EventArgs e)
        {
            voice = false;
            player.Volume = trackBarVol.Value * 0.1f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (reader.TotalTime == reader.CurrentTime)
            {
                if (repeat == true)
                {
                    buttonPlay_Click(sender, e);
                    return;
                }
                buttonNext_Click(sender, e);
            }

            trackBarTimeOfSong.Value = (int)reader.CurrentTime.TotalSeconds;
            progressBarTimeOfSong.Value = trackBarTimeOfSong.Value + 1;
            progressBarTimeOfSong.Value = trackBarTimeOfSong.Value;
        }

        private void trackBarTimeOfSong_Scroll(object sender, EventArgs e)
        {

            timer1.Stop();
            int seconds = trackBarTimeOfSong.Value;
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

        private void trackBarTimeOfSong_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = reader.CurrentTime.Minutes.ToString().PadLeft(2, '0') + ':' + reader.CurrentTime.Seconds.ToString().PadLeft(2, '0');
        }

        private void buttonOpenPL_Click(object sender, EventArgs e)
        {
            if (panelButton == true)
            {
                panel1.Visible = true;
                panelButton = false;
                buttonOpenPL.Image = Properties.Resources.right;
            }
            else
            {
                panel1.Visible = false;
                panelButton = true;
                buttonOpenPL.Image = Properties.Resources.left;
            }

        }

        private void listBoxPL_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = listBoxPL.SelectedIndex;
        }

        private void buttonClearPL_Click(object sender, EventArgs e)
        {
            Clear();
            EnableButton(false);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            buttonStop_Click(sender, e);
            index--;
            index = index < 0 ? index = listBoxPL.Items.Count - 1 : index;
            listBoxPL.SelectedIndex = index;
            buttonPlay_Click(sender, e);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonStop_Click(sender, e);
            index++;
            index = index >= listBoxPL.Items.Count ? index = 0 : index;
            listBoxPL.SelectedIndex = index;
            buttonPlay_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var PL = listBoxPL.Items.Cast<string>().ToList();
            using (FileStream fs = new FileStream("settings.xml", FileMode.Create))
            {
                XmlSerializer xser = new XmlSerializer(typeof(List<string>));
                xser.Serialize(fs, PL);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream("settings.xml", FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(List<string>));
                    List<string> PL = (List<string>)xser.Deserialize(fs);
                    if (PL.Any())
                    {
                        label4.Text = "";
                        EnableButton(true);
                    }
                    listBoxPL.Items.AddRange(PL.ToArray());
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"Fail settings.xml' is not exist", "File not found", MessageBoxButtons.OK);
            }
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            if (repeat == false)
            {
                repeat = true;
                buttonRepeat.Image = Properties.Resources.RepeatRed;
            }
            else
            {
                repeat = false;
                buttonRepeat.Image = Properties.Resources.Repeat;
            }
        }

        private void EnableButton(bool flag)
        {
            trackBarTimeOfSong.Enabled = flag;
            buttonPlay.Enabled = flag;
            buttonStop.Enabled = flag;
            buttonPause.Enabled = flag;
            buttonClearPL.Enabled = flag;
            buttonPrev.Enabled = flag;
            buttonNext.Enabled = flag;
        }

        private void Clear()
        {
            label1.Text = "";
            label4.Text = "Выберите песню -> Открыть";
            listBoxPL.Items.Clear();
            progressBarTimeOfSong.Value = 0;
            trackBarVol.Value = 0;
            timer1.Stop();
            player.Stop();

        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            if (reader == null) { return; }
            if (voice == false)
            {
                voice = true;
                buttonOnOff.Image = Properties.Resources.mute;
                reader.Volume = 0;
            }
            else
            {
                voice = false;
                reader.Volume = 20;
                buttonOnOff.Image = Properties.Resources.max;
            }

        }
    }
}

