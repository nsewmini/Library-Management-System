using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=NEW-GEN-COMPUTE\\SQLEXPRESS; Initial Catalog=library; Integrated Security=true; Encrypt=False");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Success");

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            con.Close();
        }
    }
}
