namespace courcework
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.ds = new System.Data.DataSet();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.tc_user = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_TimeTo = new System.Windows.Forms.TextBox();
            this.tb_TimeFrom = new System.Windows.Forms.TextBox();
            this.dgv_pricelist = new System.Windows.Forms.DataGridView();
            this.dtp_DealDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_SelectedItem = new System.Windows.Forms.TextBox();
            this.b_NewContent = new System.Windows.Forms.Button();
            this.b_newDeal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Halls = new System.Windows.Forms.ComboBox();
            this.lb_StaffList = new System.Windows.Forms.ListBox();
            this.lb_InstrumentsList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_EquipmentList = new System.Windows.Forms.ListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_PeriodTo = new System.Windows.Forms.DateTimePicker();
            this.dtp_PeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.b_SeeContracts = new System.Windows.Forms.Button();
            this.b_SeeContents = new System.Windows.Forms.Button();
            this.dgv_userinfo = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.b_DeleteDeal = new System.Windows.Forms.Button();
            this.lb_deals = new System.Windows.Forms.ListBox();
            this.ds_info = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.tc_user.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pricelist)).BeginInit();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_info)).BeginInit();
            this.SuspendLayout();
            // 
            // ds
            // 
            this.ds.DataSetName = "NewDataSet";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DARIASULTANCA97;Integrated Security=SSPI;Initial C" +
    "atalog=MusicSalon";
            // 
            // tc_user
            // 
            this.tc_user.Controls.Add(this.tp1);
            this.tc_user.Controls.Add(this.tp2);
            this.tc_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_user.Location = new System.Drawing.Point(0, 0);
            this.tc_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc_user.Name = "tc_user";
            this.tc_user.SelectedIndex = 0;
            this.tc_user.Size = new System.Drawing.Size(762, 541);
            this.tc_user.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp1.Controls.Add(this.label9);
            this.tp1.Controls.Add(this.label8);
            this.tp1.Controls.Add(this.tb_TimeTo);
            this.tp1.Controls.Add(this.tb_TimeFrom);
            this.tp1.Controls.Add(this.dgv_pricelist);
            this.tp1.Controls.Add(this.dtp_DealDate);
            this.tp1.Controls.Add(this.label7);
            this.tp1.Controls.Add(this.tb_SelectedItem);
            this.tp1.Controls.Add(this.b_NewContent);
            this.tp1.Controls.Add(this.b_newDeal);
            this.tp1.Controls.Add(this.label6);
            this.tp1.Controls.Add(this.cb_Halls);
            this.tp1.Controls.Add(this.lb_StaffList);
            this.tp1.Controls.Add(this.lb_InstrumentsList);
            this.tp1.Controls.Add(this.label5);
            this.tp1.Controls.Add(this.label4);
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.label2);
            this.tp1.Controls.Add(this.label1);
            this.tp1.Controls.Add(this.lb_EquipmentList);
            this.tp1.Location = new System.Drawing.Point(4, 28);
            this.tp1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp1.Size = new System.Drawing.Size(754, 509);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "New deal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Time: from";
            // 
            // tb_TimeTo
            // 
            this.tb_TimeTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimeTo.Location = new System.Drawing.Point(466, 56);
            this.tb_TimeTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TimeTo.Name = "tb_TimeTo";
            this.tb_TimeTo.Size = new System.Drawing.Size(58, 26);
            this.tb_TimeTo.TabIndex = 35;
            // 
            // tb_TimeFrom
            // 
            this.tb_TimeFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimeFrom.Location = new System.Drawing.Point(357, 56);
            this.tb_TimeFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TimeFrom.Name = "tb_TimeFrom";
            this.tb_TimeFrom.Size = new System.Drawing.Size(52, 26);
            this.tb_TimeFrom.TabIndex = 34;
            // 
            // dgv_pricelist
            // 
            this.dgv_pricelist.BackgroundColor = System.Drawing.Color.White;
            this.dgv_pricelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pricelist.Location = new System.Drawing.Point(4, 40);
            this.dgv_pricelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_pricelist.Name = "dgv_pricelist";
            this.dgv_pricelist.RowTemplate.Height = 24;
            this.dgv_pricelist.Size = new System.Drawing.Size(218, 458);
            this.dgv_pricelist.TabIndex = 33;
            // 
            // dtp_DealDate
            // 
            this.dtp_DealDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DealDate.Location = new System.Drawing.Point(357, 11);
            this.dtp_DealDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_DealDate.Name = "dtp_DealDate";
            this.dtp_DealDate.Size = new System.Drawing.Size(167, 26);
            this.dtp_DealDate.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 459);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Selected item";
            // 
            // tb_SelectedItem
            // 
            this.tb_SelectedItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SelectedItem.Location = new System.Drawing.Point(364, 457);
            this.tb_SelectedItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_SelectedItem.Name = "tb_SelectedItem";
            this.tb_SelectedItem.Size = new System.Drawing.Size(218, 26);
            this.tb_SelectedItem.TabIndex = 30;
            // 
            // b_NewContent
            // 
            this.b_NewContent.AutoSize = true;
            this.b_NewContent.BackColor = System.Drawing.Color.Gainsboro;
            this.b_NewContent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_NewContent.Location = new System.Drawing.Point(586, 453);
            this.b_NewContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_NewContent.Name = "b_NewContent";
            this.b_NewContent.Size = new System.Drawing.Size(148, 33);
            this.b_NewContent.TabIndex = 28;
            this.b_NewContent.Text = "Add new content";
            this.b_NewContent.UseVisualStyleBackColor = false;
            this.b_NewContent.Click += new System.EventHandler(this.b_NewContent_Click);
            // 
            // b_newDeal
            // 
            this.b_newDeal.AutoSize = true;
            this.b_newDeal.BackColor = System.Drawing.Color.Gainsboro;
            this.b_newDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_newDeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_newDeal.ForeColor = System.Drawing.Color.Black;
            this.b_newDeal.Location = new System.Drawing.Point(570, 92);
            this.b_newDeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_newDeal.Name = "b_newDeal";
            this.b_newDeal.Size = new System.Drawing.Size(154, 50);
            this.b_newDeal.TabIndex = 27;
            this.b_newDeal.Text = "Create new deal";
            this.b_newDeal.UseVisualStyleBackColor = false;
            this.b_newDeal.Click += new System.EventHandler(this.b_newDeal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(240, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Deal Date";
            // 
            // cb_Halls
            // 
            this.cb_Halls.BackColor = System.Drawing.Color.White;
            this.cb_Halls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Halls.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Halls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Halls.FormattingEnabled = true;
            this.cb_Halls.Location = new System.Drawing.Point(357, 109);
            this.cb_Halls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Halls.Name = "cb_Halls";
            this.cb_Halls.Size = new System.Drawing.Size(167, 27);
            this.cb_Halls.TabIndex = 24;
            // 
            // lb_StaffList
            // 
            this.lb_StaffList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StaffList.FormattingEnabled = true;
            this.lb_StaffList.ItemHeight = 19;
            this.lb_StaffList.Location = new System.Drawing.Point(559, 226);
            this.lb_StaffList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_StaffList.Name = "lb_StaffList";
            this.lb_StaffList.Size = new System.Drawing.Size(185, 213);
            this.lb_StaffList.TabIndex = 23;
            this.lb_StaffList.DoubleClick += new System.EventHandler(this.lb_StaffList_DoubleClick);
            // 
            // lb_InstrumentsList
            // 
            this.lb_InstrumentsList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InstrumentsList.FormattingEnabled = true;
            this.lb_InstrumentsList.ItemHeight = 19;
            this.lb_InstrumentsList.Location = new System.Drawing.Point(236, 226);
            this.lb_InstrumentsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_InstrumentsList.Name = "lb_InstrumentsList";
            this.lb_InstrumentsList.Size = new System.Drawing.Size(173, 213);
            this.lb_InstrumentsList.TabIndex = 22;
            this.lb_InstrumentsList.DoubleClick += new System.EventHandler(this.lb_InstrumentsList_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Halls list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Equipment list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(239, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Instruments list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Staff list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pricelist";
            // 
            // lb_EquipmentList
            // 
            this.lb_EquipmentList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EquipmentList.FormattingEnabled = true;
            this.lb_EquipmentList.ItemHeight = 19;
            this.lb_EquipmentList.Location = new System.Drawing.Point(412, 226);
            this.lb_EquipmentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_EquipmentList.Name = "lb_EquipmentList";
            this.lb_EquipmentList.Size = new System.Drawing.Size(143, 213);
            this.lb_EquipmentList.TabIndex = 16;
            this.lb_EquipmentList.DoubleClick += new System.EventHandler(this.lb_EquipmentList_DoubleClick);
            // 
            // tp2
            // 
            this.tp2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp2.Controls.Add(this.label13);
            this.tp2.Controls.Add(this.dtp_PeriodTo);
            this.tp2.Controls.Add(this.dtp_PeriodFrom);
            this.tp2.Controls.Add(this.label12);
            this.tp2.Controls.Add(this.label11);
            this.tp2.Controls.Add(this.b_SeeContracts);
            this.tp2.Controls.Add(this.b_SeeContents);
            this.tp2.Controls.Add(this.dgv_userinfo);
            this.tp2.Controls.Add(this.label10);
            this.tp2.Controls.Add(this.b_DeleteDeal);
            this.tp2.Controls.Add(this.lb_deals);
            this.tp2.Location = new System.Drawing.Point(4, 28);
            this.tp2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp2.Size = new System.Drawing.Size(754, 509);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Existing deals";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Info";
            // 
            // dtp_PeriodTo
            // 
            this.dtp_PeriodTo.Location = new System.Drawing.Point(573, 55);
            this.dtp_PeriodTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_PeriodTo.Name = "dtp_PeriodTo";
            this.dtp_PeriodTo.Size = new System.Drawing.Size(166, 26);
            this.dtp_PeriodTo.TabIndex = 12;
            // 
            // dtp_PeriodFrom
            // 
            this.dtp_PeriodFrom.Location = new System.Drawing.Point(573, 12);
            this.dtp_PeriodFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_PeriodFrom.Name = "dtp_PeriodFrom";
            this.dtp_PeriodFrom.Size = new System.Drawing.Size(164, 26);
            this.dtp_PeriodFrom.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "to";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(445, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Period: from";
            // 
            // b_SeeContracts
            // 
            this.b_SeeContracts.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SeeContracts.Location = new System.Drawing.Point(449, 156);
            this.b_SeeContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_SeeContracts.Name = "b_SeeContracts";
            this.b_SeeContracts.Size = new System.Drawing.Size(288, 37);
            this.b_SeeContracts.TabIndex = 8;
            this.b_SeeContracts.Text = "See summs of deals per period";
            this.b_SeeContracts.UseVisualStyleBackColor = true;
            this.b_SeeContracts.Click += new System.EventHandler(this.b_SeeContracts_Click);
            // 
            // b_SeeContents
            // 
            this.b_SeeContents.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_SeeContents.Location = new System.Drawing.Point(449, 105);
            this.b_SeeContents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_SeeContents.Name = "b_SeeContents";
            this.b_SeeContents.Size = new System.Drawing.Size(288, 37);
            this.b_SeeContents.TabIndex = 7;
            this.b_SeeContents.Text = "See contents of deals per period";
            this.b_SeeContents.UseVisualStyleBackColor = true;
            this.b_SeeContents.Click += new System.EventHandler(this.b_SeeContents_Click);
            // 
            // dgv_userinfo
            // 
            this.dgv_userinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_userinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userinfo.Location = new System.Drawing.Point(13, 43);
            this.dgv_userinfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_userinfo.Name = "dgv_userinfo";
            this.dgv_userinfo.RowTemplate.Height = 24;
            this.dgv_userinfo.Size = new System.Drawing.Size(412, 431);
            this.dgv_userinfo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 259);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Choose deal to delete";
            // 
            // b_DeleteDeal
            // 
            this.b_DeleteDeal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_DeleteDeal.Location = new System.Drawing.Point(539, 435);
            this.b_DeleteDeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_DeleteDeal.Name = "b_DeleteDeal";
            this.b_DeleteDeal.Size = new System.Drawing.Size(109, 39);
            this.b_DeleteDeal.TabIndex = 4;
            this.b_DeleteDeal.Text = "Delete";
            this.b_DeleteDeal.UseVisualStyleBackColor = true;
            this.b_DeleteDeal.Click += new System.EventHandler(this.b_DeleteDeal_Click);
            // 
            // lb_deals
            // 
            this.lb_deals.FormattingEnabled = true;
            this.lb_deals.ItemHeight = 19;
            this.lb_deals.Location = new System.Drawing.Point(449, 294);
            this.lb_deals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_deals.Name = "lb_deals";
            this.lb_deals.Size = new System.Drawing.Size(288, 118);
            this.lb_deals.TabIndex = 3;
            // 
            // ds_info
            // 
            this.ds_info.DataSetName = "NewDataSet";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 541);
            this.Controls.Add(this.tc_user);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormForUser";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.tc_user.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pricelist)).EndInit();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet ds;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.TabControl tc_user;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Button b_NewContent;
        private System.Windows.Forms.Button b_newDeal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Halls;
        private System.Windows.Forms.ListBox lb_StaffList;
        private System.Windows.Forms.ListBox lb_InstrumentsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_EquipmentList;
        private System.Windows.Forms.TabPage tp2;
        private System.Data.DataSet ds_info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_SelectedItem;
        private System.Windows.Forms.DateTimePicker dtp_DealDate;
        private System.Windows.Forms.DataGridView dgv_pricelist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_TimeTo;
        private System.Windows.Forms.TextBox tb_TimeFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lb_deals;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_DeleteDeal;
        private System.Windows.Forms.DataGridView dgv_userinfo;
        private System.Windows.Forms.DateTimePicker dtp_PeriodTo;
        private System.Windows.Forms.DateTimePicker dtp_PeriodFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button b_SeeContracts;
        private System.Windows.Forms.Button b_SeeContents;
        private System.Windows.Forms.Label label13;
    }
}