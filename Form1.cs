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
using System.Configuration;

namespace ExerciseRegistrationAndValidation
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public void Reset()
        {
            TxtEmail.Text = "";
            TxtConPass.Clear();
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtGender.Text = "";
            TxtPass.Text = "";
            TxtConPass.Text = "";
            TxtFirstName.Focus();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Sql Connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\mssqllocaldb; initial catalog=HR; Integrated Security=true;";
            //Create Sql Command - Select Query or DML Query or Stored Procedure
            SqlCommand cmd = new SqlCommand();
            //Passing connection object
            cmd.Connection = conn;
            conn.Open();
            
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=HR; Integrated Security=true"))
            {
                using (cmd = new SqlCommand("usp_registration", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@emailid", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@firstname", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@lastname", TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@gender", TxtGender.Text);
                    cmd.Parameters.AddWithValue("@birthdate", DTPBD.Value);
                    cmd.Parameters.AddWithValue("@password", TxtPass.Text);
                    cmd.Parameters.AddWithValue("@confirm_password", TxtConPass.Text);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery(); //used for DML operation
                }
                MessageBox.Show("SignUp Successful");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void RegisteredSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }

}

