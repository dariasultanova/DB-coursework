using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace courcework
{
    public partial class EnterToSystem : Form
    {
        private OleDbDataAdapter da;
        public EnterToSystem()
        {
            InitializeComponent();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
            }
            Modifier mod = new Modifier();
            mod.MakeNiceComboBox(cb_users);
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            string entered_nick = Nick.Text;
            OleDbCommand command = new OleDbCommand();
            if (cb_users.Text == "Client")
            {
                command.CommandText = "SELECT Pswd FROM Clients WHERE Nickname = '" + entered_nick + "'";
                command.Connection = cn;
            }
            if (cb_users.Text == "Staff")
            {
                command.CommandText = "SELECT Pswd FROM Staff WHERE Nickname = '" + entered_nick + "'";
                command.Connection = cn;
            }
            if (cb_users.Text == "Director")
            {
                command.CommandText = "SELECT Pswd FROM Admins WHERE Nickname = '" + entered_nick + "'";
                command.Connection = cn;
            }
            string pswd = "";
            try
            {
                OleDbDataReader rdr = command.ExecuteReader();
               
                try
                {
                    rdr.Read();
                    pswd = rdr.GetString(0);
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong login", "Error", MessageBoxButtons.OK); return;
                }
            }catch
            {
                MessageBox.Show("Empty fields", "Error", MessageBoxButtons.OK); return;
            }
           
            string entered_pswd = Pswd.Text;
            if (entered_pswd == pswd)
            {
                if (cb_users.Text == "Client")
                {
                    ClientForm userform = new ClientForm(entered_nick);
                    userform.Show();
                    entered_nick = "";
                    entered_pswd = "";
                }
                if (cb_users.Text == "Staff")
                {
                    StaffForm staffform = new StaffForm(entered_nick);
                    staffform.Show();
                    entered_nick = "";
                    entered_pswd = "";
                }
                if (cb_users.Text == "Director")
                {
                    AdminForm adminform = new AdminForm();
                    adminform.Show();
                    entered_nick = "";
                    entered_pswd = "";
                }

            }
            else
            {
                MessageBox.Show("Wrong password", "Error", MessageBoxButtons.OK);
            }

        }

        private void b_NewUser_Click(object sender, EventArgs e)
        {
            RegisterClientForm reg = new RegisterClientForm();
            reg.Show();
        }
    }
}
