namespace PetShopSystemEF
{
    partial class NewPasswordForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.enterLoginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new PetShopSystemEF.UsersDataSetTableAdapters.QueriesTableAdapter();
            this.otherLoginButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeButton = new System.Windows.Forms.Button();
            this.otherEmailButton = new System.Windows.Forms.Button();
            this.passwordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(23, 56);
            this.loginTextBox.MaxLength = 20;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(208, 20);
            this.loginTextBox.TabIndex = 0;
            this.loginTextBox.Click += new System.EventHandler(this.loginTextBox_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(23, 40);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(90, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Ведіть свій логін";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(23, 9);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 2;
            // 
            // enterLoginButton
            // 
            this.enterLoginButton.Location = new System.Drawing.Point(291, 53);
            this.enterLoginButton.Name = "enterLoginButton";
            this.enterLoginButton.Size = new System.Drawing.Size(124, 23);
            this.enterLoginButton.TabIndex = 3;
            this.enterLoginButton.Text = "Ввести";
            this.enterLoginButton.UseVisualStyleBackColor = true;
            this.enterLoginButton.Click += new System.EventHandler(this.enterLoginButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(23, 83);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(264, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Введіть адресу електронної пошти(до 35 символів)";
            this.emailLabel.Visible = false;
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(291, 83);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(240, 23);
            this.emailButton.TabIndex = 5;
            this.emailButton.Text = "Відправити код підтвердження";
            this.emailButton.UseVisualStyleBackColor = true;
            this.emailButton.Visible = false;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(23, 100);
            this.emailTextBox.MaxLength = 35;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(208, 20);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.Visible = false;
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            // 
            // otherLoginButton
            // 
            this.otherLoginButton.Location = new System.Drawing.Point(291, 112);
            this.otherLoginButton.Name = "otherLoginButton";
            this.otherLoginButton.Size = new System.Drawing.Size(240, 23);
            this.otherLoginButton.TabIndex = 7;
            this.otherLoginButton.Text = "Ввести інший логін";
            this.otherLoginButton.UseVisualStyleBackColor = true;
            this.otherLoginButton.Visible = false;
            this.otherLoginButton.Click += new System.EventHandler(this.otherLoginButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(23, 147);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(208, 20);
            this.codeTextBox.TabIndex = 8;
            this.codeTextBox.Visible = false;
            this.codeTextBox.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(23, 127);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(346, 13);
            this.codeLabel.TabIndex = 9;
            this.codeLabel.Text = "Введіть код(5 цифр, що були віправлені на вашу електронну пошту)";
            this.codeLabel.Visible = false;
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(291, 144);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(240, 23);
            this.codeButton.TabIndex = 10;
            this.codeButton.Text = "Готово";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Visible = false;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // otherEmailButton
            // 
            this.otherEmailButton.Location = new System.Drawing.Point(291, 174);
            this.otherEmailButton.Name = "otherEmailButton";
            this.otherEmailButton.Size = new System.Drawing.Size(240, 23);
            this.otherEmailButton.TabIndex = 11;
            this.otherEmailButton.Text = "Ввести іншу електронну пошту";
            this.otherEmailButton.UseVisualStyleBackColor = true;
            this.otherEmailButton.Visible = false;
            this.otherEmailButton.Click += new System.EventHandler(this.otherEmailButton_Click);
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(291, 242);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(240, 23);
            this.passwordButton.TabIndex = 12;
            this.passwordButton.Text = "Зберегти";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Visible = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(26, 245);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(191, 20);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Visible = false;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(26, 226);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(225, 13);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Введіть новий пароль(від 5 до 20 символів)";
            this.passwordLabel.Visible = false;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Location = new System.Drawing.Point(26, 271);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.passwordCheckBox.TabIndex = 15;
            this.passwordCheckBox.Text = "Показати пароль";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.Visible = false;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.passwordCheckBox_CheckedChanged);
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 321);
            this.Controls.Add(this.passwordCheckBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.otherEmailButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.otherLoginButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.enterLoginButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPasswordForm";
            this.Text = "Відновлення паролю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button enterLoginButton;
        private UsersDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button otherLoginButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button otherEmailButton;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.CheckBox passwordCheckBox;
    }
}