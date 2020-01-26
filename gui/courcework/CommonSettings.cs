using System.Drawing;
using System.Windows.Forms;


class Modifier
{

    public void MakeNiceTabPage(TabPage tp)
    {
        tp.Font = new Font("Times New Roman", 12);
    }

    public void MakeNiceTabControl(TabControl tc)
    {
        tc.Font = new Font("Times New Roman", 12);
    }

    public void MakeNiceDataGridView(DataGridView dgv)
    {
        dgv.ReadOnly = true;
        dgv.BackgroundColor = Color.White;
        dgv.EnableHeadersVisualStyles = false;
     
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dgv.RowHeadersVisible = false;
        dgv.BorderStyle = BorderStyle.None;
        dgv.DefaultCellStyle.SelectionBackColor = Color.Silver;
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
        dgv.AllowUserToAddRows = false;
   
    }

    public void MakeNiceComboBox(ComboBox cb)
    {
        cb.DropDownStyle = ComboBoxStyle.DropDownList;
        cb.FlatStyle = FlatStyle.Popup;
    }
}
