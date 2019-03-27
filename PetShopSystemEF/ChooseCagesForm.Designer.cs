namespace PetShopSystemEF
{
    partial class ChooseCagesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label textLabel;
            this.chooseCagesButton = new System.Windows.Forms.Button();
            this.cageNumsComboBox = new System.Windows.Forms.ComboBox();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            textLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(148, 114);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(319, 13);
            textLabel.TabIndex = 5;
            textLabel.Text = "Оберіть для своєї тварини одну з кліток в обраному магазині";
            // 
            // chooseCagesButton
            // 
            this.chooseCagesButton.Location = new System.Drawing.Point(222, 225);
            this.chooseCagesButton.Name = "chooseCagesButton";
            this.chooseCagesButton.Size = new System.Drawing.Size(121, 23);
            this.chooseCagesButton.TabIndex = 4;
            this.chooseCagesButton.Text = "Ок";
            this.chooseCagesButton.UseVisualStyleBackColor = true;
            this.chooseCagesButton.Click += new System.EventHandler(this.chooseCagesButton_Click);
            // 
            // cageNumsComboBox
            // 
            this.cageNumsComboBox.DataSource = this.cageBindingSource;
            this.cageNumsComboBox.DisplayMember = "Cage_Number";
            this.cageNumsComboBox.FormattingEnabled = true;
            this.cageNumsComboBox.Location = new System.Drawing.Point(222, 162);
            this.cageNumsComboBox.Name = "cageNumsComboBox";
            this.cageNumsComboBox.Size = new System.Drawing.Size(121, 21);
            this.cageNumsComboBox.TabIndex = 3;
            this.cageNumsComboBox.ValueMember = "Cage_Number";
            // 
            // cageBindingSource
            // 
            this.cageBindingSource.DataSource = typeof(AnimalsClassLibrary.Cage);
            // 
            // ChooseCagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 313);
            this.Controls.Add(textLabel);
            this.Controls.Add(this.chooseCagesButton);
            this.Controls.Add(this.cageNumsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseCagesForm";
            this.Text = "ChooseCagesForm";
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseCagesButton;
        private System.Windows.Forms.ComboBox cageNumsComboBox;
        private System.Windows.Forms.BindingSource cageBindingSource;
    }
}