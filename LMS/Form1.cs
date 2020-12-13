using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProjectA3
{
    public partial class txt_Password : Form
    {
       
        int attempt = 0;
        string username;
        string password;
        public txt_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            password = txtPassword.Text;
            DataTable dt1 = new DataTable();

            if (attempt < 4 && password == txtPassword.Text )
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\livio\\Documents\\db_club.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From tbl_login where UserName =' " + txtUserName.Text.Trim() +
                    "' and Password = '" + txtPassword.Text.Trim() + "'", con);
                DataTable dt = new DataTable();
                sqa.Fill(dt);
                this.Hide();
                RegForm main = new RegForm();
                main.Show();
                MessageBox.Show("Login successfull");
            }
            else
            {
                MessageBox.Show("Username/Password is incorrect. Number of attempt is:" + attempt);
                attempt++;
            }
            if(attempt == 4){
                MessageBox.Show("Number of attempts are over.");

            }
                attempt++;
            
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_Password_Load(object sender, EventArgs e)
        {

        }

        private class txtemail
        {
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
