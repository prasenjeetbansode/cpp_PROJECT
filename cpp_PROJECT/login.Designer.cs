namespace cpp_PROJECT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usrnme_lbl = new System.Windows.Forms.Label();
            this.usrnme_txt = new System.Windows.Forms.TextBox();
            this.psswrd_txt = new System.Windows.Forms.TextBox();
            this.Pswrd_lbl = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.newusr_llbl = new System.Windows.Forms.LinkLabel();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usrnme_lbl
            // 
            this.usrnme_lbl.AutoSize = true;
            this.usrnme_lbl.Location = new System.Drawing.Point(47, 43);
            this.usrnme_lbl.Name = "usrnme_lbl";
            this.usrnme_lbl.Size = new System.Drawing.Size(68, 13);
            this.usrnme_lbl.TabIndex = 0;
            this.usrnme_lbl.Text = "USERNAME";
            // 
            // usrnme_txt
            // 
            this.usrnme_txt.BackColor = System.Drawing.SystemColors.Info;
            this.usrnme_txt.Location = new System.Drawing.Point(50, 69);
            this.usrnme_txt.Name = "usrnme_txt";
            this.usrnme_txt.Size = new System.Drawing.Size(119, 20);
            this.usrnme_txt.TabIndex = 1;
            // 
            // psswrd_txt
            // 
            this.psswrd_txt.Location = new System.Drawing.Point(50, 133);
            this.psswrd_txt.Name = "psswrd_txt";
            this.psswrd_txt.PasswordChar = '•';
            this.psswrd_txt.Size = new System.Drawing.Size(119, 20);
            this.psswrd_txt.TabIndex = 3;
            // 
            // Pswrd_lbl
            // 
            this.Pswrd_lbl.AutoSize = true;
            this.Pswrd_lbl.Location = new System.Drawing.Point(47, 107);
            this.Pswrd_lbl.Name = "Pswrd_lbl";
            this.Pswrd_lbl.Size = new System.Drawing.Size(70, 13);
            this.Pswrd_lbl.TabIndex = 2;
            this.Pswrd_lbl.Text = "PASSWORD";
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(88, 178);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(81, 39);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "LOGIN";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // newusr_llbl
            // 
            this.newusr_llbl.AutoSize = true;
            this.newusr_llbl.Location = new System.Drawing.Point(13, 245);
            this.newusr_llbl.Name = "newusr_llbl";
            this.newusr_llbl.Size = new System.Drawing.Size(66, 13);
            this.newusr_llbl.TabIndex = 6;
            this.newusr_llbl.TabStop = true;
            this.newusr_llbl.Text = "NEW USER";
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(204, 178);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(81, 39);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "CLOSE";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(485, 338);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.newusr_llbl);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.psswrd_txt);
            this.Controls.Add(this.Pswrd_lbl);
            this.Controls.Add(this.usrnme_txt);
            this.Controls.Add(this.usrnme_lbl);
            this.Name = "Login";
            this.Text = "LOGIN FORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrnme_lbl;
        private System.Windows.Forms.TextBox usrnme_txt;
        private System.Windows.Forms.TextBox psswrd_txt;
        private System.Windows.Forms.Label Pswrd_lbl;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.LinkLabel newusr_llbl;
        private System.Windows.Forms.Button close_btn;
    }
}