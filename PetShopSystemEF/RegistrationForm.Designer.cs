namespace PetShopSystemEF
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enterEmailLabel = new System.Windows.Forms.Label();
            this.enterButton1 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.emailLabel2 = new System.Windows.Forms.Label();
            this.enterButton2 = new System.Windows.Forms.Button();
            this.enterEmailagainButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.registrateButton = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new PetShopSystemEF.UsersDataSetTableAdapters.QueriesTableAdapter();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(50, 57);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(323, 20);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            // 
            // enterEmailLabel
            // 
            this.enterEmailLabel.AutoSize = true;
            this.enterEmailLabel.Location = new System.Drawing.Point(47, 41);
            this.enterEmailLabel.Name = "enterEmailLabel";
            this.enterEmailLabel.Size = new System.Drawing.Size(264, 13);
            this.enterEmailLabel.TabIndex = 4;
            this.enterEmailLabel.Text = "Введіть адресу електронної пошти(до 35 символів)";
            // 
            // enterButton1
            // 
            this.enterButton1.Location = new System.Drawing.Point(411, 54);
            this.enterButton1.Name = "enterButton1";
            this.enterButton1.Size = new System.Drawing.Size(229, 23);
            this.enterButton1.TabIndex = 8;
            this.enterButton1.Text = "Відправити код підтвердження";
            this.enterButton1.UseVisualStyleBackColor = true;
            this.enterButton1.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(122, 165);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 9;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(50, 113);
            this.codeTextBox.MaxLength = 5;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(323, 20);
            this.codeTextBox.TabIndex = 10;
            this.codeTextBox.Visible = false;
            this.codeTextBox.Click += new System.EventHandler(this.codeTextBox_Click);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(47, 97);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(346, 13);
            this.codeLabel.TabIndex = 11;
            this.codeLabel.Text = "Введіть код(5 цифр, що були віправлені на вашу електронну пошту)";
            this.codeLabel.Visible = false;
            // 
            // emailLabel2
            // 
            this.emailLabel2.AutoSize = true;
            this.emailLabel2.Location = new System.Drawing.Point(50, 84);
            this.emailLabel2.Name = "emailLabel2";
            this.emailLabel2.Size = new System.Drawing.Size(295, 13);
            this.emailLabel2.TabIndex = 12;
            this.emailLabel2.Text = "Допустимі формати:gmail.com,knu.ua,ukr.net,i.ua,bigmir.ua";
            // 
            // enterButton2
            // 
            this.enterButton2.Location = new System.Drawing.Point(411, 97);
            this.enterButton2.Name = "enterButton2";
            this.enterButton2.Size = new System.Drawing.Size(229, 23);
            this.enterButton2.TabIndex = 13;
            this.enterButton2.TabStop = false;
            this.enterButton2.Text = "Готово";
            this.enterButton2.UseVisualStyleBackColor = true;
            this.enterButton2.Visible = false;
            this.enterButton2.Click += new System.EventHandler(this.enterButton2_Click);
            // 
            // enterEmailagainButton
            // 
            this.enterEmailagainButton.Location = new System.Drawing.Point(411, 132);
            this.enterEmailagainButton.Name = "enterEmailagainButton";
            this.enterEmailagainButton.Size = new System.Drawing.Size(229, 23);
            this.enterEmailagainButton.TabIndex = 14;
            this.enterEmailagainButton.Text = "Ввести іншу пошту";
            this.enterEmailagainButton.UseVisualStyleBackColor = true;
            this.enterEmailagainButton.Visible = false;
            this.enterEmailagainButton.Click += new System.EventHandler(this.enterEmailagainButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(53, 230);
            this.loginTextBox.MaxLength = 20;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(195, 20);
            this.loginTextBox.TabIndex = 15;
            this.loginTextBox.Visible = false;
            this.loginTextBox.Click += new System.EventHandler(this.loginTextBox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(374, 230);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Visible = false;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Location = new System.Drawing.Point(374, 254);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.passwordCheckBox.TabIndex = 17;
            this.passwordCheckBox.Text = "Показати пароль";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.Visible = false;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.passwordCheckBox_CheckedChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(50, 206);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(181, 13);
            this.loginLabel.TabIndex = 18;
            this.loginLabel.Text = "Введіть логін(від 5 до 20 символів)";
            this.loginLabel.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(371, 206);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(192, 13);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Введіть пароль(від 5 до 20 символів)";
            this.passwordLabel.Visible = false;
            // 
            // registrateButton
            // 
            this.registrateButton.Location = new System.Drawing.Point(216, 277);
            this.registrateButton.Name = "registrateButton";
            this.registrateButton.Size = new System.Drawing.Size(177, 23);
            this.registrateButton.TabIndex = 20;
            this.registrateButton.Text = "Зареєструватися";
            this.registrateButton.UseVisualStyleBackColor = true;
            this.registrateButton.Visible = false;
            this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(this.registrateButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.enterEmailagainButton);
            this.Controls.Add(this.enterButton2);
            this.Controls.Add(this.emailLabel2);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.enterButton1);
            this.Controls.Add(this.enterEmailLabel);
            this.Controls.Add(this.emailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegistrationForm";
            this.Text = "Реєстрація нового користувача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button enterButton1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label enterEmailLabel;
        private System.Windows.Forms.Label emailLabel2;
        private System.Windows.Forms.Button enterButton2;
        private System.Windows.Forms.Button enterEmailagainButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button registrateButton;
        private UsersDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}