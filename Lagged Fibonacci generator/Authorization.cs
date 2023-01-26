using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lagged_Fibonacci_generator
{
    public partial class Authorization : Form
    {
        static bool B = true;
        DataBase db;
        public Authorization()
        {
            InitializeComponent();
            db = new DataBase();
        }
        public bool CheckUser(string nickname)
        {
            List<User> users = db.Users.ToList();
            foreach (User user in users)
            {
                if (nickname == user.Nickname) return true;
            }
            return false;
        }
        public bool CheckUserNP(string nickname, string password)
        {
            if (CheckUser(nickname) == true)
            {
                User user = null;
                using (DataBase context = new DataBase())
                {
                    user = db.Users.Where(t => t.Nickname == nickname && t.Password == password).FirstOrDefault();
                }
                if (user != null) return true;
                else { MessageBox.Show("Неверный пароль"); return false; }
            }
            else { MessageBox.Show("Пользователь не найден"); return false; }
        }
        private void Sign_in_Click(object sender, EventArgs e)
        {
            if (Nickname.Text == "") MessageBox.Show("Введите Nickname");
            else if (Nickname.Text.Length < 4) { MessageBox.Show("Минимальная длина Nickname 4 символа."); }
            if (Password.Text == "") MessageBox.Show("Введите Password");
            else if (Password.TextLength < 4) { MessageBox.Show("Минимальная длина Password 4 символа."); }
            if (Nickname.Text != "" && Password.Text != "" && Nickname.Text.Length >= 4 && Password.Text.Length >= 4)
            {
                string nickname = Nickname.Text;
                string password = Hash(Password.Text);
                if (CheckUserNP(nickname, password) == true) { DialogResult authDialogResult = new LFG().ShowDialog(); }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (B == false) { Password.PasswordChar = '\0'; Hide.Image = Properties.Resources.show; B = true; }
            else { Password.PasswordChar = '*'; Hide.Image = Properties.Resources.blind; B = false; }
        }
        private void Sign_up_Click(object sender, EventArgs e)
        {
            DialogResult authDialogResult = new Registration().ShowDialog();
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password.Text != null) { Password.PasswordChar = '*'; Hide.Image = Properties.Resources.blind; B = false; }
        }
        private void Nickname_TextChanged(object sender, EventArgs e) { }
        private string Hash(string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash) { sb.Append(b.ToString("x2")); }
                return sb.ToString();
            }
        }
        private void Nickname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }
    }
}
