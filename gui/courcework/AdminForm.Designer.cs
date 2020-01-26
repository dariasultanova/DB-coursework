namespace courcework
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.ds_broken = new System.Data.DataSet();
            this.ds_staff = new System.Data.DataSet();
            this.ds_money = new System.Data.DataSet();
            this.tp_3 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.b_income = new System.Windows.Forms.Button();
            this.b_expenses = new System.Windows.Forms.Button();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgv_money = new System.Windows.Forms.DataGridView();
            this.tp_2 = new System.Windows.Forms.TabPage();
            this.b_change = new System.Windows.Forms.Button();
            this.tb_newCost = new System.Windows.Forms.TextBox();
            this.tb_title2 = new System.Windows.Forms.TextBox();
            this.cb_type2 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.b_add = new System.Windows.Forms.Button();
            this.b_report = new System.Windows.Forms.Button();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_arenda = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.cb_typeAdd = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_typeFix = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_broken = new System.Windows.Forms.DataGridView();
            this.tp_1 = new System.Windows.Forms.TabPage();
            this.tb_pay = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.b_changePay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_changeSalary = new System.Windows.Forms.Button();
            this.b_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_post = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.tc_admin = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ds_broken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_money)).BeginInit();
            this.tp_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_money)).BeginInit();
            this.tp_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_broken)).BeginInit();
            this.tp_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.tc_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DARIASULTANCA97;Integrated Security=SSPI;Initial C" +
    "atalog=MusicSalon";
            // 
            // ds_broken
            // 
            this.ds_broken.DataSetName = "NewDataSet";
            // 
            // ds_staff
            // 
            this.ds_staff.DataSetName = "NewDataSet";
            // 
            // ds_money
            // 
            this.ds_money.DataSetName = "NewDataSet";
            // 
            // tp_3
            // 
            this.tp_3.Controls.Add(this.label20);
            this.tp_3.Controls.Add(this.label19);
            this.tp_3.Controls.Add(this.label18);
            this.tp_3.Controls.Add(this.dtp_to);
            this.tp_3.Controls.Add(this.dtp_from);
            this.tp_3.Controls.Add(this.b_income);
            this.tp_3.Controls.Add(this.b_expenses);
            this.tp_3.Controls.Add(this.tb_sum);
            this.tp_3.Controls.Add(this.label17);
            this.tp_3.Controls.Add(this.label16);
            this.tp_3.Controls.Add(this.dgv_money);
            this.tp_3.Location = new System.Drawing.Point(4, 28);
            this.tp_3.Name = "tp_3";
            this.tp_3.Size = new System.Drawing.Size(832, 438);
            this.tp_3.TabIndex = 2;
            this.tp_3.Text = "Money";
            this.tp_3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(533, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 21);
            this.label20.TabIndex = 10;
            this.label20.Text = "Period:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(562, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "To";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(545, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 21);
            this.label18.TabIndex = 8;
            this.label18.Text = "From";
            // 
            // dtp_to
            // 
            this.dtp_to.Location = new System.Drawing.Point(612, 79);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(177, 26);
            this.dtp_to.TabIndex = 7;
            // 
            // dtp_from
            // 
            this.dtp_from.Location = new System.Drawing.Point(612, 38);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(177, 26);
            this.dtp_from.TabIndex = 6;
            // 
            // b_income
            // 
            this.b_income.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_income.Location = new System.Drawing.Point(679, 141);
            this.b_income.Name = "b_income";
            this.b_income.Size = new System.Drawing.Size(110, 28);
            this.b_income.TabIndex = 5;
            this.b_income.Text = "Income";
            this.b_income.UseVisualStyleBackColor = true;
            this.b_income.Click += new System.EventHandler(this.b_income_Click);
            // 
            // b_expenses
            // 
            this.b_expenses.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_expenses.Location = new System.Drawing.Point(537, 141);
            this.b_expenses.Name = "b_expenses";
            this.b_expenses.Size = new System.Drawing.Size(123, 28);
            this.b_expenses.TabIndex = 4;
            this.b_expenses.Text = "Expenses";
            this.b_expenses.UseVisualStyleBackColor = true;
            this.b_expenses.Click += new System.EventHandler(this.b_expenses_Click);
            // 
            // tb_sum
            // 
            this.tb_sum.BackColor = System.Drawing.Color.White;
            this.tb_sum.Location = new System.Drawing.Point(595, 205);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.ReadOnly = true;
            this.tb_sum.Size = new System.Drawing.Size(194, 26);
            this.tb_sum.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(533, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "Sum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "Info table";
            // 
            // dgv_money
            // 
            this.dgv_money.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_money.Location = new System.Drawing.Point(17, 43);
            this.dgv_money.Name = "dgv_money";
            this.dgv_money.RowTemplate.Height = 24;
            this.dgv_money.Size = new System.Drawing.Size(496, 364);
            this.dgv_money.TabIndex = 0;
            // 
            // tp_2
            // 
            this.tp_2.Controls.Add(this.b_change);
            this.tp_2.Controls.Add(this.tb_newCost);
            this.tp_2.Controls.Add(this.tb_title2);
            this.tp_2.Controls.Add(this.cb_type2);
            this.tp_2.Controls.Add(this.label22);
            this.tp_2.Controls.Add(this.label23);
            this.tp_2.Controls.Add(this.label24);
            this.tp_2.Controls.Add(this.label21);
            this.tp_2.Controls.Add(this.b_add);
            this.tp_2.Controls.Add(this.b_report);
            this.tp_2.Controls.Add(this.tb_cost);
            this.tp_2.Controls.Add(this.tb_num);
            this.tp_2.Controls.Add(this.tb_arenda);
            this.tp_2.Controls.Add(this.tb_price);
            this.tp_2.Controls.Add(this.tb_title);
            this.tp_2.Controls.Add(this.cb_typeAdd);
            this.tp_2.Controls.Add(this.label15);
            this.tp_2.Controls.Add(this.label14);
            this.tp_2.Controls.Add(this.label13);
            this.tp_2.Controls.Add(this.cb_typeFix);
            this.tp_2.Controls.Add(this.label12);
            this.tp_2.Controls.Add(this.label11);
            this.tp_2.Controls.Add(this.label10);
            this.tp_2.Controls.Add(this.label9);
            this.tp_2.Controls.Add(this.label8);
            this.tp_2.Controls.Add(this.label7);
            this.tp_2.Controls.Add(this.label1);
            this.tp_2.Controls.Add(this.dgv_broken);
            this.tp_2.Location = new System.Drawing.Point(4, 28);
            this.tp_2.Name = "tp_2";
            this.tp_2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tp_2.Size = new System.Drawing.Size(832, 438);
            this.tp_2.TabIndex = 1;
            this.tp_2.Text = "Objects";
            this.tp_2.UseVisualStyleBackColor = true;
            // 
            // b_change
            // 
            this.b_change.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_change.Location = new System.Drawing.Point(683, 166);
            this.b_change.Name = "b_change";
            this.b_change.Size = new System.Drawing.Size(136, 28);
            this.b_change.TabIndex = 27;
            this.b_change.Text = "Change cost";
            this.b_change.UseVisualStyleBackColor = true;
            this.b_change.Click += new System.EventHandler(this.b_change_Click);
            // 
            // tb_newCost
            // 
            this.tb_newCost.Location = new System.Drawing.Point(683, 122);
            this.tb_newCost.Name = "tb_newCost";
            this.tb_newCost.Size = new System.Drawing.Size(136, 26);
            this.tb_newCost.TabIndex = 26;
            // 
            // tb_title2
            // 
            this.tb_title2.Location = new System.Drawing.Point(683, 82);
            this.tb_title2.Name = "tb_title2";
            this.tb_title2.Size = new System.Drawing.Size(136, 26);
            this.tb_title2.TabIndex = 25;
            // 
            // cb_type2
            // 
            this.cb_type2.FormattingEnabled = true;
            this.cb_type2.Items.AddRange(new object[] {
            "Hall",
            "Instrument",
            "Equipment"});
            this.cb_type2.Location = new System.Drawing.Point(683, 39);
            this.cb_type2.Name = "cb_type2";
            this.cb_type2.Size = new System.Drawing.Size(136, 27);
            this.cb_type2.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(595, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 21);
            this.label22.TabIndex = 23;
            this.label22.Text = "New cost";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(634, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 21);
            this.label23.TabIndex = 22;
            this.label23.Text = "Title";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(628, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 21);
            this.label24.TabIndex = 21;
            this.label24.Text = "Type";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(595, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(178, 21);
            this.label21.TabIndex = 20;
            this.label21.Text = "Change cost of arenda";
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_add.Location = new System.Drawing.Point(434, 206);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(136, 28);
            this.b_add.TabIndex = 19;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_report
            // 
            this.b_report.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_report.Location = new System.Drawing.Point(384, 381);
            this.b_report.Name = "b_report";
            this.b_report.Size = new System.Drawing.Size(128, 28);
            this.b_report.TabIndex = 18;
            this.b_report.Text = "Report";
            this.b_report.UseVisualStyleBackColor = true;
            this.b_report.Click += new System.EventHandler(this.b_report_Click);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(667, 340);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(112, 26);
            this.tb_cost.TabIndex = 17;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(533, 340);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(112, 26);
            this.tb_num.TabIndex = 16;
            // 
            // tb_arenda
            // 
            this.tb_arenda.Location = new System.Drawing.Point(434, 164);
            this.tb_arenda.Name = "tb_arenda";
            this.tb_arenda.Size = new System.Drawing.Size(136, 26);
            this.tb_arenda.TabIndex = 15;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(434, 122);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(136, 26);
            this.tb_price.TabIndex = 14;
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(434, 82);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(136, 26);
            this.tb_title.TabIndex = 13;
            // 
            // cb_typeAdd
            // 
            this.cb_typeAdd.FormattingEnabled = true;
            this.cb_typeAdd.Items.AddRange(new object[] {
            "Hall",
            "Instrument",
            "Equipment"});
            this.cb_typeAdd.Location = new System.Drawing.Point(434, 39);
            this.cb_typeAdd.Name = "cb_typeAdd";
            this.cb_typeAdd.Size = new System.Drawing.Size(136, 27);
            this.cb_typeAdd.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(663, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 21);
            this.label15.TabIndex = 11;
            this.label15.Text = "Cost of repair";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(529, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 21);
            this.label14.TabIndex = 10;
            this.label14.Text = "Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(380, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Type";
            // 
            // cb_typeFix
            // 
            this.cb_typeFix.FormattingEnabled = true;
            this.cb_typeFix.Items.AddRange(new object[] {
            "Hall",
            "Instrument",
            "Equipment"});
            this.cb_typeFix.Location = new System.Drawing.Point(384, 339);
            this.cb_typeFix.Name = "cb_typeFix";
            this.cb_typeFix.Size = new System.Drawing.Size(128, 27);
            this.cb_typeFix.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(380, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(409, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Enter type and number of object to report that it fixed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(382, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(380, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(386, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add new object";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Objects need fix";
            // 
            // dgv_broken
            // 
            this.dgv_broken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_broken.Location = new System.Drawing.Point(11, 39);
            this.dgv_broken.Name = "dgv_broken";
            this.dgv_broken.RowTemplate.Height = 24;
            this.dgv_broken.Size = new System.Drawing.Size(335, 379);
            this.dgv_broken.TabIndex = 0;
            // 
            // tp_1
            // 
            this.tp_1.Controls.Add(this.tb_pay);
            this.tp_1.Controls.Add(this.tb_salary);
            this.tp_1.Controls.Add(this.tb_ID);
            this.tp_1.Controls.Add(this.b_changePay);
            this.tp_1.Controls.Add(this.label6);
            this.tp_1.Controls.Add(this.label5);
            this.tp_1.Controls.Add(this.label4);
            this.tp_1.Controls.Add(this.b_delete);
            this.tp_1.Controls.Add(this.b_changeSalary);
            this.tp_1.Controls.Add(this.b_register);
            this.tp_1.Controls.Add(this.label3);
            this.tp_1.Controls.Add(this.lb_post);
            this.tp_1.Controls.Add(this.label2);
            this.tp_1.Controls.Add(this.dgv_staff);
            this.tp_1.Location = new System.Drawing.Point(4, 28);
            this.tp_1.Name = "tp_1";
            this.tp_1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tp_1.Size = new System.Drawing.Size(832, 438);
            this.tp_1.TabIndex = 0;
            this.tp_1.Text = "Staff";
            this.tp_1.UseVisualStyleBackColor = true;
            // 
            // tb_pay
            // 
            this.tb_pay.Location = new System.Drawing.Point(675, 219);
            this.tb_pay.Name = "tb_pay";
            this.tb_pay.Size = new System.Drawing.Size(112, 26);
            this.tb_pay.TabIndex = 13;
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(523, 219);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(112, 26);
            this.tb_salary.TabIndex = 12;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(325, 391);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(112, 26);
            this.tb_ID.TabIndex = 7;
            // 
            // b_changePay
            // 
            this.b_changePay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_changePay.Location = new System.Drawing.Point(675, 260);
            this.b_changePay.Name = "b_changePay";
            this.b_changePay.Size = new System.Drawing.Size(112, 28);
            this.b_changePay.TabIndex = 11;
            this.b_changePay.Text = "Change pay";
            this.b_changePay.UseVisualStyleBackColor = true;
            this.b_changePay.Click += new System.EventHandler(this.b_changePay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "New pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "New salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter ID of employee you want to delete";
            // 
            // b_delete
            // 
            this.b_delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.Location = new System.Drawing.Point(452, 390);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(84, 28);
            this.b_delete.TabIndex = 6;
            this.b_delete.Text = "Delete employer";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_changeSalary
            // 
            this.b_changeSalary.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_changeSalary.Location = new System.Drawing.Point(523, 260);
            this.b_changeSalary.Name = "b_changeSalary";
            this.b_changeSalary.Size = new System.Drawing.Size(112, 28);
            this.b_changeSalary.TabIndex = 5;
            this.b_changeSalary.Text = "Change salary";
            this.b_changeSalary.UseVisualStyleBackColor = true;
            this.b_changeSalary.Click += new System.EventHandler(this.b_changeSalary_Click);
            // 
            // b_register
            // 
            this.b_register.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_register.Location = new System.Drawing.Point(11, 352);
            this.b_register.Name = "b_register";
            this.b_register.Size = new System.Drawing.Size(201, 28);
            this.b_register.TabIndex = 4;
            this.b_register.Text = "Register new employee";
            this.b_register.UseVisualStyleBackColor = true;
            this.b_register.Click += new System.EventHandler(this.b_register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posts";
            // 
            // lb_post
            // 
            this.lb_post.FormattingEnabled = true;
            this.lb_post.ItemHeight = 19;
            this.lb_post.Location = new System.Drawing.Point(523, 39);
            this.lb_post.Name = "lb_post";
            this.lb_post.Size = new System.Drawing.Size(264, 137);
            this.lb_post.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff";
            // 
            // dgv_staff
            // 
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Location = new System.Drawing.Point(11, 39);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowTemplate.Height = 24;
            this.dgv_staff.Size = new System.Drawing.Size(491, 297);
            this.dgv_staff.TabIndex = 0;
            // 
            // tc_admin
            // 
            this.tc_admin.Controls.Add(this.tp_1);
            this.tc_admin.Controls.Add(this.tp_2);
            this.tc_admin.Controls.Add(this.tp_3);
            this.tc_admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_admin.Location = new System.Drawing.Point(0, 0);
            this.tc_admin.Name = "tc_admin";
            this.tc_admin.SelectedIndex = 0;
            this.tc_admin.Size = new System.Drawing.Size(840, 470);
            this.tc_admin.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 470);
            this.Controls.Add(this.tc_admin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.ds_broken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_money)).EndInit();
            this.tp_3.ResumeLayout(false);
            this.tp_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_money)).EndInit();
            this.tp_2.ResumeLayout(false);
            this.tp_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_broken)).EndInit();
            this.tp_1.ResumeLayout(false);
            this.tp_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.tc_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.OleDb.OleDbConnection cn;
        private System.Data.DataSet ds_broken;
        private System.Data.DataSet ds_staff;
        private System.Data.DataSet ds_money;
        private System.Windows.Forms.TabPage tp_3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Button b_income;
        private System.Windows.Forms.Button b_expenses;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgv_money;
        private System.Windows.Forms.TabPage tp_2;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_report;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_arenda;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.ComboBox cb_typeAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_typeFix;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_broken;
        private System.Windows.Forms.TabPage tp_1;
        private System.Windows.Forms.TextBox tb_pay;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button b_changePay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_changeSalary;
        private System.Windows.Forms.Button b_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_post;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.TabControl tc_admin;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button b_change;
        private System.Windows.Forms.TextBox tb_newCost;
        private System.Windows.Forms.TextBox tb_title2;
        private System.Windows.Forms.ComboBox cb_type2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
    }
}