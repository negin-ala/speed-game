namespace WindowsFormsApplication26
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbface = new System.Windows.Forms.PictureBox();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblscore = new System.Windows.Forms.ToolStripLabel();
            this.lbltime = new System.Windows.Forms.ToolStripLabel();
            this.txtusscore = new System.Windows.Forms.ToolStripTextBox();
            this.timer30 = new System.Windows.Forms.Timer(this.components);
            this.pbgameover = new System.Windows.Forms.PictureBox();
            this.lblf5sound = new System.Windows.Forms.Label();
            this.lblf5level = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbface2 = new System.Windows.Forms.PictureBox();
            this.pbface3 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayerboom = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayergameover = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblf5username = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbface)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbface2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbface3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerboom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayergameover)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(655, 481);
            this.axWindowsMediaPlayer2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(209, 124);
            this.axWindowsMediaPlayer2.TabIndex = 3;
            this.axWindowsMediaPlayer2.Visible = false;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(909, 389);
            this.axWindowsMediaPlayer3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(171, 194);
            this.axWindowsMediaPlayer3.TabIndex = 4;
            this.axWindowsMediaPlayer3.Visible = false;
            // 
            // pbface
            // 
            this.pbface.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbface.Image = ((System.Drawing.Image)(resources.GetObject("pbface.Image")));
            this.pbface.Location = new System.Drawing.Point(2871, 145);
            this.pbface.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pbface.Name = "pbface";
            this.pbface.Size = new System.Drawing.Size(91, 91);
            this.pbface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbface.TabIndex = 5;
            this.pbface.TabStop = false;
            this.pbface.Visible = false;
            this.pbface.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbface_MouseClick_1);
            // 
            // timer5
            // 
            this.timer5.Interval = 500;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblscore,
            this.lbltime,
            this.txtusscore});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1924, 35);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblscore
            // 
            this.lblscore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 24);
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbltime.Image = ((System.Drawing.Image)(resources.GetObject("lbltime.Image")));
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(98, 32);
            this.lbltime.Text = "time : ";
            // 
            // txtusscore
            // 
            this.txtusscore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtusscore.Name = "txtusscore";
            this.txtusscore.Size = new System.Drawing.Size(138, 35);
            this.txtusscore.Text = "score :";
            // 
            // timer30
            // 
            this.timer30.Interval = 30000;
            this.timer30.Tick += new System.EventHandler(this.timer30_Tick);
            // 
            // pbgameover
            // 
            this.pbgameover.Image = ((System.Drawing.Image)(resources.GetObject("pbgameover.Image")));
            this.pbgameover.Location = new System.Drawing.Point(655, 223);
            this.pbgameover.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pbgameover.Name = "pbgameover";
            this.pbgameover.Size = new System.Drawing.Size(226, 223);
            this.pbgameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbgameover.TabIndex = 7;
            this.pbgameover.TabStop = false;
            this.pbgameover.Visible = false;
            // 
            // lblf5sound
            // 
            this.lblf5sound.AutoSize = true;
            this.lblf5sound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblf5sound.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf5sound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblf5sound.Location = new System.Drawing.Point(229, 0);
            this.lblf5sound.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblf5sound.Name = "lblf5sound";
            this.lblf5sound.Size = new System.Drawing.Size(103, 34);
            this.lblf5sound.TabIndex = 8;
            this.lblf5sound.Text = "label1";
            // 
            // lblf5level
            // 
            this.lblf5level.AutoSize = true;
            this.lblf5level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblf5level.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf5level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblf5level.Location = new System.Drawing.Point(361, 0);
            this.lblf5level.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblf5level.Name = "lblf5level";
            this.lblf5level.Size = new System.Drawing.Size(110, 34);
            this.lblf5level.TabIndex = 9;
            this.lblf5level.Text = "label2";
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbface2
            // 
            this.pbface2.Image = ((System.Drawing.Image)(resources.GetObject("pbface2.Image")));
            this.pbface2.Location = new System.Drawing.Point(2905, 364);
            this.pbface2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pbface2.Name = "pbface2";
            this.pbface2.Size = new System.Drawing.Size(75, 96);
            this.pbface2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbface2.TabIndex = 11;
            this.pbface2.TabStop = false;
            this.pbface2.Visible = false;
            this.pbface2.Click += new System.EventHandler(this.pbface2_Click);
            // 
            // pbface3
            // 
            this.pbface3.Image = ((System.Drawing.Image)(resources.GetObject("pbface3.Image")));
            this.pbface3.Location = new System.Drawing.Point(2905, 577);
            this.pbface3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.pbface3.Name = "pbface3";
            this.pbface3.Size = new System.Drawing.Size(103, 100);
            this.pbface3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbface3.TabIndex = 12;
            this.pbface3.TabStop = false;
            this.pbface3.Visible = false;
            this.pbface3.Click += new System.EventHandler(this.pbface3_Click);
            // 
            // axWindowsMediaPlayerboom
            // 
            this.axWindowsMediaPlayerboom.Enabled = true;
            this.axWindowsMediaPlayerboom.Location = new System.Drawing.Point(909, 247);
            this.axWindowsMediaPlayerboom.Name = "axWindowsMediaPlayerboom";
            this.axWindowsMediaPlayerboom.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerboom.OcxState")));
            this.axWindowsMediaPlayerboom.Size = new System.Drawing.Size(141, 115);
            this.axWindowsMediaPlayerboom.TabIndex = 13;
            this.axWindowsMediaPlayerboom.Visible = false;
            // 
            // axWindowsMediaPlayergameover
            // 
            this.axWindowsMediaPlayergameover.Enabled = true;
            this.axWindowsMediaPlayergameover.Location = new System.Drawing.Point(909, 104);
            this.axWindowsMediaPlayergameover.Name = "axWindowsMediaPlayergameover";
            this.axWindowsMediaPlayergameover.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayergameover.OcxState")));
            this.axWindowsMediaPlayergameover.Size = new System.Drawing.Size(123, 93);
            this.axWindowsMediaPlayergameover.TabIndex = 14;
            this.axWindowsMediaPlayergameover.Visible = false;
            // 
            // lblf5username
            // 
            this.lblf5username.AutoSize = true;
            this.lblf5username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblf5username.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf5username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblf5username.Location = new System.Drawing.Point(516, 0);
            this.lblf5username.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblf5username.Name = "lblf5username";
            this.lblf5username.Size = new System.Drawing.Size(110, 34);
            this.lblf5username.TabIndex = 9;
            this.lblf5username.Text = "label2";
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.axWindowsMediaPlayergameover);
            this.Controls.Add(this.axWindowsMediaPlayerboom);
            this.Controls.Add(this.pbface3);
            this.Controls.Add(this.pbface2);
            this.Controls.Add(this.lblf5username);
            this.Controls.Add(this.lblf5level);
            this.Controls.Add(this.lblf5sound);
            this.Controls.Add(this.pbgameover);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pbface);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbface)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbgameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbface2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbface3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerboom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayergameover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.PictureBox pbface;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblscore;
        private System.Windows.Forms.ToolStripLabel lbltime;
        private System.Windows.Forms.Timer timer30;
        private System.Windows.Forms.PictureBox pbgameover;
        private System.Windows.Forms.Label lblf5sound;
        private System.Windows.Forms.Label lblf5level;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbface2;
        private System.Windows.Forms.PictureBox pbface3;
        private System.Windows.Forms.ToolStripTextBox txtusscore;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerboom;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayergameover;
        private System.Windows.Forms.Label lblf5username;
        private System.Windows.Forms.Timer countdown;
    }
}