namespace PetShopSystemEF
{
    partial class SearchForm
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
            this.maxYearTextBox = new System.Windows.Forms.TextBox();
            this.minYearTextBox = new System.Windows.Forms.TextBox();
            this.maxYearLabel = new System.Windows.Forms.Label();
            this.minYearLabel = new System.Windows.Forms.Label();
            this.yearCheckBox = new System.Windows.Forms.CheckBox();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.speciesComboBox = new System.Windows.Forms.ComboBox();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsComboBox = new System.Windows.Forms.ComboBox();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.speciesSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.shopSearchRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsSexColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalShopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsShopColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalCageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSpeciesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsSpeciesColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalColorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsColorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maxYearTextBox
            // 
            this.maxYearTextBox.Location = new System.Drawing.Point(391, 109);
            this.maxYearTextBox.Name = "maxYearTextBox";
            this.maxYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxYearTextBox.TabIndex = 33;
            this.maxYearTextBox.Visible = false;
            // 
            // minYearTextBox
            // 
            this.minYearTextBox.Location = new System.Drawing.Point(244, 109);
            this.minYearTextBox.Name = "minYearTextBox";
            this.minYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.minYearTextBox.TabIndex = 32;
            this.minYearTextBox.Visible = false;
            // 
            // maxYearLabel
            // 
            this.maxYearLabel.AutoSize = true;
            this.maxYearLabel.Location = new System.Drawing.Point(388, 132);
            this.maxYearLabel.Name = "maxYearLabel";
            this.maxYearLabel.Size = new System.Drawing.Size(100, 13);
            this.maxYearLabel.TabIndex = 31;
            this.maxYearLabel.Text = "максимальний рік";
            this.maxYearLabel.Visible = false;
            // 
            // minYearLabel
            // 
            this.minYearLabel.AutoSize = true;
            this.minYearLabel.Location = new System.Drawing.Point(241, 133);
            this.minYearLabel.Name = "minYearLabel";
            this.minYearLabel.Size = new System.Drawing.Size(86, 13);
            this.minYearLabel.TabIndex = 30;
            this.minYearLabel.Text = "мінімальний рік";
            this.minYearLabel.Visible = false;
            // 
            // yearCheckBox
            // 
            this.yearCheckBox.AutoSize = true;
            this.yearCheckBox.Location = new System.Drawing.Point(20, 109);
            this.yearCheckBox.Name = "yearCheckBox";
            this.yearCheckBox.Size = new System.Drawing.Size(205, 17);
            this.yearCheckBox.TabIndex = 29;
            this.yearCheckBox.Text = "Фільтрувати за роком народження";
            this.yearCheckBox.UseVisualStyleBackColor = true;
            this.yearCheckBox.CheckedChanged += new System.EventHandler(this.yearCheckBox_CheckedChanged);
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Location = new System.Drawing.Point(385, 72);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(100, 13);
            this.maxPriceLabel.TabIndex = 28;
            this.maxPriceLabel.Text = "максимальна ціна";
            this.maxPriceLabel.Visible = false;
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.Location = new System.Drawing.Point(191, 69);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(86, 13);
            this.minPriceLabel.TabIndex = 27;
            this.minPriceLabel.Text = "мінімальна ціна";
            this.minPriceLabel.Visible = false;
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(385, 45);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(117, 20);
            this.maxPriceTextBox.TabIndex = 26;
            this.maxPriceTextBox.Visible = false;
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Location = new System.Drawing.Point(194, 46);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.minPriceTextBox.TabIndex = 25;
            this.minPriceTextBox.Visible = false;
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.DataSource = this.speciesBindingSource;
            this.speciesComboBox.DisplayMember = "Species_Name";
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(596, 12);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(121, 21);
            this.speciesComboBox.TabIndex = 24;
            this.speciesComboBox.ValueMember = "Species_Name";
            this.speciesComboBox.Visible = false;
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataSource = typeof(AnimalsClassLibrary.Species);
            // 
            // shopsComboBox
            // 
            this.shopsComboBox.DataSource = this.shopBindingSource;
            this.shopsComboBox.DisplayMember = "Shop_Name";
            this.shopsComboBox.FormattingEnabled = true;
            this.shopsComboBox.Location = new System.Drawing.Point(194, 12);
            this.shopsComboBox.Name = "shopsComboBox";
            this.shopsComboBox.Size = new System.Drawing.Size(121, 21);
            this.shopsComboBox.TabIndex = 23;
            this.shopsComboBox.ValueMember = "Shop_Name";
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(AnimalsClassLibrary.Shop);
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Location = new System.Drawing.Point(20, 46);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(136, 17);
            this.priceCheckBox.TabIndex = 22;
            this.priceCheckBox.Text = "Фільтрувати за ціною";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.CheckedChanged += new System.EventHandler(this.priceCheckBox_CheckedChanged);
            // 
            // speciesSearchRadioButton
            // 
            this.speciesSearchRadioButton.AutoSize = true;
            this.speciesSearchRadioButton.Location = new System.Drawing.Point(385, 12);
            this.speciesSearchRadioButton.Name = "speciesSearchRadioButton";
            this.speciesSearchRadioButton.Size = new System.Drawing.Size(146, 17);
            this.speciesSearchRadioButton.TabIndex = 21;
            this.speciesSearchRadioButton.Text = "Пошук тварин за видом";
            this.speciesSearchRadioButton.UseVisualStyleBackColor = true;
            this.speciesSearchRadioButton.CheckedChanged += new System.EventHandler(this.speciesSearchRadioButton_CheckedChanged);
            // 
            // shopSearchRadioButton
            // 
            this.shopSearchRadioButton.AutoSize = true;
            this.shopSearchRadioButton.Checked = true;
            this.shopSearchRadioButton.Location = new System.Drawing.Point(20, 12);
            this.shopSearchRadioButton.Name = "shopSearchRadioButton";
            this.shopSearchRadioButton.Size = new System.Drawing.Size(133, 17);
            this.shopSearchRadioButton.TabIndex = 20;
            this.shopSearchRadioButton.TabStop = true;
            this.shopSearchRadioButton.Text = "Пошук за магазином";
            this.shopSearchRadioButton.UseVisualStyleBackColor = true;
            this.shopSearchRadioButton.CheckedChanged += new System.EventHandler(this.shopSearchRadioButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(20, 162);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 23);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "Шукати";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(AnimalsClassLibrary.Animal);
            // 
            // animalsDataGridView
            // 
            this.animalsDataGridView.AutoGenerateColumns = false;
            this.animalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIdDataGridViewTextBoxColumn,
            this.animalNameDataGridViewTextBoxColumn,
            this.animalSexDataGridViewTextBoxColumn,
            this.animalsSexColumn,
            this.animalShopIdDataGridViewTextBoxColumn,
            this.animalsShopColumn,
            this.animalCageIdDataGridViewTextBoxColumn,
            this.animalSpeciesIdDataGridViewTextBoxColumn,
            this.animalsSpeciesColumn,
            this.animalDateDataGridViewTextBoxColumn,
            this.animalColorIdDataGridViewTextBoxColumn,
            this.animalsColorColumn,
            this.animalPriceDataGridViewTextBoxColumn,
            this.cageDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn});
            this.animalsDataGridView.DataSource = this.animalBindingSource;
            this.animalsDataGridView.Location = new System.Drawing.Point(20, 191);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.ReadOnly = true;
            this.animalsDataGridView.Size = new System.Drawing.Size(755, 266);
            this.animalsDataGridView.TabIndex = 34;
            this.animalsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.animalsDataGridView_DataError);
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(AnimalsClassLibrary.Color);
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_Id";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "Animal_Id";
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalNameDataGridViewTextBoxColumn
            // 
            this.animalNameDataGridViewTextBoxColumn.DataPropertyName = "Animal_Name";
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я тварини";
            this.animalNameDataGridViewTextBoxColumn.Name = "animalNameDataGridViewTextBoxColumn";
            this.animalNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalSexDataGridViewTextBoxColumn
            // 
            this.animalSexDataGridViewTextBoxColumn.DataPropertyName = "Animal_Sex";
            this.animalSexDataGridViewTextBoxColumn.HeaderText = "Animal_Sex";
            this.animalSexDataGridViewTextBoxColumn.Name = "animalSexDataGridViewTextBoxColumn";
            this.animalSexDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalSexDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsSexColumn
            // 
            this.animalsSexColumn.DataPropertyName = "Animal_Sex";
            this.animalsSexColumn.HeaderText = "Стать";
            this.animalsSexColumn.Items.AddRange(new object[] {
            "Ч",
            "Ж",
            "-"});
            this.animalsSexColumn.Name = "animalsSexColumn";
            this.animalsSexColumn.ReadOnly = true;
            // 
            // animalShopIdDataGridViewTextBoxColumn
            // 
            this.animalShopIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_ShopId";
            this.animalShopIdDataGridViewTextBoxColumn.HeaderText = "Animal_ShopId";
            this.animalShopIdDataGridViewTextBoxColumn.Name = "animalShopIdDataGridViewTextBoxColumn";
            this.animalShopIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalShopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsShopColumn
            // 
            this.animalsShopColumn.DataPropertyName = "Animal_ShopId";
            this.animalsShopColumn.DataSource = this.shopBindingSource;
            this.animalsShopColumn.DisplayMember = "Shop_Name";
            this.animalsShopColumn.HeaderText = "Назва магазину";
            this.animalsShopColumn.Name = "animalsShopColumn";
            this.animalsShopColumn.ReadOnly = true;
            this.animalsShopColumn.ValueMember = "Shop_Id";
            // 
            // animalCageIdDataGridViewTextBoxColumn
            // 
            this.animalCageIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_CageId";
            this.animalCageIdDataGridViewTextBoxColumn.HeaderText = "Animal_CageId";
            this.animalCageIdDataGridViewTextBoxColumn.Name = "animalCageIdDataGridViewTextBoxColumn";
            this.animalCageIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalCageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalSpeciesIdDataGridViewTextBoxColumn
            // 
            this.animalSpeciesIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_SpeciesId";
            this.animalSpeciesIdDataGridViewTextBoxColumn.HeaderText = "Animal_SpeciesId";
            this.animalSpeciesIdDataGridViewTextBoxColumn.Name = "animalSpeciesIdDataGridViewTextBoxColumn";
            this.animalSpeciesIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalSpeciesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsSpeciesColumn
            // 
            this.animalsSpeciesColumn.DataPropertyName = "Animal_SpeciesId";
            this.animalsSpeciesColumn.DataSource = this.speciesBindingSource;
            this.animalsSpeciesColumn.DisplayMember = "Species_Name";
            this.animalsSpeciesColumn.HeaderText = "Назва виду";
            this.animalsSpeciesColumn.Name = "animalsSpeciesColumn";
            this.animalsSpeciesColumn.ReadOnly = true;
            this.animalsSpeciesColumn.ValueMember = "Species_Id";
            // 
            // animalDateDataGridViewTextBoxColumn
            // 
            this.animalDateDataGridViewTextBoxColumn.DataPropertyName = "Animal_Date";
            this.animalDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.animalDateDataGridViewTextBoxColumn.Name = "animalDateDataGridViewTextBoxColumn";
            this.animalDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalColorIdDataGridViewTextBoxColumn
            // 
            this.animalColorIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_ColorId";
            this.animalColorIdDataGridViewTextBoxColumn.HeaderText = "Animal_ColorId";
            this.animalColorIdDataGridViewTextBoxColumn.Name = "animalColorIdDataGridViewTextBoxColumn";
            this.animalColorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.animalColorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsColorColumn
            // 
            this.animalsColorColumn.DataPropertyName = "Animal_ColorId";
            this.animalsColorColumn.DataSource = this.colorBindingSource;
            this.animalsColorColumn.DisplayMember = "Color_Name";
            this.animalsColorColumn.HeaderText = "Колір";
            this.animalsColorColumn.Name = "animalsColorColumn";
            this.animalsColorColumn.ReadOnly = true;
            this.animalsColorColumn.ValueMember = "Color_Id";
            // 
            // animalPriceDataGridViewTextBoxColumn
            // 
            this.animalPriceDataGridViewTextBoxColumn.DataPropertyName = "Animal_Price";
            this.animalPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.animalPriceDataGridViewTextBoxColumn.Name = "animalPriceDataGridViewTextBoxColumn";
            this.animalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cageDataGridViewTextBoxColumn
            // 
            this.cageDataGridViewTextBoxColumn.DataPropertyName = "Cage";
            this.cageDataGridViewTextBoxColumn.HeaderText = "Cage";
            this.cageDataGridViewTextBoxColumn.Name = "cageDataGridViewTextBoxColumn";
            this.cageDataGridViewTextBoxColumn.ReadOnly = true;
            this.cageDataGridViewTextBoxColumn.Visible = false;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "Shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Shop";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            this.shopDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            this.speciesDataGridViewTextBoxColumn.Visible = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.animalsDataGridView);
            this.Controls.Add(this.maxYearTextBox);
            this.Controls.Add(this.minYearTextBox);
            this.Controls.Add(this.maxYearLabel);
            this.Controls.Add(this.minYearLabel);
            this.Controls.Add(this.yearCheckBox);
            this.Controls.Add(this.maxPriceLabel);
            this.Controls.Add(this.minPriceLabel);
            this.Controls.Add(this.maxPriceTextBox);
            this.Controls.Add(this.minPriceTextBox);
            this.Controls.Add(this.speciesComboBox);
            this.Controls.Add(this.shopsComboBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.speciesSearchRadioButton);
            this.Controls.Add(this.shopSearchRadioButton);
            this.Controls.Add(this.searchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxYearTextBox;
        private System.Windows.Forms.TextBox minYearTextBox;
        private System.Windows.Forms.Label maxYearLabel;
        private System.Windows.Forms.Label minYearLabel;
        private System.Windows.Forms.CheckBox yearCheckBox;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.ComboBox shopsComboBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.RadioButton speciesSearchRadioButton;
        private System.Windows.Forms.RadioButton shopSearchRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn animalsSexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalShopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn animalsShopColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCageIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalSpeciesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn animalsSpeciesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalColorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn animalsColorColumn;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
    }
}