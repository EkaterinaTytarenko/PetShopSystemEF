using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using AnimalsClassLibrary;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace PetShopSystemEF
{
    public partial class SearchForm : Form
    {
        private AnimalsClassLibrary.AnimalsEntities ctx;
        public SearchForm()
        {
            InitializeComponent();
            ctx = new AnimalsClassLibrary.AnimalsEntities();

            ctx.Shop.Load();
            this.shopBindingSource.DataSource = ctx.Shop.Local.ToBindingList();

            ctx.Species.Load();
            this.speciesBindingSource.DataSource = ctx.Species.Local.ToBindingList();

            ctx.Color.Load();
            this.colorBindingSource.DataSource = ctx.Color.Local.ToBindingList();
        }

        private void shopSearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (shopSearchRadioButton.Checked)
            {
                shopsComboBox.Visible = true;

            }
            else
            {
                shopsComboBox.Visible = false;

            }
        }

        private void speciesSearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (speciesSearchRadioButton.Checked)
            {
                speciesComboBox.Visible = true;
            }
            else
            {
                speciesComboBox.Visible = false;
            }
        }

        private void priceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (priceCheckBox.Checked)
            {
                minPriceLabel.Visible = true;
                minPriceTextBox.Visible = true;
                maxPriceLabel.Visible = true;
                maxPriceTextBox.Visible = true;
            }
            else
            {
                minPriceLabel.Visible = false;
                minPriceTextBox.Visible = false;
                maxPriceLabel.Visible = false;
                maxPriceTextBox.Visible = false;
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
   "Закрити вікно?",
   "Закриття вікна",
   MessageBoxButtons.YesNo,
   MessageBoxIcon.Warning
  );
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void yearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (yearCheckBox.Checked)
            {
                minYearLabel.Visible = true;
                minYearTextBox.Visible = true;
                maxYearLabel.Visible = true;
                maxYearTextBox.Visible = true;
            }
            else
            {
                minYearLabel.Visible = false;
                minYearTextBox.Visible = false;
                maxYearLabel.Visible = false;
                maxYearTextBox.Visible = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int minPrice = 0;
            int maxPrice = int.MaxValue;
            int minYear = 0;
            int maxYear = int.MaxValue;
            if (priceCheckBox.Checked)
            {
                try
                {
                    minPrice = int.Parse(minPriceTextBox.Text);
                    maxPrice = int.Parse(maxPriceTextBox.Text);
                    if (minPrice < 0 || minPrice > maxPrice)
                        throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Некоректно введена ціна. Пошук неможливий.");
                    return;

                }

            }
            if (yearCheckBox.Checked)
            {
                try
                {
                    minYear = int.Parse(minYearTextBox.Text);
                    maxYear = int.Parse(maxYearTextBox.Text);
                    if (minYear < 0 || minYear > maxYear)
                        throw new Exception();
                }
                catch (Exception)
                {
                    MessageBox.Show("Некоректно введені роки. Пошук неможливий.");
                    return;

                }

            }
            string searchParament;
            if (speciesSearchRadioButton.Checked)
            {
                searchParament = speciesComboBox.Text;
                ctx.Animal.Load();
                int speciesId = (from s in ctx.Species where (s.Species_Name == searchParament) select s.Species_Id).First();
                var query = ctx.Animal.Where((a => a.Animal_Price >= minPrice && a.Animal_Price <= maxPrice && a.Animal_Date.Year >= minYear && a.Animal_Date.Year <= maxYear && a.Animal_SpeciesId == speciesId));
                List<AnimalsClassLibrary.Animal> list = query.ToList();
                transformToXml(list);
                animalBindingSource.DataSource = query.ToList();
            }
            else
            {
                searchParament = shopsComboBox.Text;
                ctx.Animal.Load();
                int shopId = (from s in ctx.Shop where (s.Shop_Name == searchParament) select s.Shop_Id).First();
                var query = ctx.Animal.Where((a => a.Animal_Price >= minPrice && a.Animal_Price <= maxPrice && a.Animal_Date.Year >= minYear && a.Animal_Date.Year <= maxYear && a.Animal_ShopId == shopId));
                List<AnimalsClassLibrary.Animal> list = query.ToList();
                transformToXml(list);
                animalBindingSource.DataSource = list;
            }
        }

        private void animalsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void transformToXml(List<AnimalsClassLibrary.Animal> list)
        {
            XDocument xdoc = new XDocument();
            XElement animals = new XElement("animals");
            foreach(Animal animal in list)
            {
                XElement local = new XElement("animal");
                XAttribute cageId= new XAttribute("cageId", animal.Animal_CageId.ToString());
                XAttribute colorId = new XAttribute("colorId", animal.Animal_ColorId.ToString());
                XAttribute date = new XAttribute("date", animal.Animal_Date.ToString().Substring(0,11));
                XAttribute id = new XAttribute("ID", animal.Animal_Id.ToString());
                XAttribute name = new XAttribute("name", animal.Animal_Name);
                XAttribute price = new XAttribute("price", animal.Animal_Price.ToString());
                XAttribute sex = new XAttribute("sex", animal.Animal_Sex);
                XAttribute shopId = new XAttribute("shopId", animal.Animal_ShopId.ToString());
                XAttribute speciesId = new XAttribute("speciesId", animal.Animal_SpeciesId.ToString());
                XElement cageNum= new XElement("cageNumber", animal.Cage.Cage_Number.ToString());
                XElement colorName = new XElement("colorName", animal.Color.Color_Name);
                XElement shopName = new XElement("shopName", animal.Shop.Shop_Name);
                XElement speciesName = new XElement("speciesName", animal.Species.Species_Name);
                local.Add(cageId);
                local.Add(colorId);
                local.Add(date);
                local.Add(id);
                local.Add(name);
                local.Add(price);
                local.Add(sex);
                local.Add(shopId);
                local.Add(speciesId);
                local.Add(cageNum);
                local.Add(colorName);
                local.Add(shopName);
                local.Add(speciesName);
                animals.Add(local);
            }
            xdoc.Add(animals);
            xdoc.Save("pets.xml");


        }
    }
}
