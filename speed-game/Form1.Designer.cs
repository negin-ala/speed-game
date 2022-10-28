namespace WindowsFormsApplication26
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exictingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblsound = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbllevel = new System.Windows.Forms.Label();
            this.lblf1score = new System.Windows.Forms.Label();
            this.tblusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdatabaseDataSet = new WindowsFormsApplication26.usersdatabaseDataSet();
            this.tblusersTableAdapter = new WindowsFormsApplication26.usersdatabaseDataSetTableAdapters.tblusersTableAdapter();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblbcurBscore = new System.Windows.Forms.Label();
            this.lblMcurscore = new System.Windows.Forms.Label();
            this.lblUcurscore = new System.Windows.Forms.Label();
            this.lblgauid = new System.Windows.Forms.Label();
            this.lblshowname = new System.Windows.Forms.Label();
            this.lblshowid = new System.Windows.Forms.Label();
            this.lblshowscore = new System.Windows.Forms.Label();
            this.lblshowlevel = new System.Windows.Forms.Label();
            this.lblshowsound = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1388, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.exictingUserToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gameToolStripMenuItem.Image")));
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.newUserToolStripMenuItem.Text = "New user";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // exictingUserToolStripMenuItem
            // 
            this.exictingUserToolStripMenuItem.Name = "exictingUserToolStripMenuItem";
            this.exictingUserToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.exictingUserToolStripMenuItem.Text = "Existing user";
            this.exictingUserToolStripMenuItem.Click += new System.EventHandler(this.exictingUserToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(260, 371);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(123, 168);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // lblsound
            // 
            this.lblsound.AutoSize = true;
            this.lblsound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblsound.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblsound.Location = new System.Drawing.Point(1235, 164);
            this.lblsound.Name = "lblsound";
            this.lblsound.Size = new System.Drawing.Size(87, 27);
            this.lblsound.TabIndex = 4;
            this.lblsound.Text = "sound";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Ravie", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(556, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(627, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 137);
            this.button1.TabIndex = 6;
            this.button1.Text = "Let\'s strat the game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbllevel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbllevel.Location = new System.Drawing.Point(1235, 108);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(139, 27);
            this.lbllevel.TabIndex = 7;
            this.lbllevel.Text = "user level";
            // 
            // lblf1score
            // 
            this.lblf1score.AutoSize = true;
            this.lblf1score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblf1score.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf1score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblf1score.Location = new System.Drawing.Point(298, 258);
            this.lblf1score.Name = "lblf1score";
            this.lblf1score.Size = new System.Drawing.Size(153, 27);
            this.lblf1score.TabIndex = 8;
            this.lblf1score.Text = "user score";
            // 
            // tblusersBindingSource
            // 
            this.tblusersBindingSource.DataMember = "tblusers";
            this.tblusersBindingSource.DataSource = this.usersdatabaseDataSet;
            // 
            // usersdatabaseDataSet
            // 
            this.usersdatabaseDataSet.DataSetName = "usersdatabaseDataSet";
            this.usersdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblusersTableAdapter
            // 
            this.tblusersTableAdapter.ClearBeforeFill = true;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblusername.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblusername.Location = new System.Drawing.Point(301, 119);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(150, 27);
            this.lblusername.TabIndex = 9;
            this.lblusername.Text = "user name";
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbluserid.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbluserid.Location = new System.Drawing.Point(301, 194);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(37, 27);
            this.lbluserid.TabIndex = 10;
            this.lbluserid.Text = "id";
            // 
            // lblbcurBscore
            // 
            this.lblbcurBscore.AutoSize = true;
            this.lblbcurBscore.Location = new System.Drawing.Point(1043, 224);
            this.lblbcurBscore.Name = "lblbcurBscore";
            this.lblbcurBscore.Size = new System.Drawing.Size(46, 17);
            this.lblbcurBscore.TabIndex = 11;
            this.lblbcurBscore.Text = "label2";
            this.lblbcurBscore.Visible = false;
            // 
            // lblMcurscore
            // 
            this.lblMcurscore.AutoSize = true;
            this.lblMcurscore.Location = new System.Drawing.Point(1043, 258);
            this.lblMcurscore.Name = "lblMcurscore";
            this.lblMcurscore.Size = new System.Drawing.Size(46, 17);
            this.lblMcurscore.TabIndex = 11;
            this.lblMcurscore.Text = "label2";
            this.lblMcurscore.Visible = false;
            // 
            // lblUcurscore
            // 
            this.lblUcurscore.AutoSize = true;
            this.lblUcurscore.Location = new System.Drawing.Point(1043, 292);
            this.lblUcurscore.Name = "lblUcurscore";
            this.lblUcurscore.Size = new System.Drawing.Size(46, 17);
            this.lblUcurscore.TabIndex = 11;
            this.lblUcurscore.Text = "label2";
            this.lblUcurscore.Visible = false;
            // 
            // lblgauid
            // 
            this.lblgauid.AutoSize = true;
            this.lblgauid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblgauid.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgauid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblgauid.Location = new System.Drawing.Point(486, 164);
            this.lblgauid.Name = "lblgauid";
            this.lblgauid.Size = new System.Drawing.Size(508, 26);
            this.lblgauid.TabIndex = 12;
            this.lblgauid.Text = "please select your level and user first";
            // 
            // lblshowname
            // 
            this.lblshowname.AutoSize = true;
            this.lblshowname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblshowname.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblshowname.Location = new System.Drawing.Point(62, 119);
            this.lblshowname.Name = "lblshowname";
            this.lblshowname.Size = new System.Drawing.Size(168, 27);
            this.lblshowname.TabIndex = 9;
            this.lblshowname.Text = "chosen user";
            // 
            // lblshowid
            // 
            this.lblshowid.AutoSize = true;
            this.lblshowid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblshowid.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblshowid.Location = new System.Drawing.Point(62, 194);
            this.lblshowid.Name = "lblshowid";
            this.lblshowid.Size = new System.Drawing.Size(201, 27);
            this.lblshowid.TabIndex = 10;
            this.lblshowid.Text = "chosen user id";
            // 
            // lblshowscore
            // 
            this.lblshowscore.AutoSize = true;
            this.lblshowscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblshowscore.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowscore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblshowscore.Location = new System.Drawing.Point(62, 258);
            this.lblshowscore.Name = "lblshowscore";
            this.lblshowscore.Size = new System.Drawing.Size(153, 27);
            this.lblshowscore.TabIndex = 8;
            this.lblshowscore.Text = "user score";
            // 
            // lblshowlevel
            // 
            this.lblshowlevel.AutoSize = true;
            this.lblshowlevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblshowlevel.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowlevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblshowlevel.Location = new System.Drawing.Point(1071, 108);
            this.lblshowlevel.Name = "lblshowlevel";
            this.lblshowlevel.Size = new System.Drawing.Size(139, 27);
            this.lblshowlevel.TabIndex = 7;
            this.lblshowlevel.Text = "user level";
            // 
            // lblshowsound
            // 
            this.lblshowsound.AutoSize = true;
            this.lblshowsound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblshowsound.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowsound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblshowsound.Location = new System.Drawing.Point(1071, 160);
            this.lblshowsound.Name = "lblshowsound";
            this.lblshowsound.Size = new System.Drawing.Size(87, 27);
            this.lblshowsound.TabIndex = 7;
            this.lblshowsound.Text = "sound";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1388, 728);
            this.Controls.Add(this.lblgauid);
            this.Controls.Add(this.lblUcurscore);
            this.Controls.Add(this.lblMcurscore);
            this.Controls.Add(this.lblbcurBscore);
            this.Controls.Add(this.lblshowid);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.lblshowname);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblshowscore);
            this.Controls.Add(this.lblf1score);
            this.Controls.Add(this.lblshowsound);
            this.Controls.Add(this.lblshowlevel);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsound);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exictingUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblsound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Label lblf1score;
        private usersdatabaseDataSet usersdatabaseDataSet;
        private System.Windows.Forms.BindingSource tblusersBindingSource;
        private usersdatabaseDataSetTableAdapters.tblusersTableAdapter tblusersTableAdapter;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label lblbcurBscore;
        private System.Windows.Forms.Label lblMcurscore;
        private System.Windows.Forms.Label lblUcurscore;
        private System.Windows.Forms.Label lblgauid;
        private System.Windows.Forms.Label lblshowname;
        private System.Windows.Forms.Label lblshowid;
        private System.Windows.Forms.Label lblshowscore;
        private System.Windows.Forms.Label lblshowlevel;
        private System.Windows.Forms.Label lblshowsound;
    }
}

