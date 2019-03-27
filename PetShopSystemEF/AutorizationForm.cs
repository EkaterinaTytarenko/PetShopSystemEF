using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopSystemEF
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string password = queriesTableAdapter1.SQLFindPasswordByLogin(loginTextBox.Text);
            if (password == null)
            {
                messageLabel.Text = "Користувач з логіном " + loginTextBox.Text +" не був знайдений у системі";
                return;
            }
            string passwordText = passwordTextBox.Text;
            int c = 20 - passwordTextBox.Text.Length;
            for (int i = 0; i < c; ++i)
                passwordText += " ";
            if (password != passwordText)
            {   messageLabel.Text = "Невіно вказаний пароль";
                return;
            }

            MainForm mainForm = new MainForm();
            mainForm.ShowDialog(this);            
            mainForm.Dispose();
            
            
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog(this);
            registrationForm.Dispose();

        }

        private void deleteUserbutton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
    "Ви дійсно хочете видалити користувача з логіном "+ loginTextBox.Text+"?",
    "Видалення користувача з системи",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
   );
            if (dialog == DialogResult.Yes)
            {
                string password = queriesTableAdapter1.SQLFindPasswordByLogin(loginTextBox.Text);
                if (password == null)
                {
                    messageLabel.Text = "Користувач з логіном " + loginTextBox.Text + " не був знайдений у системі";
                    return;
                }
                string passwordText = passwordTextBox.Text;
                int c = 20 - passwordTextBox.Text.Length;
                for (int i = 0; i < c; ++i)
                    passwordText += " ";
                if (password != passwordText)
                {
                    messageLabel.Text = "Невіно вказаний пароль";
                    return;
                }
                queriesTableAdapter1.DeleteUser(loginTextBox.Text);
                messageLabel.Text = "Користувач з логіном " + loginTextBox.Text + " був видалений з системи";

            }
            
        }

        private void loginTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            NewPasswordForm newPasswordForm = new NewPasswordForm();
            newPasswordForm.ShowDialog(this);
            newPasswordForm.Dispose();

        }

        private void AutorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
    "Ви дійсно хочете вийти з програми?",
    "Завершення програми",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
   );
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
