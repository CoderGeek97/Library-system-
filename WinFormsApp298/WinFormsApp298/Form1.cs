using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp298
{

    public partial class Form1 : Form
    {
        //variables for sql connection
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();

        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM BOOKS WHERE ID=@ID";
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            DiaDelete diaDelete1 = new DiaDelete();
            diaDelete1.Show();
            cmd.Parameters.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 book_add = new Form2();
            book_add.btn_ADD.Text = "Update Book";
            book_add.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            book_add.Show();
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT TITLE,AUTHER,PRICE,TYPE,DATE,RATE FROM BOOKS WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List.Add(Convert.ToString(dr[0]));
                    List.Add(Convert.ToString(dr[1]));
                    List.Add(Convert.ToString(dr[2]));
                    List.Add(Convert.ToString(dr[3]));
                    List.Add(Convert.ToString(dr[4]));
                    List.Add(Convert.ToString(dr[5]));
                }

                book_add.textBox1.Text = List[0];
                book_add.textBox3.Text = List[1];
                book_add.textBox7.Text = List[2];
                book_add.comboBox1.Text = List[3];
                book_add.dateTimePicker1.Value = Convert.ToDateTime(List[4]);
                book_add.numericUpDown1.Value = Convert.ToDecimal(List[5]);

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 book_add = new Form2();
            book_add.btn_ADD.Text = "Add New Book";
            book_add.state = 0;
            book_add.Show();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\WinFormsApp298\WinFormsApp298\DBbook.mdf;Integrated Security=True");
            var sql = "SELECT ID as Sequance,TITLE,AUTHER,PRICE,TYPE,RATE FROM BOOKS";

            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }


    }
}