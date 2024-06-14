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

namespace SQLApp
{
    public partial class RegisterForm : Form
    {
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                MessageBox.Show("Введите Фамилию ");
                return;
            }

            else if (NameField.Text == "")
            {
                MessageBox.Show("Введите Имя");
                return;
            }

            else if (LoginField.Text == "")
            {
                MessageBox.Show("Введите Логин ");
                return;
            }
            else if (PassField.Text == "")
            {
                MessageBox.Show("Введите Пароль ");
                return;
            }

            if (CheckUser())
                return;

            DB1 db = new DB1();
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[users] ([login],[password],[surname],[name])" +
                " VALUES (@login,@password,@surname,@name)",
            db.getConnection());

            command.Parameters.Add("@login", SqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = SurnameField.Text;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = NameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь успешно зарегистрирован!");
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрировать пользователя.");

            }

            db.closeConnection();
        }

        public Boolean CheckUser()
        {
            DB1 db = new DB1();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[users] WHERE [login]=@LoginUser ",
                db.getConnection());

            command.Parameters.Add("@LoginUser", SqlDbType.NVarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь c таким логином уже существует,введите другой.");
                return true;
            }

            else
            {
                return false;

            }
        }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;

      
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);


        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

            
        }

       

        private void LoginLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logform = new LoginForm();
            logform.Show();
        }

        private void LoginLabel_MouseEnter(object sender, EventArgs e)
        {
            LoginLabel.ForeColor = Color.Aqua;

        }

        private void LoginLabel_MouseLeave(object sender, EventArgs e)
        {
            LoginLabel.ForeColor = Color.Snow;


        }

       
    }
}
