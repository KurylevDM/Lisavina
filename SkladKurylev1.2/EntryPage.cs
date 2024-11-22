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
    public partial class EntryPage : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OleDb.accdb;";

        public EntryPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string sqlExpression = "SELECT * FROM [User] WHERE [Login] = @Login AND [Password] = @Password;";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);
                    sqlCommand.Parameters.AddWithValue("@Login", textBox3.Text);
                    sqlCommand.Parameters.AddWithValue("@Password", textBox4.Text);

                    using (OleDbDataReader dataReader = sqlCommand.ExecuteReader()) 
                    if (dataReader.Read()) 
                    {
                        MessageBox.Show($"Здравствуйте, {dataReader["FirstName"]}");
                        this.Hide();
                        SkladPage skladP = new SkladPage();
                        skladP.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин/пароль!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomePage wel = new WelcomePage();
            wel.Show();
            this.Close();
        }

        private void EntryPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegPage reg = new RegPage();
            reg.Show();
            this.Hide();
        }
    }
}
