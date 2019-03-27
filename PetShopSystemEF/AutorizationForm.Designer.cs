namespace PetShopSystemEF
{
    partial class AutorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.enterButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.forgetPasswordButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteUserbutton = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new PetShopSystemEF.UsersDataSetTableAdapters.QueriesTableAdapter();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            loginLabel.Location = new System.Drawing.Point(186, 63);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(49, 20);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Логін";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            passwordLabel.Location = new System.Drawing.Point(186, 135);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(67, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Пароль";
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterButton.Location = new System.Drawing.Point(190, 210);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(168, 28);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Вхід";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registrationButton.Location = new System.Drawing.Point(405, 12);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(198, 27);
            this.registrationButton.TabIndex = 1;
            this.registrationButton.Text = "Рєстрація";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginTextBox.Location = new System.Drawing.Point(190, 86);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(168, 23);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.Click += new System.EventHandler(this.loginTextBox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordTextBox.Location = new System.Drawing.Point(190, 158);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(168, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            // 
            // forgetPasswordButton
            // 
            this.forgetPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.forgetPasswordButton.Location = new System.Drawing.Point(405, 156);
            this.forgetPasswordButton.Name = "forgetPasswordButton";
            this.forgetPasswordButton.Size = new System.Drawing.Size(140, 25);
            this.forgetPasswordButton.TabIndex = 4;
            this.forgetPasswordButton.Text = "Забули пароль?";
            this.forgetPasswordButton.UseVisualStyleBackColor = true;
            this.forgetPasswordButton.Click += new System.EventHandler(this.forgetPasswordButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageLabel.Location = new System.Drawing.Point(84, 38);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 7;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(190, 187);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.showPasswordCheckBox.TabIndex = 8;
            this.showPasswordCheckBox.Text = "Показати пароль";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // deleteUserbutton
            // 
            this.deleteUserbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteUserbutton.Location = new System.Drawing.Point(140, 265);
            this.deleteUserbutton.Name = "deleteUserbutton";
            this.deleteUserbutton.Size = new System.Drawing.Size(278, 30);
            this.deleteUserbutton.TabIndex = 9;
            this.deleteUserbutton.Text = "Видалити користувача з системи";
            this.deleteUserbutton.UseVisualStyleBackColor = true;
            this.deleteUserbutton.Click += new System.EventHandler(this.deleteUserbutton_Click);
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 307);
            this.Controls.Add(this.deleteUserbutton);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.forgetPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.enterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutorizationForm";
            this.Text = "Авторизація";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorizationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button forgetPasswordButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private UsersDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Button deleteUserbutton;
    }
}

