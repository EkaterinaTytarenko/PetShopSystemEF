namespace PetShopSystemEF
{
    partial class FoodForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.foodDeletebutton = new System.Windows.Forms.Button();
            this.newFoodButton = new System.Windows.Forms.Button();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.FoodColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.food1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesFoodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesFoodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Оберіть нову їжу";
            // 
            // foodDeletebutton
            // 
            this.foodDeletebutton.Location = new System.Drawing.Point(200, 110);
            this.foodDeletebutton.MaximumSize = new System.Drawing.Size(107, 23);
            this.foodDeletebutton.MinimumSize = new System.Drawing.Size(107, 23);
            this.foodDeletebutton.Name = "foodDeletebutton";
            this.foodDeletebutton.Size = new System.Drawing.Size(107, 23);
            this.foodDeletebutton.TabIndex = 12;
            this.foodDeletebutton.Text = "Видалити";
            this.foodDeletebutton.UseVisualStyleBackColor = true;
            this.foodDeletebutton.Click += new System.EventHandler(this.foodDeletebutton_Click);
            // 
            // newFoodButton
            // 
            this.newFoodButton.Location = new System.Drawing.Point(21, 9);
            this.newFoodButton.Name = "newFoodButton";
            this.newFoodButton.Size = new System.Drawing.Size(155, 23);
            this.newFoodButton.TabIndex = 11;
            this.newFoodButton.Text = "Додати нову їжу";
            this.newFoodButton.UseVisualStyleBackColor = true;
            this.newFoodButton.Click += new System.EventHandler(this.newFoodButton_Click);
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AllowUserToAddRows = false;
            this.foodDataGridView.AutoGenerateColumns = false;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodColumn,
            this.food1DataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.speciesFoodIdDataGridViewTextBoxColumn,
            this.speciesIdDataGridViewTextBoxColumn,
            this.foodIdDataGridViewTextBoxColumn});
            this.foodDataGridView.DataSource = this.speciesFoodBindingSource;
            this.foodDataGridView.Location = new System.Drawing.Point(21, 110);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.Size = new System.Drawing.Size(144, 208);
            this.foodDataGridView.TabIndex = 10;
            this.foodDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.foodDataGridView_DataError);
            // 
            // FoodColumn
            // 
            this.FoodColumn.DataPropertyName = "Food_Id";
            this.FoodColumn.DataSource = this.food1BindingSource;
            this.FoodColumn.DisplayMember = "Food_Name";
            this.FoodColumn.HeaderText = "Їжа";
            this.FoodColumn.Name = "FoodColumn";
            this.FoodColumn.ReadOnly = true;
            this.FoodColumn.ValueMember = "Food_Id";
            // 
            // food1BindingSource
            // 
            this.food1BindingSource.DataSource = typeof(AnimalsClassLibrary.Food1);
            // 
            // food1DataGridViewTextBoxColumn
            // 
            this.food1DataGridViewTextBoxColumn.DataPropertyName = "Food1";
            this.food1DataGridViewTextBoxColumn.HeaderText = "Food1";
            this.food1DataGridViewTextBoxColumn.Name = "food1DataGridViewTextBoxColumn";
            this.food1DataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesFoodIdDataGridViewTextBoxColumn
            // 
            this.speciesFoodIdDataGridViewTextBoxColumn.DataPropertyName = "SpeciesFood_Id";
            this.speciesFoodIdDataGridViewTextBoxColumn.HeaderText = "SpeciesFood_Id";
            this.speciesFoodIdDataGridViewTextBoxColumn.Name = "speciesFoodIdDataGridViewTextBoxColumn";
            this.speciesFoodIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesIdDataGridViewTextBoxColumn
            // 
            this.speciesIdDataGridViewTextBoxColumn.DataPropertyName = "Species_Id";
            this.speciesIdDataGridViewTextBoxColumn.HeaderText = "Species_Id";
            this.speciesIdDataGridViewTextBoxColumn.Name = "speciesIdDataGridViewTextBoxColumn";
            this.speciesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // foodIdDataGridViewTextBoxColumn
            // 
            this.foodIdDataGridViewTextBoxColumn.DataPropertyName = "Food_Id";
            this.foodIdDataGridViewTextBoxColumn.HeaderText = "Food_Id";
            this.foodIdDataGridViewTextBoxColumn.Name = "foodIdDataGridViewTextBoxColumn";
            this.foodIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesFoodBindingSource
            // 
            this.speciesFoodBindingSource.DataSource = typeof(AnimalsClassLibrary.SpeciesFood);
            // 
            // foodComboBox
            // 
            this.foodComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.food1BindingSource, "Food_Name", true));
            this.foodComboBox.DataSource = this.food1BindingSource;
            this.foodComboBox.DisplayMember = "Food_Name";
            this.foodComboBox.FormattingEnabled = true;
            this.foodComboBox.Location = new System.Drawing.Point(21, 36);
            this.foodComboBox.Name = "foodComboBox";
            this.foodComboBox.Size = new System.Drawing.Size(155, 21);
            this.foodComboBox.TabIndex = 16;
            this.foodComboBox.ValueMember = "Food_Name";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 350);
            this.Controls.Add(this.foodComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.foodDeletebutton);
            this.Controls.Add(this.newFoodButton);
            this.Controls.Add(this.foodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FoodForm";
            this.Text = "Їжа для обраного виду";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FoodForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesFoodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button foodDeletebutton;
        private System.Windows.Forms.Button newFoodButton;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.BindingSource food1BindingSource;
        private System.Windows.Forms.BindingSource speciesFoodBindingSource;
        private System.Windows.Forms.ComboBox foodComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn FoodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn food1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesFoodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIdDataGridViewTextBoxColumn;
    }
}