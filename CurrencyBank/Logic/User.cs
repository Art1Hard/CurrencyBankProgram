using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyBank.Logic
{
    internal class User
    {

        // метод авторизации пользователя
        public static void Avtorization(Form @this, Form open, string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                DataBase dataBase = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                dataBase.Query = $"SELECT ID, UserLogin, UserPassword FROM Users WHERE UserLogin = '{login}' AND UserPassword = '{password}'";
                SqlCommand command = new SqlCommand(dataBase.Query, connection);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успешно!!!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    open.Show();
                    @this.Hide();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль.", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                password = string.Empty;
            }
        }

        // метод регистрации пользователя
        public static void Registration(Form @this, Form open, string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                DataBase dataBase = new DataBase();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                dataBase.Query = $"INSERT INTO Users (UserLogin, UserPassword) VALUES ('{login}', '{password}')";
                SqlCommand commandInsertInto = new SqlCommand(dataBase.Query, connection);

                dataBase.Query = $"SELECT ID, UserLogin, UserPassword FROM Users WHERE UserLogin = '{login}'";
                SqlCommand commandSelect = new SqlCommand(dataBase.Query, connection);

                adapter.SelectCommand = commandSelect;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                    MessageBox.Show("Извините такой пользователь уже есть!");
                else if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
                {
                    commandInsertInto.ExecuteNonQueryAsync();
                    MessageBox.Show($"Вы успешно зарегестрированы как - {login}");
                    @this.Close();
                    open.Show();
                }
                else
                    MessageBox.Show("Логин или пароль пустой, пожалуйста введите что-нибудь!");
                password = string.Empty;
            }
        }
    }
}
