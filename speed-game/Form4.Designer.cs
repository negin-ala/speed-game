namespace WindowsFormsApplication26
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beginnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblusersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersdatabaseDataSet = new WindowsFormsApplication26.usersdatabaseDataSet();
            this.tblusersTableAdapter = new WindowsFormsApplication26.usersdatabaseDataSetTableAdapters.tblusersTableAdapter();
            this.btnf4okay = new System.Windows.Forms.Button();
            this.tblusersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btndel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gold;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.beginnerDataGridViewTextBoxColumn,
            this.masterDataGridViewTextBoxColumn,
            this.ultimateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblusersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(172, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // beginnerDataGridViewTextBoxColumn
            // 
            this.beginnerDataGridViewTextBoxColumn.DataPropertyName = "Beginner";
            this.beginnerDataGridViewTextBoxColumn.HeaderText = "Beginner";
            this.beginnerDataGridViewTextBoxColumn.Name = "beginnerDataGridViewTextBoxColumn";
            // 
            // masterDataGridViewTextBoxColumn
            // 
            this.masterDataGridViewTextBoxColumn.DataPropertyName = "Master";
            this.masterDataGridViewTextBoxColumn.HeaderText = "Master";
            this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
            // 
            // ultimateDataGridViewTextBoxColumn
            // 
            this.ultimateDataGridViewTextBoxColumn.DataPropertyName = "Ultimate";
            this.ultimateDataGridViewTextBoxColumn.HeaderText = "Ultimate";
            this.ultimateDataGridViewTextBoxColumn.Name = "ultimateDataGridViewTextBoxColumn";
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
            // btnf4okay
            // 
            this.btnf4okay.BackColor = System.Drawing.Color.Red;
            this.btnf4okay.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnf4okay.ForeColor = System.Drawing.Color.Yellow;
            this.btnf4okay.Location = new System.Drawing.Point(549, 459);
            this.btnf4okay.Name = "btnf4okay";
            this.btnf4okay.Size = new System.Drawing.Size(175, 79);
            this.btnf4okay.TabIndex = 1;
            this.btnf4okay.Text = "okay";
            this.btnf4okay.UseVisualStyleBackColor = false;
            this.btnf4okay.Click += new System.EventHandler(this.btnf4okay_Click);
            // 
            // tblusersBindingSource1
            // 
            this.tblusersBindingSource1.DataMember = "tblusers";
            this.tblusersBindingSource1.DataSource = this.usersdatabaseDataSet;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(122, 238);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Gold;
            this.btndel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Red;
            this.btndel.Location = new System.Drawing.Point(1144, 213);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(150, 91);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Delete user";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1304, 790);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnf4okay);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private usersdatabaseDataSet usersdatabaseDataSet;
        private System.Windows.Forms.BindingSource tblusersBindingSource;
        private usersdatabaseDataSetTableAdapters.tblusersTableAdapter tblusersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnf4okay;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource tblusersBindingSource1;
        private System.Windows.Forms.Button btndel;
    }
}