namespace Audio
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarVol = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarTimeOfSong = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarTimeOfSong = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPL = new System.Windows.Forms.ListBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonClearPL = new System.Windows.Forms.Button();
            this.buttonOpenPL = new System.Windows.Forms.Button();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeOfSong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Location = new System.Drawing.Point(12, 167);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 45);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(133, 167);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 45);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(245, 167);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 45);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            this.OFD.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // trackBarVol
            // 
            this.trackBarVol.Location = new System.Drawing.Point(489, 167);
            this.trackBarVol.Name = "trackBarVol";
            this.trackBarVol.Size = new System.Drawing.Size(104, 45);
            this.trackBarVol.TabIndex = 4;
            this.trackBarVol.Scroll += new System.EventHandler(this.trackBarVol_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 15);
            this.label1.TabIndex = 5;
            // 
            // progressBarTimeOfSong
            // 
            this.progressBarTimeOfSong.Location = new System.Drawing.Point(12, 255);
            this.progressBarTimeOfSong.Name = "progressBarTimeOfSong";
            this.progressBarTimeOfSong.Size = new System.Drawing.Size(594, 23);
            this.progressBarTimeOfSong.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBarTimeOfSong
            // 
            this.trackBarTimeOfSong.Enabled = false;
            this.trackBarTimeOfSong.Location = new System.Drawing.Point(0, 233);
            this.trackBarTimeOfSong.Name = "trackBarTimeOfSong";
            this.trackBarTimeOfSong.Size = new System.Drawing.Size(613, 45);
            this.trackBarTimeOfSong.TabIndex = 7;
            this.trackBarTimeOfSong.Scroll += new System.EventHandler(this.trackBarTimeOfSong_Scroll);
            this.trackBarTimeOfSong.ValueChanged += new System.EventHandler(this.trackBarTimeOfSong_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listBoxPL);
            this.panel1.Location = new System.Drawing.Point(338, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 226);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(43, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Выберите песню -> Открыть";
            // 
            // listBoxPL
            // 
            this.listBoxPL.FormattingEnabled = true;
            this.listBoxPL.Location = new System.Drawing.Point(-2, -3);
            this.listBoxPL.Name = "listBoxPL";
            this.listBoxPL.Size = new System.Drawing.Size(249, 225);
            this.listBoxPL.TabIndex = 0;
            this.listBoxPL.SelectedIndexChanged += new System.EventHandler(this.listBoxPL_SelectedIndexChanged);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(68, 72);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 45);
            this.buttonPrev.TabIndex = 14;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(188, 72);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 45);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonClearPL
            // 
            this.buttonClearPL.Enabled = false;
            this.buttonClearPL.Image = global::Audio.Properties.Resources.blue;
            this.buttonClearPL.Location = new System.Drawing.Point(588, 189);
            this.buttonClearPL.Name = "buttonClearPL";
            this.buttonClearPL.Size = new System.Drawing.Size(25, 37);
            this.buttonClearPL.TabIndex = 13;
            this.buttonClearPL.UseVisualStyleBackColor = true;
            this.buttonClearPL.Click += new System.EventHandler(this.buttonClearPL_Click);
            // 
            // buttonOpenPL
            // 
            this.buttonOpenPL.Image = global::Audio.Properties.Resources.left;
            this.buttonOpenPL.Location = new System.Drawing.Point(588, 0);
            this.buttonOpenPL.Name = "buttonOpenPL";
            this.buttonOpenPL.Size = new System.Drawing.Size(25, 189);
            this.buttonOpenPL.TabIndex = 11;
            this.buttonOpenPL.UseVisualStyleBackColor = true;
            this.buttonOpenPL.Click += new System.EventHandler(this.buttonOpenPL_Click);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Image = global::Audio.Properties.Resources.Repeat;
            this.buttonRepeat.Location = new System.Drawing.Point(401, 162);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(34, 34);
            this.buttonRepeat.TabIndex = 16;
            this.buttonRepeat.UseVisualStyleBackColor = true;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Image = global::Audio.Properties.Resources.max;
            this.buttonOnOff.Location = new System.Drawing.Point(449, 162);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(34, 34);
            this.buttonOnOff.TabIndex = 17;
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 282);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonClearPL);
            this.Controls.Add(this.buttonOpenPL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarTimeOfSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarVol);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.trackBarTimeOfSong);
            this.Controls.Add(this.buttonRepeat);
            this.Controls.Add(this.buttonOnOff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Audio Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeOfSong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TrackBar trackBarVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarTimeOfSong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarTimeOfSong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenPL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxPL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClearPL;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Button buttonOnOff;
    }
}

