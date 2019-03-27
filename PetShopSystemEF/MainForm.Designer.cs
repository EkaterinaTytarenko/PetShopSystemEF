namespace PetShopSystemEF
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.animalsTabPage = new System.Windows.Forms.TabPage();
            this.animalsDeleteButton = new System.Windows.Forms.Button();
            this.animalsSaveButton = new System.Windows.Forms.Button();
            this.animalsDataGridView = new System.Windows.Forms.DataGridView();
            this.animalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsSexColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.animalShopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsShopColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalCageIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalSpeciesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsSpeciesColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalColorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalsColorColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopsTabPage = new System.Windows.Forms.TabPage();
            this.cellsInfoButton = new System.Windows.Forms.Button();
            this.shopsDeleteButton = new System.Windows.Forms.Button();
            this.shopsSaveButton = new System.Windows.Forms.Button();
            this.shopsDataGridView = new System.Windows.Forms.DataGridView();
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesPage = new System.Windows.Forms.TabPage();
            this.showFoodButton = new System.Windows.Forms.Button();
            this.speciesDeleteButton = new System.Windows.Forms.Button();
            this.speciesSaveButton = new System.Windows.Forms.Button();
            this.speciesDataGridView = new System.Windows.Forms.DataGridView();
            this.speciesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesLifetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.animalsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.shopsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).BeginInit();
            this.speciesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speciesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.animalsTabPage);
            this.tabControl1.Controls.Add(this.shopsTabPage);
            this.tabControl1.Controls.Add(this.speciesPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // animalsTabPage
            // 
            this.animalsTabPage.Controls.Add(this.animalsDeleteButton);
            this.animalsTabPage.Controls.Add(this.animalsSaveButton);
            this.animalsTabPage.Controls.Add(this.animalsDataGridView);
            this.animalsTabPage.Location = new System.Drawing.Point(4, 22);
            this.animalsTabPage.Name = "animalsTabPage";
            this.animalsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.animalsTabPage.Size = new System.Drawing.Size(768, 327);
            this.animalsTabPage.TabIndex = 0;
            this.animalsTabPage.Text = "Тварини";
            this.animalsTabPage.UseVisualStyleBackColor = true;
            // 
            // animalsDeleteButton
            // 
            this.animalsDeleteButton.Location = new System.Drawing.Point(162, 20);
            this.animalsDeleteButton.Name = "animalsDeleteButton";
            this.animalsDeleteButton.Size = new System.Drawing.Size(109, 29);
            this.animalsDeleteButton.TabIndex = 3;
            this.animalsDeleteButton.Text = "Видалити";
            this.animalsDeleteButton.UseVisualStyleBackColor = true;
            this.animalsDeleteButton.Click += new System.EventHandler(this.animalsDeleteButton_Click);
            // 
            // animalsSaveButton
            // 
            this.animalsSaveButton.Location = new System.Drawing.Point(46, 20);
            this.animalsSaveButton.Name = "animalsSaveButton";
            this.animalsSaveButton.Size = new System.Drawing.Size(110, 29);
            this.animalsSaveButton.TabIndex = 2;
            this.animalsSaveButton.Text = "Зберегти";
            this.animalsSaveButton.UseVisualStyleBackColor = true;
            this.animalsSaveButton.Click += new System.EventHandler(this.animalsSaveButton_Click);
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
            this.animalsDataGridView.Location = new System.Drawing.Point(6, 55);
            this.animalsDataGridView.Name = "animalsDataGridView";
            this.animalsDataGridView.Size = new System.Drawing.Size(755, 266);
            this.animalsDataGridView.TabIndex = 0;
            this.animalsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalsDataGridView_CellEndEdit);
            this.animalsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.animalsDataGridView_DataError);
            // 
            // animalIdDataGridViewTextBoxColumn
            // 
            this.animalIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_Id";
            this.animalIdDataGridViewTextBoxColumn.HeaderText = "Animal_Id";
            this.animalIdDataGridViewTextBoxColumn.Name = "animalIdDataGridViewTextBoxColumn";
            this.animalIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalNameDataGridViewTextBoxColumn
            // 
            this.animalNameDataGridViewTextBoxColumn.DataPropertyName = "Animal_Name";
            this.animalNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я тварини";
            this.animalNameDataGridViewTextBoxColumn.Name = "animalNameDataGridViewTextBoxColumn";
            // 
            // animalSexDataGridViewTextBoxColumn
            // 
            this.animalSexDataGridViewTextBoxColumn.DataPropertyName = "Animal_Sex";
            this.animalSexDataGridViewTextBoxColumn.HeaderText = "Animal_Sex";
            this.animalSexDataGridViewTextBoxColumn.Name = "animalSexDataGridViewTextBoxColumn";
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
            // 
            // animalShopIdDataGridViewTextBoxColumn
            // 
            this.animalShopIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_ShopId";
            this.animalShopIdDataGridViewTextBoxColumn.HeaderText = "Animal_ShopId";
            this.animalShopIdDataGridViewTextBoxColumn.Name = "animalShopIdDataGridViewTextBoxColumn";
            this.animalShopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsShopColumn
            // 
            this.animalsShopColumn.DataPropertyName = "Animal_ShopId";
            this.animalsShopColumn.DataSource = this.shopBindingSource;
            this.animalsShopColumn.DisplayMember = "Shop_Name";
            this.animalsShopColumn.HeaderText = "Назва магазину";
            this.animalsShopColumn.Name = "animalsShopColumn";
            this.animalsShopColumn.ValueMember = "Shop_Id";
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(AnimalsClassLibrary.Shop);
            // 
            // animalCageIdDataGridViewTextBoxColumn
            // 
            this.animalCageIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_CageId";
            this.animalCageIdDataGridViewTextBoxColumn.HeaderText = "Animal_CageId";
            this.animalCageIdDataGridViewTextBoxColumn.Name = "animalCageIdDataGridViewTextBoxColumn";
            this.animalCageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalSpeciesIdDataGridViewTextBoxColumn
            // 
            this.animalSpeciesIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_SpeciesId";
            this.animalSpeciesIdDataGridViewTextBoxColumn.HeaderText = "Animal_SpeciesId";
            this.animalSpeciesIdDataGridViewTextBoxColumn.Name = "animalSpeciesIdDataGridViewTextBoxColumn";
            this.animalSpeciesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsSpeciesColumn
            // 
            this.animalsSpeciesColumn.DataPropertyName = "Animal_SpeciesId";
            this.animalsSpeciesColumn.DataSource = this.speciesBindingSource;
            this.animalsSpeciesColumn.DisplayMember = "Species_Name";
            this.animalsSpeciesColumn.HeaderText = "Назва виду";
            this.animalsSpeciesColumn.Name = "animalsSpeciesColumn";
            this.animalsSpeciesColumn.ValueMember = "Species_Id";
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataSource = typeof(AnimalsClassLibrary.Species);
            // 
            // animalDateDataGridViewTextBoxColumn
            // 
            this.animalDateDataGridViewTextBoxColumn.DataPropertyName = "Animal_Date";
            this.animalDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.animalDateDataGridViewTextBoxColumn.Name = "animalDateDataGridViewTextBoxColumn";
            // 
            // animalColorIdDataGridViewTextBoxColumn
            // 
            this.animalColorIdDataGridViewTextBoxColumn.DataPropertyName = "Animal_ColorId";
            this.animalColorIdDataGridViewTextBoxColumn.HeaderText = "Animal_ColorId";
            this.animalColorIdDataGridViewTextBoxColumn.Name = "animalColorIdDataGridViewTextBoxColumn";
            this.animalColorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalsColorColumn
            // 
            this.animalsColorColumn.DataPropertyName = "Animal_ColorId";
            this.animalsColorColumn.DataSource = this.colorBindingSource;
            this.animalsColorColumn.DisplayMember = "Color_Name";
            this.animalsColorColumn.HeaderText = "Колір";
            this.animalsColorColumn.Name = "animalsColorColumn";
            this.animalsColorColumn.ValueMember = "Color_Id";
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(AnimalsClassLibrary.Color);
            // 
            // animalPriceDataGridViewTextBoxColumn
            // 
            this.animalPriceDataGridViewTextBoxColumn.DataPropertyName = "Animal_Price";
            this.animalPriceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.animalPriceDataGridViewTextBoxColumn.Name = "animalPriceDataGridViewTextBoxColumn";
            // 
            // cageDataGridViewTextBoxColumn
            // 
            this.cageDataGridViewTextBoxColumn.DataPropertyName = "Cage";
            this.cageDataGridViewTextBoxColumn.HeaderText = "Cage";
            this.cageDataGridViewTextBoxColumn.Name = "cageDataGridViewTextBoxColumn";
            this.cageDataGridViewTextBoxColumn.Visible = false;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "Shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Shop";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            this.shopDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.Visible = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(AnimalsClassLibrary.Animal);
            // 
            // shopsTabPage
            // 
            this.shopsTabPage.Controls.Add(this.cellsInfoButton);
            this.shopsTabPage.Controls.Add(this.shopsDeleteButton);
            this.shopsTabPage.Controls.Add(this.shopsSaveButton);
            this.shopsTabPage.Controls.Add(this.shopsDataGridView);
            this.shopsTabPage.Location = new System.Drawing.Point(4, 22);
            this.shopsTabPage.Name = "shopsTabPage";
            this.shopsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.shopsTabPage.Size = new System.Drawing.Size(768, 327);
            this.shopsTabPage.TabIndex = 1;
            this.shopsTabPage.Text = "Магазини";
            this.shopsTabPage.UseVisualStyleBackColor = true;
            // 
            // cellsInfoButton
            // 
            this.cellsInfoButton.Location = new System.Drawing.Point(350, 19);
            this.cellsInfoButton.Name = "cellsInfoButton";
            this.cellsInfoButton.Size = new System.Drawing.Size(214, 23);
            this.cellsInfoButton.TabIndex = 6;
            this.cellsInfoButton.Text = "Переглянути інформацію про клітки";
            this.cellsInfoButton.UseVisualStyleBackColor = true;
            this.cellsInfoButton.Click += new System.EventHandler(this.cellsInfoButton_Click);
            // 
            // shopsDeleteButton
            // 
            this.shopsDeleteButton.Location = new System.Drawing.Point(200, 19);
            this.shopsDeleteButton.Name = "shopsDeleteButton";
            this.shopsDeleteButton.Size = new System.Drawing.Size(90, 23);
            this.shopsDeleteButton.TabIndex = 5;
            this.shopsDeleteButton.Text = "Видалити";
            this.shopsDeleteButton.UseVisualStyleBackColor = true;
            this.shopsDeleteButton.Click += new System.EventHandler(this.shopsDeleteButton_Click);
            // 
            // shopsSaveButton
            // 
            this.shopsSaveButton.Location = new System.Drawing.Point(22, 19);
            this.shopsSaveButton.Name = "shopsSaveButton";
            this.shopsSaveButton.Size = new System.Drawing.Size(99, 23);
            this.shopsSaveButton.TabIndex = 4;
            this.shopsSaveButton.Text = "Зберегти";
            this.shopsSaveButton.UseVisualStyleBackColor = true;
            this.shopsSaveButton.Click += new System.EventHandler(this.shopsSaveButton_Click);
            // 
            // shopsDataGridView
            // 
            this.shopsDataGridView.AutoGenerateColumns = false;
            this.shopsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopNameDataGridViewTextBoxColumn,
            this.shopAdressDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn,
            this.cageDataGridViewTextBoxColumn1,
            this.shopIdDataGridViewTextBoxColumn});
            this.shopsDataGridView.DataSource = this.shopBindingSource;
            this.shopsDataGridView.Location = new System.Drawing.Point(22, 66);
            this.shopsDataGridView.Name = "shopsDataGridView";
            this.shopsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.shopsDataGridView.TabIndex = 0;
            this.shopsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.shopsDataGridView_DataError);
            // 
            // shopNameDataGridViewTextBoxColumn
            // 
            this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "Shop_Name";
            this.shopNameDataGridViewTextBoxColumn.HeaderText = "Назва магазину";
            this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
            // 
            // shopAdressDataGridViewTextBoxColumn
            // 
            this.shopAdressDataGridViewTextBoxColumn.DataPropertyName = "Shop_Adress";
            this.shopAdressDataGridViewTextBoxColumn.HeaderText = "Адреса магазину";
            this.shopAdressDataGridViewTextBoxColumn.Name = "shopAdressDataGridViewTextBoxColumn";
            // 
            // animalDataGridViewTextBoxColumn
            // 
            this.animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            this.animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            this.animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            this.animalDataGridViewTextBoxColumn.Visible = false;
            // 
            // cageDataGridViewTextBoxColumn1
            // 
            this.cageDataGridViewTextBoxColumn1.DataPropertyName = "Cage";
            this.cageDataGridViewTextBoxColumn1.HeaderText = "Cage";
            this.cageDataGridViewTextBoxColumn1.Name = "cageDataGridViewTextBoxColumn1";
            this.cageDataGridViewTextBoxColumn1.Visible = false;
            // 
            // shopIdDataGridViewTextBoxColumn
            // 
            this.shopIdDataGridViewTextBoxColumn.DataPropertyName = "Shop_Id";
            this.shopIdDataGridViewTextBoxColumn.HeaderText = "Shop_Id";
            this.shopIdDataGridViewTextBoxColumn.Name = "shopIdDataGridViewTextBoxColumn";
            this.shopIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesPage
            // 
            this.speciesPage.Controls.Add(this.showFoodButton);
            this.speciesPage.Controls.Add(this.speciesDeleteButton);
            this.speciesPage.Controls.Add(this.speciesSaveButton);
            this.speciesPage.Controls.Add(this.speciesDataGridView);
            this.speciesPage.Location = new System.Drawing.Point(4, 22);
            this.speciesPage.Name = "speciesPage";
            this.speciesPage.Size = new System.Drawing.Size(768, 327);
            this.speciesPage.TabIndex = 2;
            this.speciesPage.Text = "Види тварини";
            this.speciesPage.UseVisualStyleBackColor = true;
            // 
            // showFoodButton
            // 
            this.showFoodButton.Location = new System.Drawing.Point(399, 17);
            this.showFoodButton.Name = "showFoodButton";
            this.showFoodButton.Size = new System.Drawing.Size(186, 23);
            this.showFoodButton.TabIndex = 6;
            this.showFoodButton.Text = "Переглянути інформацію про їжу";
            this.showFoodButton.UseVisualStyleBackColor = true;
            this.showFoodButton.Click += new System.EventHandler(this.showFoodButton_Click);
            // 
            // speciesDeleteButton
            // 
            this.speciesDeleteButton.Location = new System.Drawing.Point(226, 17);
            this.speciesDeleteButton.Name = "speciesDeleteButton";
            this.speciesDeleteButton.Size = new System.Drawing.Size(98, 23);
            this.speciesDeleteButton.TabIndex = 5;
            this.speciesDeleteButton.Text = "Видалити";
            this.speciesDeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.speciesDeleteButton.UseVisualStyleBackColor = true;
            this.speciesDeleteButton.Click += new System.EventHandler(this.speciesDeleteButton_Click);
            // 
            // speciesSaveButton
            // 
            this.speciesSaveButton.Location = new System.Drawing.Point(23, 17);
            this.speciesSaveButton.Name = "speciesSaveButton";
            this.speciesSaveButton.Size = new System.Drawing.Size(99, 23);
            this.speciesSaveButton.TabIndex = 4;
            this.speciesSaveButton.Text = "Зберегти";
            this.speciesSaveButton.UseVisualStyleBackColor = true;
            this.speciesSaveButton.Click += new System.EventHandler(this.speciesSaveButton_Click);
            // 
            // speciesDataGridView
            // 
            this.speciesDataGridView.AutoGenerateColumns = false;
            this.speciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.speciesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.speciesNameDataGridViewTextBoxColumn,
            this.speciesTemperatureDataGridViewTextBoxColumn,
            this.speciesLifetimeDataGridViewTextBoxColumn,
            this.animalDataGridViewTextBoxColumn1,
            this.speciesFoodDataGridViewTextBoxColumn,
            this.speciesIdDataGridViewTextBoxColumn});
            this.speciesDataGridView.DataSource = this.speciesBindingSource;
            this.speciesDataGridView.Location = new System.Drawing.Point(23, 70);
            this.speciesDataGridView.Name = "speciesDataGridView";
            this.speciesDataGridView.Size = new System.Drawing.Size(349, 150);
            this.speciesDataGridView.TabIndex = 0;
            this.speciesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.speciesDataGridView_CellEndEdit);
            this.speciesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.speciesDataGridView_DataError);
            // 
            // speciesNameDataGridViewTextBoxColumn
            // 
            this.speciesNameDataGridViewTextBoxColumn.DataPropertyName = "Species_Name";
            this.speciesNameDataGridViewTextBoxColumn.HeaderText = "Назва виду";
            this.speciesNameDataGridViewTextBoxColumn.Name = "speciesNameDataGridViewTextBoxColumn";
            // 
            // speciesTemperatureDataGridViewTextBoxColumn
            // 
            this.speciesTemperatureDataGridViewTextBoxColumn.DataPropertyName = "Species_Temperature";
            this.speciesTemperatureDataGridViewTextBoxColumn.HeaderText = "Середня комфортна температура";
            this.speciesTemperatureDataGridViewTextBoxColumn.Name = "speciesTemperatureDataGridViewTextBoxColumn";
            // 
            // speciesLifetimeDataGridViewTextBoxColumn
            // 
            this.speciesLifetimeDataGridViewTextBoxColumn.DataPropertyName = "Species_Lifetime";
            this.speciesLifetimeDataGridViewTextBoxColumn.HeaderText = "Середня тривалість життя";
            this.speciesLifetimeDataGridViewTextBoxColumn.Name = "speciesLifetimeDataGridViewTextBoxColumn";
            // 
            // animalDataGridViewTextBoxColumn1
            // 
            this.animalDataGridViewTextBoxColumn1.DataPropertyName = "Animal";
            this.animalDataGridViewTextBoxColumn1.HeaderText = "Animal";
            this.animalDataGridViewTextBoxColumn1.Name = "animalDataGridViewTextBoxColumn1";
            this.animalDataGridViewTextBoxColumn1.Visible = false;
            // 
            // speciesFoodDataGridViewTextBoxColumn
            // 
            this.speciesFoodDataGridViewTextBoxColumn.DataPropertyName = "SpeciesFood";
            this.speciesFoodDataGridViewTextBoxColumn.HeaderText = "SpeciesFood";
            this.speciesFoodDataGridViewTextBoxColumn.Name = "speciesFoodDataGridViewTextBoxColumn";
            this.speciesFoodDataGridViewTextBoxColumn.Visible = false;
            // 
            // speciesIdDataGridViewTextBoxColumn
            // 
            this.speciesIdDataGridViewTextBoxColumn.DataPropertyName = "Species_Id";
            this.speciesIdDataGridViewTextBoxColumn.HeaderText = "Species_Id";
            this.speciesIdDataGridViewTextBoxColumn.Name = "speciesIdDataGridViewTextBoxColumn";
            this.speciesIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(16, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(115, 52);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Виконати пошук ";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.animalsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.shopsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopsDataGridView)).EndInit();
            this.speciesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speciesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage animalsTabPage;
        private System.Windows.Forms.TabPage shopsTabPage;
        private System.Windows.Forms.TabPage speciesPage;
        private System.Windows.Forms.DataGridView animalsDataGridView;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.DataGridView shopsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView speciesDataGridView;
        private System.Windows.Forms.Button animalsSaveButton;
        private System.Windows.Forms.Button animalsDeleteButton;
        private System.Windows.Forms.Button cellsInfoButton;
        private System.Windows.Forms.Button shopsDeleteButton;
        private System.Windows.Forms.Button shopsSaveButton;
        private System.Windows.Forms.Button showFoodButton;
        private System.Windows.Forms.Button speciesDeleteButton;
        private System.Windows.Forms.Button speciesSaveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesTemperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesLifetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesIdDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn animalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
    }
}