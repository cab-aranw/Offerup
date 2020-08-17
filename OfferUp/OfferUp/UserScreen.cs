using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferUp
{
    public partial class UserScreenForm : Form
    {
        SqlConnection connectionVar = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\GitHub Project\Offerup\OfferUp\OfferUp\OfferUpDB.mdf;Integrated Security = True; Connect Timeout = 30");
        public UserScreenForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            connectionVar.Open();

            SqlCommand commandVar = connectionVar.CreateCommand();
            commandVar.CommandType = CommandType.Text;
            if (EmailTextBox.Text == "" || NameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Me cago en todos los profesores!!");
            }
            else
            {
                commandVar.CommandText = "INSERT INTO UserTable values ('" + EmailTextBox.Text + "','" + NameTextBox.Text + "','" + PasswordTextBox.Text + "')";

                commandVar.ExecuteNonQuery(); // Executes
                //connectionVar.Close();
                MessageBox.Show("Insert Successfully");
            }

            connectionVar.Close();

            //string var;
            //var = EmailTextBox.Text;
            //MessageBox.Show("My name is : " + var+ "and my last name is "+NameTextBox.Text + "Thank you");

        }
    }
}
