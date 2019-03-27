using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopSystemEF
{
    public partial class NewPasswordForm : Form
    {
        private static string login;
        private static string email;
        private static int myCode;

        public NewPasswordForm()
        {
            InitializeComponent();
        }

        private void enterLoginButton_Click(object sender, EventArgs e)
        {
            login = loginTextBox.Text;
            if (loginTextBox.Text.Length<5)
            {
                messageLabel.Text = "Введено занадто короткий логін";
                return;
            }
            int counter = (int)queriesTableAdapter1.SQLCountUsersByLogin(loginTextBox.Text);
            if(counter==0)
            {
                messageLabel.Text = "Користувач з лгогіном "+ login +" не був знайдений у системі";
                return;
            }

            enterLoginButton.Visible = false;
            loginTextBox.Visible = false;
            loginLabel.Visible = false;

            emailButton.Visible = true;
            emailLabel.Visible = true;
            emailTextBox.Visible = true;
            otherLoginButton.Visible = true;
        }

        private void loginTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^\S+@(gmail.com|knu.ua|ukr.net|i.ua|bigmir.ua)$");
            email = emailTextBox.Text;
            if (!emailRegex.IsMatch(email))
            {
                messageLabel.Text = "Некорректний або несумісний з системою формат електронної пошти ";
                return;
            }
            string emailFromDB = queriesTableAdapter1.SQLFindEmailByLogin(login);
            int c = 35 - email.Length;
            for (int i = 0; i < c; ++i)
                email += " ";
            if (email!= emailFromDB)
            {
                messageLabel.Text = "Введена електронна пошта не відповідає логіну";
                return;

            }
            myCode = (new Random()).Next(10000, 99999);
            sendEmail();

            emailButton.Visible = false;
            emailLabel.Visible = false;
            emailTextBox.Visible = false;
            otherLoginButton.Visible = false;

            
            codeTextBox.Visible = true;
            codeButton.Visible = true;
            otherEmailButton.Visible = true;
            codeLabel.Visible = true;

            return;
        }

        private void sendEmail()
        {
            MailAddress from = new MailAddress("petshopsystemapp@gmail.com", "Pet Shop System");
            // кому отправляем
            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Відновлення паролю у системі контролю зоомагазинів";
            // текст письма
            m.Body = "<h2>Код підтвердження:" + myCode + "</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("petshopsystemapp@gmail.com", "petspets");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(m);
            }
            catch (Exception)
            { }

        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void otherLoginButton_Click(object sender, EventArgs e)
        {
            enterLoginButton.Visible = true;
            loginTextBox.Visible = true;
            loginLabel.Visible = true;

            emailButton.Visible = false;
            emailLabel.Visible = false;
            emailTextBox.Visible = false;
            otherLoginButton.Visible = false;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void otherEmailButton_Click(object sender, EventArgs e)
        {
            emailButton.Visible = true;
            emailLabel.Visible = true;
            emailTextBox.Visible = true;
            otherLoginButton.Visible = true;


            codeTextBox.Visible = false;
            codeButton.Visible =false;
            otherEmailButton.Visible = false;
            codeLabel.Visible = false;

        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(codeTextBox.Text) == myCode)
            {
                codeTextBox.Visible = false;
                codeButton.Visible = false;
                otherEmailButton.Visible = false;
                codeLabel.Visible = false;

                
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                passwordCheckBox.Visible = true;
                passwordButton.Visible = true;
                return;

            }
            messageLabel.Text = "Некорректний код! Введіть ще раз або перевірте адресу електронної пошти ";

        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private void passwordButton_Click(object sender, EventArgs e)
        { 
            string password = passwordTextBox.Text;
            if (password.Length < 5)
            {
                messageLabel.Text = "Занадто короткий пароль";
                return;
            }
            DialogResult dialog = MessageBox.Show(
    "Ви дійсно хочете зберегти цей пароль?",
    "Зміна паролю",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning
   );
            if (dialog == DialogResult.Yes)
            {
                queriesTableAdapter1.DeleteUser(login);
                queriesTableAdapter1.InsertIntoUsers(login, password, email);
                this.Close();
            }
        }
    }

    
}
