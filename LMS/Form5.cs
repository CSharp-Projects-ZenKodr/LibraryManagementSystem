using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;

namespace Library_User_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e) 
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryUserManagementSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[BooksRecord]
           ([NumberOfBooksIssued]
           ,[Book1]
           ,[Book2]
           ,[Book3]
           ,[Book4]
           ,[Book5]
           ,[DateOfIssueB1]
           ,[DateOfIssueB2]
           ,[DateOfIssueB3]
           ,[DateOfIssueB4]
           ,[DateOfIssueB5]
           ,[DueDateB1]
           ,[DueDateB2]
           ,[DueDateB3]
           ,[DueDateB4]
           ,[DueDateB5])
     VALUES
           ('" + NumberOfBooks.Text + "', '" + Book1.Text + "', '" + Book2.Text + "', '" + Book3.Text + "', '" + Book4.Text + "', '" + Book5.Text + "', '" + DateOfIssueB1.Text + "', '" + DateOfIssueB2.Text + "','" + DateOfIssueB3.Text + "','" + DateOfIssueB4.Text + "','" + DateOfIssueB5.Text + "','" + DueDateB1.Text + "', '" + DueDateB2.Text + "', '" + DueDateB3.Text + "', '" + DueDateB4.Text + "', '" + DueDateB5.Text + "')");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Succesfully");           
           }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
