namespace courcework
{
    partial class RegisterStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStaffForm));
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_pswd = new System.Windows.Forms.TextBox();
            this.tb_fio = new System.Windows.Forms.TextBox();
            this.tb_post = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.b_reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DARIASULTANCA97;Integrated Security=SSPI;Initial C" +
    "atalog=MusicSalon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(114, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(123, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Post";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(125, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Register new staff";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(200, 77);
            this.tb_login.Margin = new System.Windows.Forms.Padding(5);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(215, 29);
            this.tb_login.TabIndex = 6;
            // 
            // tb_pswd
            // 
            this.tb_pswd.Location = new System.Drawing.Point(200, 116);
            this.tb_pswd.Margin = new System.Windows.Forms.Padding(5);
            this.tb_pswd.Name = "tb_pswd";
            this.tb_pswd.Size = new System.Drawing.Size(215, 29);
            this.tb_pswd.TabIndex = 7;
            // 
            // tb_fio
            // 
            this.tb_fio.Location = new System.Drawing.Point(200, 154);
            this.tb_fio.Margin = new System.Windows.Forms.Padding(5);
            this.tb_fio.Name = "tb_fio";
            this.tb_fio.Size = new System.Drawing.Size(215, 29);
            this.tb_fio.TabIndex = 8;
            // 
            // tb_post
            // 
            this.tb_post.Location = new System.Drawing.Point(200, 193);
            this.tb_post.Margin = new System.Windows.Forms.Padding(5);
            this.tb_post.Name = "tb_post";
            this.tb_post.Size = new System.Drawing.Size(215, 29);
            this.tb_post.TabIndex = 9;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(200, 234);
            this.tb_mail.Margin = new System.Windows.Forms.Padding(5);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(215, 29);
            this.tb_mail.TabIndex = 10;
            // 
            // b_reg
            // 
            this.b_reg.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_reg.Location = new System.Drawing.Point(286, 310);
            this.b_reg.Margin = new System.Windows.Forms.Padding(5);
            this.b_reg.Name = "b_reg";
            this.b_reg.Size = new System.Drawing.Size(129, 28);
            this.b_reg.TabIndex = 12;
            this.b_reg.Text = "Register";
            this.b_reg.UseVisualStyleBackColor = true;
            this.b_reg.Click += new System.EventHandler(this.b_reg_Click);
            // 
            // RegisterStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.b_reg);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_post);
            this.Controls.Add(this.tb_fio);
            this.Controls.Add(this.tb_pswd);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_pswd;
        private System.Windows.Forms.TextBox tb_fio;
        private System.Windows.Forms.TextBox tb_post;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Button b_reg;
    }
}