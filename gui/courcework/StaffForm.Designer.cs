namespace courcework
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.tc = new System.Windows.Forms.TabControl();
            this.tp_1 = new System.Windows.Forms.TabPage();
            this.dgv_schedule = new System.Windows.Forms.DataGridView();
            this.b_graphic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_PeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_PeriodTo = new System.Windows.Forms.DateTimePicker();
            this.tp_2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.tp_3 = new System.Windows.Forms.TabPage();
            this.b_report = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.ds_sch = new System.Data.DataSet();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.ds_clients = new System.Data.DataSet();
            this.tc.SuspendLayout();
            this.tp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).BeginInit();
            this.tp_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.tp_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp_1);
            this.tc.Controls.Add(this.tp_2);
            this.tc.Controls.Add(this.tp_3);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(667, 410);
            this.tc.TabIndex = 0;
            // 
            // tp_1
            // 
            this.tp_1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_1.Controls.Add(this.dgv_schedule);
            this.tp_1.Controls.Add(this.b_graphic);
            this.tp_1.Controls.Add(this.label3);
            this.tp_1.Controls.Add(this.label2);
            this.tp_1.Controls.Add(this.dtp_PeriodFrom);
            this.tp_1.Controls.Add(this.dtp_PeriodTo);
            this.tp_1.Location = new System.Drawing.Point(4, 28);
            this.tp_1.Name = "tp_1";
            this.tp_1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tp_1.Size = new System.Drawing.Size(659, 378);
            this.tp_1.TabIndex = 0;
            this.tp_1.Text = "Schedule";
            // 
            // dgv_schedule
            // 
            this.dgv_schedule.BackgroundColor = System.Drawing.Color.White;
            this.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_schedule.Location = new System.Drawing.Point(8, 76);
            this.dgv_schedule.Name = "dgv_schedule";
            this.dgv_schedule.RowTemplate.Height = 24;
            this.dgv_schedule.Size = new System.Drawing.Size(641, 275);
            this.dgv_schedule.TabIndex = 6;
            // 
            // b_graphic
            // 
            this.b_graphic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_graphic.Location = new System.Drawing.Point(542, 17);
            this.b_graphic.Name = "b_graphic";
            this.b_graphic.Size = new System.Drawing.Size(107, 28);
            this.b_graphic.TabIndex = 5;
            this.b_graphic.Text = "Show";
            this.b_graphic.UseVisualStyleBackColor = true;
            this.b_graphic.Click += new System.EventHandler(this.b_graphic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // dtp_PeriodFrom
            // 
            this.dtp_PeriodFrom.Location = new System.Drawing.Point(91, 19);
            this.dtp_PeriodFrom.Name = "dtp_PeriodFrom";
            this.dtp_PeriodFrom.Size = new System.Drawing.Size(177, 26);
            this.dtp_PeriodFrom.TabIndex = 2;
            // 
            // dtp_PeriodTo
            // 
            this.dtp_PeriodTo.Location = new System.Drawing.Point(341, 19);
            this.dtp_PeriodTo.Name = "dtp_PeriodTo";
            this.dtp_PeriodTo.Size = new System.Drawing.Size(177, 26);
            this.dtp_PeriodTo.TabIndex = 1;
            // 
            // tp_2
            // 
            this.tp_2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_2.Controls.Add(this.label4);
            this.tp_2.Controls.Add(this.dgv_clients);
            this.tp_2.Location = new System.Drawing.Point(4, 28);
            this.tp_2.Name = "tp_2";
            this.tp_2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tp_2.Size = new System.Drawing.Size(659, 378);
            this.tp_2.TabIndex = 1;
            this.tp_2.Text = "My clients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clients info";
            // 
            // dgv_clients
            // 
            this.dgv_clients.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Location = new System.Drawing.Point(8, 76);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.RowTemplate.Height = 24;
            this.dgv_clients.Size = new System.Drawing.Size(638, 277);
            this.dgv_clients.TabIndex = 1;
            // 
            // tp_3
            // 
            this.tp_3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_3.Controls.Add(this.b_report);
            this.tp_3.Controls.Add(this.label6);
            this.tp_3.Controls.Add(this.label5);
            this.tp_3.Controls.Add(this.tb_num);
            this.tp_3.Controls.Add(this.cb_type);
            this.tp_3.Location = new System.Drawing.Point(4, 28);
            this.tp_3.Name = "tp_3";
            this.tp_3.Size = new System.Drawing.Size(659, 378);
            this.tp_3.TabIndex = 2;
            this.tp_3.Text = "Report about fault";
            // 
            // b_report
            // 
            this.b_report.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_report.Location = new System.Drawing.Point(426, 59);
            this.b_report.Name = "b_report";
            this.b_report.Size = new System.Drawing.Size(84, 28);
            this.b_report.TabIndex = 4;
            this.b_report.Text = "Report";
            this.b_report.UseVisualStyleBackColor = true;
            this.b_report.Click += new System.EventHandler(this.b_report_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Object number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Object type";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(225, 61);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(136, 26);
            this.tb_num.TabIndex = 1;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Hall",
            "Instrument",
            "Equipment"});
            this.cb_type.Location = new System.Drawing.Point(36, 61);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(136, 27);
            this.cb_type.TabIndex = 0;
            // 
            // ds_sch
            // 
            this.ds_sch.DataSetName = "NewDataSet";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DARIASULTANCA97;Integrated Security=SSPI;Initial C" +
    "atalog=MusicSalon";
            // 
            // ds_clients
            // 
            this.ds_clients.DataSetName = "NewDataSet";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 410);
            this.Controls.Add(this.tc);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.tc.ResumeLayout(false);
            this.tp_1.ResumeLayout(false);
            this.tp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.tp_2.ResumeLayout(false);
            this.tp_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.tp_3.ResumeLayout(false);
            this.tp_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_sch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tp_1;
        private System.Windows.Forms.TabPage tp_2;
        private System.Windows.Forms.DataGridView dgv_schedule;
        private System.Windows.Forms.Button b_graphic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_PeriodFrom;
        private System.Windows.Forms.DateTimePicker dtp_PeriodTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.TabPage tp_3;
        private System.Data.DataSet ds_sch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button b_report;
        private System.Data.DataSet ds_clients;
    }
}