namespace cpp_PROJECT
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.Reg_btn = new System.Windows.Forms.Button();
            this.Area_btn = new System.Windows.Forms.Button();
            this.srh_btn = new System.Windows.Forms.Button();
            this.Rpt_btn = new System.Windows.Forms.Button();
            this.Cntct_btn = new System.Windows.Forms.Button();
            this.panel_reg = new System.Windows.Forms.Panel();
            this.panel_area = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.areaCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aITUCDataSet = new cpp_PROJECT.AITUCDataSet();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_no = new System.Windows.Forms.Label();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_search = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.areaTableAdapter = new cpp_PROJECT.AITUCDataSetTableAdapters.AreaTableAdapter();
            this.aitucDataSet1 = new cpp_PROJECT.AITUCDataSet();
            this.registrationTableAdapter = new cpp_PROJECT.AITUCDataSetTableAdapters.RegistrationTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_reg.SuspendLayout();
            this.panel_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aITUCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            this.panel_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aitucDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reg_btn
            // 
            this.Reg_btn.Location = new System.Drawing.Point(16, 10);
            this.Reg_btn.Name = "Reg_btn";
            this.Reg_btn.Size = new System.Drawing.Size(100, 34);
            this.Reg_btn.TabIndex = 0;
            this.Reg_btn.Text = "REGISTRATION";
            this.Reg_btn.UseVisualStyleBackColor = true;
            this.Reg_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Area_btn
            // 
            this.Area_btn.Location = new System.Drawing.Point(123, 10);
            this.Area_btn.Name = "Area_btn";
            this.Area_btn.Size = new System.Drawing.Size(100, 34);
            this.Area_btn.TabIndex = 1;
            this.Area_btn.Text = "AREA";
            this.Area_btn.UseVisualStyleBackColor = true;
            this.Area_btn.Click += new System.EventHandler(this.Area_btn_Click);
            // 
            // srh_btn
            // 
            this.srh_btn.Location = new System.Drawing.Point(228, 10);
            this.srh_btn.Name = "srh_btn";
            this.srh_btn.Size = new System.Drawing.Size(100, 34);
            this.srh_btn.TabIndex = 2;
            this.srh_btn.Text = "SEARCH";
            this.srh_btn.UseVisualStyleBackColor = true;
            this.srh_btn.Click += new System.EventHandler(this.srh_btn_Click);
            // 
            // Rpt_btn
            // 
            this.Rpt_btn.Location = new System.Drawing.Point(334, 10);
            this.Rpt_btn.Name = "Rpt_btn";
            this.Rpt_btn.Size = new System.Drawing.Size(100, 34);
            this.Rpt_btn.TabIndex = 3;
            this.Rpt_btn.Text = "REPORT";
            this.Rpt_btn.UseVisualStyleBackColor = true;
            this.Rpt_btn.Click += new System.EventHandler(this.Rpt_btn_Click);
            // 
            // Cntct_btn
            // 
            this.Cntct_btn.Location = new System.Drawing.Point(440, 10);
            this.Cntct_btn.Name = "Cntct_btn";
            this.Cntct_btn.Size = new System.Drawing.Size(100, 34);
            this.Cntct_btn.TabIndex = 4;
            this.Cntct_btn.Text = "CONTACT";
            this.Cntct_btn.UseVisualStyleBackColor = true;
            this.Cntct_btn.Click += new System.EventHandler(this.Cntct_btn_Click);
            // 
            // panel_reg
            // 
            this.panel_reg.BackColor = System.Drawing.Color.LightCoral;
            this.panel_reg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_reg.Controls.Add(this.panel_area);
            this.panel_reg.Controls.Add(this.label3);
            this.panel_reg.Controls.Add(this.button1);
            this.panel_reg.Controls.Add(this.pictureBox1);
            this.panel_reg.Controls.Add(this.reset_btn);
            this.panel_reg.Controls.Add(this.submit_btn);
            this.panel_reg.Controls.Add(this.textBox6);
            this.panel_reg.Controls.Add(this.label7);
            this.panel_reg.Controls.Add(this.textBox5);
            this.panel_reg.Controls.Add(this.label6);
            this.panel_reg.Controls.Add(this.textBox4);
            this.panel_reg.Controls.Add(this.label5);
            this.panel_reg.Controls.Add(this.textBox3);
            this.panel_reg.Controls.Add(this.lbl_no);
            this.panel_reg.Controls.Add(this.date_txt);
            this.panel_reg.Controls.Add(this.label4);
            this.panel_reg.Controls.Add(this.richTextBox1);
            this.panel_reg.Controls.Add(this.textBox2);
            this.panel_reg.Controls.Add(this.textBox1);
            this.panel_reg.Controls.Add(this.label2);
            this.panel_reg.Controls.Add(this.label1);
            this.panel_reg.Location = new System.Drawing.Point(32, 103);
            this.panel_reg.Name = "panel_reg";
            this.panel_reg.Size = new System.Drawing.Size(514, 346);
            this.panel_reg.TabIndex = 5;
            this.panel_reg.Visible = false;
            // 
            // panel_area
            // 
            this.panel_area.Controls.Add(this.dataGridView1);
            this.panel_area.Controls.Add(this.textBox8);
            this.panel_area.Controls.Add(this.textBox7);
            this.panel_area.Controls.Add(this.label9);
            this.panel_area.Controls.Add(this.label8);
            this.panel_area.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_area.Location = new System.Drawing.Point(0, 0);
            this.panel_area.Name = "panel_area";
            this.panel_area.Size = new System.Drawing.Size(514, 349);
            this.panel_area.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaCodeDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.areaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(175, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 246);
            this.dataGridView1.TabIndex = 8;
            // 
            // areaCodeDataGridViewTextBoxColumn
            // 
            this.areaCodeDataGridViewTextBoxColumn.DataPropertyName = "AreaCode";
            this.areaCodeDataGridViewTextBoxColumn.HeaderText = "AreaCode";
            this.areaCodeDataGridViewTextBoxColumn.Name = "areaCodeDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.aITUCDataSet;
            // 
            // aITUCDataSet
            // 
            this.aITUCDataSet.DataSetName = "AITUCDataSet";
            this.aITUCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(318, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(154, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "areaCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add Photo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(121, 317);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 13;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(16, 317);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 12;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "WorkDescription", true));
            this.textBox6.Location = new System.Drawing.Point(97, 272);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataMember = "Registration";
            this.registrationBindingSource.DataSource = this.aITUCDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "work:.";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "WorkDescription", true));
            this.textBox5.Location = new System.Drawing.Point(97, 239);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(69, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Work expirience:.";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Mobile", true));
            this.textBox4.Location = new System.Drawing.Point(97, 213);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Education:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Mobile", true));
            this.textBox3.Location = new System.Drawing.Point(97, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 20);
            this.textBox3.TabIndex = 9;
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Location = new System.Drawing.Point(1, 190);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(61, 13);
            this.lbl_no.TabIndex = 8;
            this.lbl_no.Text = "Mobile No:.";
            // 
            // date_txt
            // 
            this.date_txt.Enabled = false;
            this.date_txt.Location = new System.Drawing.Point(342, 28);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(100, 20);
            this.date_txt.TabIndex = 7;
            this.date_txt.Text = "t";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "Address", true));
            this.richTextBox1.Location = new System.Drawing.Point(95, 83);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(173, 101);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "MemberName", true));
            this.textBox2.Location = new System.Drawing.Point(95, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registrationBindingSource, "RegID", true));
            this.textBox1.Location = new System.Drawing.Point(95, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RegNo:.";
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.LightCoral;
            this.panel_search.Controls.Add(this.search_btn);
            this.panel_search.Controls.Add(this.dataGridView2);
            this.panel_search.Controls.Add(this.label10);
            this.panel_search.Controls.Add(this.textBox9);
            this.panel_search.Location = new System.Drawing.Point(32, 106);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(514, 346);
            this.panel_search.TabIndex = 4;
            this.panel_search.Visible = false;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(281, 30);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 238);
            this.dataGridView2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "search";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(126, 31);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(140, 20);
            this.textBox9.TabIndex = 0;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // aitucDataSet1
            // 
            this.aitucDataSet1.DataSetName = "AITUCDataSet";
            this.aitucDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationTableAdapter
            // 
            this.registrationTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(795, 490);
            this.Controls.Add(this.panel_reg);
            this.Controls.Add(this.Cntct_btn);
            this.Controls.Add(this.Rpt_btn);
            this.Controls.Add(this.srh_btn);
            this.Controls.Add(this.Area_btn);
            this.Controls.Add(this.Reg_btn);
            this.Controls.Add(this.panel_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.Text = "AITUC";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel_reg.ResumeLayout(false);
            this.panel_reg.PerformLayout();
            this.panel_area.ResumeLayout(false);
            this.panel_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aITUCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aitucDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reg_btn;
        private System.Windows.Forms.Button Area_btn;
        private System.Windows.Forms.Button srh_btn;
        private System.Windows.Forms.Button Rpt_btn;
        private System.Windows.Forms.Button Cntct_btn;
        private System.Windows.Forms.Panel panel_reg;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private AITUCDataSet aITUCDataSet;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private AITUCDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button search_btn;
        private AITUCDataSet aitucDataSet1;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private AITUCDataSetTableAdapters.RegistrationTableAdapter registrationTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_area;
    }
}

