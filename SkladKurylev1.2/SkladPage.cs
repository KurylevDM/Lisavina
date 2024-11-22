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
    public partial class SkladPage : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OleDb.accdb;";


        public SkladPage()
        {

            InitializeComponent();

            try
            {
                string sql = "SELECT [User].[Id] as [Id], [User].[FirstName] as [Имя], [User].[SureName] as [Фамилия], [UserRole].[NameOfRole] as [роль] " +
                    "FROM [User] INNER JOIN [UserRole] ON [UserRole].[Id] = [User].[IdUserRole];";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(sql, connectionString);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    ManagerdataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            try
            {
                string sql = "SELECT [Orders].[Id] as [Код заказа], [Orders].[IdManager] as [Код сотрудника], [Orders].[IdProduct] as [Код товара], [Products].[ProductName] as [Название товара] " +
                    "FROM [Orders] INNER JOIN [Products] ON [Products].[Id] = [Orders].[IdProduct];";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter(sql, connectionString);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);
                    ProductdataGridView2.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            WelcomePage wel = new WelcomePage();
            wel.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SkladPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string sqlExpression = "INSERT INTO [User] ([IdUserRole], [FirstName], [SureName])" + "VALUES (@Role, @Name, @SureName);";
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);
                    sqlCommand.Parameters.AddWithValue("@Role", RolecomboBox1.SelectedIndex + 1);
                    sqlCommand.Parameters.AddWithValue("@Name", NametextBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@Surename", SurenametextBox2.Text);


                    int number = sqlCommand.ExecuteNonQuery();
                    if (number >= 1)
                    {
                        MessageBox.Show("Сотрудник добавлен!");
                        SkladPage sklad = new SkladPage();
                        sklad.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Ошибка");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    
                    string sqlExpression = "DELETE FROM [User] WHERE [Id] = @Id;";

                    
                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);

                    
                    int userId;
                    if (int.TryParse(IdtextBox3.Text, out userId)) // для ввода ID пользователя
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", userId);

                        // Выполняем запрос
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пользователь успешно удален!");
                            SkladPage sklad = new SkladPage();
                            sklad.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден или не может быть удален.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, введите корректный числовой ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();


                    string sqlExpression = "UPDATE [User] SET [IdUserRole] = @Role, [FirstName] = @Name, [SureName] = @Surename WHERE [Id] = @Id;";

                    OleDbCommand sqlCommand = new OleDbCommand(sqlExpression, connection);

                    
                    int userId = Convert.ToInt32(ManagerdataGridView1.SelectedRows[0].Cells["Id"].Value); ;

                    sqlCommand.Parameters.AddWithValue("@Role", RolecomboBox1.SelectedIndex + 1);
                    sqlCommand.Parameters.AddWithValue("@Name", NametextBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@Surename", SurenametextBox2.Text);
                    sqlCommand.Parameters.AddWithValue("@Id", userId);
                    
                    int number = sqlCommand.ExecuteNonQuery();
                    if (number >= 1)
                    {
                        MessageBox.Show("Таблица обновлена");
                        SkladPage sklad = new SkladPage();
                        sklad.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: ничего не обновлено.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
