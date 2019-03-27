using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace PetShopSystemEF
{   

    public partial class RegistrationForm : Form
    {
        private static int myCode;
        private static string email;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Regex emailRegex = new Regex(@"^\S+@(gmail.com|knu.ua|ukr.net|i.ua|bigmir.ua)$");
            email = emailTextBox.Text;
            if (email.Length > 35 || !emailRegex.IsMatch(email))
            {
                messageLabel.Text = "Некорректний або несумісний з системою формат електронної пошти ";
                return;
            }
            int count = (int)queriesTableAdapter1.SQLCountUsersByEmail(email);
            if(count>0)
            {
                messageLabel.Text = "Користувач з такою електронною поштою вже є у системі ";
                return;

            }
            myCode = (new Random()).Next(10000, 99999);
            sendEmail();

            enterButton1.Visible = false;
            emailLabel2.Visible = false;
            enterEmailLabel.Visible = false;
            emailTextBox.Visible = false;

            codeTextBox.Visible = true;
            enterButton2.Visible = true;
            enterEmailagainButton.Visible = true;
            codeLabel.Visible = true;

            return;
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";

        }

        private void sendEmail()
        {
            MailAddress from = new MailAddress("petshopsystemapp@gmail.com", "Pet Shop System");
            // кому отправляем
            MailAddress to = new MailAddress(email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Реєстрація у системі контролю зоомагазинів";
            // текст письма
            m.Body = "<h2>Код реєстріції:"+myCode+"</h2>";
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
            catch(Exception)
            { }

        }

        private void enterEmailagainButton_Click(object sender, EventArgs e)
        {
           

            codeTextBox.Visible = false;
            enterButton2.Visible = false;
            enterEmailagainButton.Visible =false;
            codeLabel.Visible =false;

            enterButton1.Visible = true;
            emailLabel2.Visible = true;
            enterEmailLabel.Visible = true;
            emailTextBox.Visible = true;


            return;

        }

        private void enterButton2_Click(object sender, EventArgs e)
        {
            if(int.Parse(codeTextBox.Text)==myCode)
            {
                codeTextBox.Visible = false;
                enterButton2.Visible = false;
                enterEmailagainButton.Visible = false;
                codeLabel.Visible = false;

                loginLabel.Visible = true;
                loginTextBox.Visible = true;
                passwordLabel.Visible = true;
                passwordTextBox.Visible = true;
                passwordCheckBox.Visible = true;
                registrateButton.Visible = true;
                return;

            }
            messageLabel.Text = "Некорректний код! Введіть ще раз або перевірте адресу електронної пошти ";

        }

        private void codeTextBox_Click(object sender, EventArgs e)
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

        private void registrateButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            if (login.Length < 5 || password.Length < 5)
            {
                messageLabel.Text = "Занадто короткий логін або пароль. Реєстрація неможлива";
                return;
            }
            int count = (int)queriesTableAdapter1.SQLCountUsersByLogin(login);
            if (count > 0)
            {
                messageLabel.Text = "Користувач з таким логіном вже є у системі ";
                return;

            }
            DialogResult dialog = MessageBox.Show(
       "Ви дійсно хочете зареєструвати цього користувача?",
       "зеєстрація нового користувача",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Warning
      );
            if (dialog == DialogResult.Yes)
            {
                queriesTableAdapter1.InsertIntoUsers(login, password, email);
                this.Close();
            }
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void loginTextBox_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }
    }
}

