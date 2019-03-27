namespace PetShopSystemEF
{
    partial class CagesForm
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
            this.cagesDeletebutton = new System.Windows.Forms.Button();
            this.newCageButton = new System.Windows.Forms.Button();
            this.cagesDataGridView = new System.Windows.Forms.DataGridView();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageSquareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageShopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cagesDeletebutton
            // 
            this.cagesDeletebutton.Location = new System.Drawing.Point(284, 167);
            this.cagesDeletebutton.MaximumSize = new System.Drawing.Size(107, 23);
            this.cagesDeletebutton.MinimumSize = new System.Drawing.Size(107, 23);
            this.cagesDeletebutton.Name = "cagesDeletebutton";
            this.cagesDeletebutton.Size = new System.Drawing.Size(107, 23);
            this.cagesDeletebutton.TabIndex = 5;
            this.cagesDeletebutton.Text = "Видалити";
            this.cagesDeletebutton.UseVisualStyleBackColor = true;
            this.cagesDeletebutton.Click += new System.EventHandler(this.cagesDeletebutton_Click);
            // 
            // newCageButton
            // 
            this.newCageButton.Location = new System.Drawing.Point(28, 29);
            this.newCageButton.Name = "newCageButton";
            this.newCageButton.Size = new System.Drawing.Size(155, 23);
            this.newCageButton.TabIndex = 4;
            this.newCageButton.Text = "Додати нову клітку";
            this.newCageButton.UseVisualStyleBackColor = true;
            this.newCageButton.Click += new System.EventHandler(this.newCageButton_Click);
            // 
            // cagesDataGridView
            // 
            this.cagesDataGridView.AllowUserToAddRows = false;
            this.cagesDataGridView.AutoGenerateColumns = false;
            this.cagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalDataGridViewTextBoxColumn,
            this.cageNumberDataGridViewTextBoxColumn,
            this.cageSquareDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn,
            this.cageIdDataGridViewTextBoxColumn,
            this.cageShopIdDataGridViewTextBoxColumn});
            this.cagesDataGridView.DataSource = this.cageBindingSource;
            this.cagesDataGridView.Location = new System.Drawing.Point(28, 167);
            this.cagesDataGridView.Name = "cagesDataGridView";
            this.cagesDataGridView.Size = new System.Drawing.Size(246, 191);
            this.cagesDataGridView.TabIndex = 3;
            // 
            // animalDataGridViewTextBoxColumn
            // 
            this.animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            this.animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            this.animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            this.animalDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageNumberDataGridViewTextBoxColumn
            // 
            this.cageNumberDataGridViewTextBoxColumn.DataPropertyName = "Cage_Number";
            this.cageNumberDataGridViewTextBoxColumn.HeaderText = "Номер клітки";
            this.cageNumberDataGridViewTextBoxColumn.Name = "cageNumberDataGridViewTextBoxColumn";
            this.cageNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cageSquareDataGridViewTextBoxColumn
            // 
            this.cageSquareDataGridViewTextBoxColumn.DataPropertyName = "Cage_Square";
            this.cageSquareDataGridViewTextBoxColumn.HeaderText = "Площа клітки";
            this.cageSquareDataGridViewTextBoxColumn.Name = "cageSquareDataGridViewTextBoxColumn";
            this.cageSquareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "Shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Shop";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            this.shopDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageIdDataGridViewTextBoxColumn
            // 
            this.cageIdDataGridViewTextBoxColumn.DataPropertyName = "Cage_Id";
            this.cageIdDataGridViewTextBoxColumn.HeaderText = "Cage_Id";
            this.cageIdDataGridViewTextBoxColumn.Name = "cageIdDataGridViewTextBoxColumn";
            this.cageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageShopIdDataGridViewTextBoxColumn
            // 
            this.cageShopIdDataGridViewTextBoxColumn.DataPropertyName = "Cage_ShopId";
            this.cageShopIdDataGridViewTextBoxColumn.HeaderText = "Cage_ShopId";
            this.cageShopIdDataGridViewTextBoxColumn.Name = "cageShopIdDataGridViewTextBoxColumn";
            this.cageShopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageBindingSource
            // 
            this.cageBindingSource.DataSource = typeof(AnimalsClassLibrary.Cage);
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(AnimalsClassLibrary.Shop);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(28, 59);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(155, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(28, 86);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(155, 20);
            this.squareTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер нової клітки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Площа нової клітки";
            // 
            // CagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squareTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.cagesDeletebutton);
            this.Controls.Add(this.newCageButton);
            this.Controls.Add(this.cagesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CagesForm";
            this.Text = "CagesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CagesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.cagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cagesDeletebutton;
        private System.Windows.Forms.Button newCageButton;
        private System.Windows.Forms.DataGridView cagesDataGridView;
        private System.Windows.Forms.BindingSource cageBindingSource;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageSquareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageShopIdDataGridViewTextBoxColumn;
    }
}