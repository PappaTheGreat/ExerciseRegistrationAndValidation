using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ExerciseRegistrationAndValidation
{
    public partial class Form2 : Form
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;

        private SqlDataReader reader = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=HR; Integrated Security=true"))
            {
                
                    string email, password;
                    email = TxtEmailSignIn.Text;
                    password = TxtPasswordSignIn.Text;
                    cmd = new SqlCommand("select * from registration where Email_Id = '" +email+ "' and password = '" + password + "'  ", conn);
                    conn.Open();
                    reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }

                    
                
            }
        }

    }
}
                 
     
                    
                    /*cmd.CommandType = CommandType.Text;
                    
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    using (reader = cmd.ExecuteReader())
                    {
                        
                        if (TxtEmailSignIn.Text == reader["Email_Id"].ToString() && TxtPasswordSignIn.Text == reader["Password"].ToString())
                        {
                            MessageBox.Show("SignIn Successful");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email-Id or Password");

                        }

                    }*/
   
