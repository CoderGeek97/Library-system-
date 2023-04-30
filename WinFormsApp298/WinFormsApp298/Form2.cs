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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        public int state;
        public Form2()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form3 add_type = new Form3();
            add_type.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter Book Details");
            }
            else
            {
                if (state == 0)
                {   //Add_book
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");

                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO BOOKS (TITLE,AUTHER,PRICE,TYPE,DATE,RATE) VALUES (@TITLE,@AUTHER,@PRICE,@TYPE,@DATE,@RATE) ";
                    cmd.Parameters.AddWithValue("@TITLE", textBox1.Text);
                    cmd.Parameters.AddWithValue("@AUTHER", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PRICE", textBox7.Text);
                    cmd.Parameters.AddWithValue("@TYPE", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@DATE", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@RATE", numericUpDown1.Value);


                    cmd.ExecuteNonQuery();
                    con.Close();


                    DiaEDIT add_dia = new DiaEDIT();
                    add_dia.Show();
                    this.Close();
                }
                else
                {   //Update_book
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");

                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE  BOOKS  SET TITLE=@TITLE,AUTHER=@AUTHER,PRICE=@PRICE,TYPE=@TYPE,DATE=@DATE,RATE =@RATE";
                    cmd.Parameters.AddWithValue("@TITLE", textBox1.Text);
                    cmd.Parameters.AddWithValue("@AUTHER", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PRICE", textBox7.Text);
                    cmd.Parameters.AddWithValue("@TYPE", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@DATE", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@RATE", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@ID", state);



                    cmd.ExecuteNonQuery();
                    con.Close();


                    DiaUpdate update_dia = new DiaUpdate();
                    update_dia.Show();
                    this.Close();

                }

            }
            cmd.Parameters.Clear();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT CAT FROM BTYPE";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List.Add(Convert.ToString(dr[0]));
                }
                int i = 0;
                while (i < List.LongCount())
                {
                    comboBox1.Items.Add(List[i]);
                    i = i + 1;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
            finally
            {
                con.Close();
            }


        }



    }
}
