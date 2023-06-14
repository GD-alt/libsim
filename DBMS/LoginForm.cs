using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class LoginForm : Form
    {
        private List<string> logins = new List<string>();

        public LoginForm()
        {
            InitializeComponent();
            logins.Add("whoami:whatisthepassword");
            logins.Add("admin:adminpassword");
            logins.Add("test:t");
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            string letters = "        abcdefghijklmnopsrtuvwxyz0123456789/*-+,.[]{}:;абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Random random = new Random();
            PasswordBox.PasswordChar = letters[random.Next(letters.Length)];

            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordBox.Text) || String.IsNullOrEmpty(LoginBox.Text))
            {
                StatusBar.Text = "Логин или пароль пусты!";
                MessageBox.Show("Логин или пароль пусты!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!logins.Contains($"{LoginBox.Text}:{PasswordBox.Text}"))
            {
                StatusBar.Text = "Неверные данные!";
                MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ViewForm form = new ViewForm(LoginBox.Text, this);
            form.Show();
            Hide();
        }
    }
}
