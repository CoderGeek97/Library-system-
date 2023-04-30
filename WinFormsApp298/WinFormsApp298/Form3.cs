using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp298
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXT_TYPE.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO BTYPE (CAT) VALUES (@CAT) ";
                cmd.Parameters.AddWithValue("@CAT", TXT_TYPE.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DiaEDIT add_type = new DiaEDIT();
                add_type.Show();
                this.Close();
            }
            else
                MessageBox.Show("Enter Type!");
            
        }
    }
}
