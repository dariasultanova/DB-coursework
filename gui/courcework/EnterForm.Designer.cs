namespace courcework
{
    partial class EnterToSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterToSystem));
            this.Nick = new System.Windows.Forms.TextBox();
            this.Pswd = new System.Windows.Forms.TextBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.b_Enter = new System.Windows.Forms.Button();
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_NewUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nick
            // 
            this.Nick.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nick.Location = new System.Drawing.Point(191, 90);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(187, 29);
            this.Nick.TabIndex = 0;
            // 
            // Pswd
            // 
            this.Pswd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pswd.Location = new System.Drawing.Point(191, 132);
            this.Pswd.Name = "Pswd";
            this.Pswd.Size = new System.Drawing.Size(187, 29);
            this.Pswd.TabIndex = 1;
            this.Pswd.UseSystemPasswordChar = true;
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DARIASULTANCA97;Integrated Security=SSPI;Initial C" +
    "atalog=MusicSalon";
            // 
            // b_Enter
            // 
            this.b_Enter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Enter.Location = new System.Drawing.Point(269, 192);
            this.b_Enter.Name = "b_Enter";
            this.b_Enter.Size = new System.Drawing.Size(109, 28);
            this.b_Enter.TabIndex = 2;
            this.b_Enter.Text = "Enter";
            this.b_Enter.UseVisualStyleBackColor = true;
            this.b_Enter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // cb_users
            // 
            this.cb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_users.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_users.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Items.AddRange(new object[] {
            "Client",
            "Staff",
            "Director"});
            this.cb_users.Location = new System.Drawing.Point(191, 48);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(187, 29);
            this.cb_users.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(114, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(85, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "User type";
            // 
            // b_NewUser
            // 
            this.b_NewUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_NewUser.Location = new System.Drawing.Point(286, 310);
            this.b_NewUser.Name = "b_NewUser";
            this.b_NewUser.Size = new System.Drawing.Size(129, 28);
            this.b_NewUser.TabIndex = 9;
            this.b_NewUser.Text = "Register";
            this.b_NewUser.UseVisualStyleBackColor = true;
            this.b_NewUser.Click += new System.EventHandler(this.b_NewUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 33);
            this.label4.TabIndex = 10;
            // 
            // EnterToSystem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(484, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_NewUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_users);
            this.Controls.Add(this.b_Enter);
            this.Controls.Add(this.Pswd);
            this.Controls.Add(this.Nick);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterToSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter to system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.TextBox Pswd;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button b_Enter;
        private System.Windows.Forms.ComboBox cb_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_NewUser;
        private System.Windows.Forms.Label label4;
    }
}

