using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SkladKurylev
{
    public partial class RegPage : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OleDb.accdb;";
        public RegPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePage wel = new WelcomePage();
            wel.Show(); 
            this.Close();
        }

        private void RegPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoleRegComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void RegButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string sqlExpression = "INSERT INTO [User] ([IdUserRole], [FirstName], [SureName], [Login], [Password])" + "VALUES (@Role, @Name, @SureName, @Login, @Password);";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);
                    sqlCommand.Parameters.AddWithValue("@Role", RoleRegComboBox.SelectedIndex + 1);
                    sqlCommand.Parameters.AddWithValue("@Name", NameRegTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Surename", SurenameRegTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Login", LogRegTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", PassRegTextBox.Text);

                    int number = sqlCommand.ExecuteNonQuery();
                    if (number >= 1)
                    {
                        MessageBox.Show("Успешная регистрация");
                        this.Hide();
                        RegPage loginForm = new RegPage();
                        loginForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка регистрации!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SurenameRegTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
