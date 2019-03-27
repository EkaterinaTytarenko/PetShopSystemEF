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
/*
 <connectionStrings>
    <add name = "PetShopSystemEF.Properties.Settings.UsersConnectionString" connectionString="Data Source=COMP\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True" providerName="System.Data.SqlClient" />
  </connectionStrings>
  */

namespace PetShopSystemEF
{
    public partial class MainForm : Form
    {
        private AnimalsClassLibrary.AnimalsEntities ctx;


        public MainForm()
        {
            InitializeComponent();
            ctx = new AnimalsClassLibrary.AnimalsEntities();

            ctx.Animal.Load();
            this.animalBindingSource.DataSource = ctx.Animal.Local.ToBindingList();

            ctx.Shop.Load();
            this.shopBindingSource.DataSource = ctx.Shop.Local.ToBindingList();

            ctx.Species.Load();
            this.speciesBindingSource.DataSource = ctx.Species.Local.ToBindingList();

            ctx.Color.Load();
            this.colorBindingSource.DataSource = ctx.Color.Local.ToBindingList();
        }

        private void animalsSaveButton_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void animalsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                animalBindingSource.RemoveCurrent();
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void shopsSaveButton_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void speciesSaveButton_Click(object sender, EventArgs e)
        {
            int lifeTime;
            try
            {
                lifeTime = (int)speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value;

            }
            catch (Exception)
            {
                speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value = 1;
                ctx.SaveChanges();
                return;

            }
            if (lifeTime <= 0)
            {
                MessageBox.Show("Помилкові дані. Тривалість життя не може бути недодатньою");
                speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value = 1;
            }
            ctx.SaveChanges();
        }

        private void shopsDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Shop shop = (Shop)shopsDataGridView.CurrentRow.DataBoundItem;
                var b = (from a in ctx.Animal where (a.Animal_ShopId == shop.Shop_Id) select a).Any();
                if (b)
                    MessageBox.Show("Неможливо видалити магазин, у якому є тварини");

                else
                {
                    var cages = (from cage in ctx.Cage where (cage.Cage_ShopId == shop.Shop_Id) select cage);
                    foreach (Cage c in cages.ToArray())
                        ctx.Cage.Remove(c);
                    shopBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void speciesDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Species species = (Species)speciesDataGridView.CurrentRow.DataBoundItem;
                var b = (from a in ctx.Animal where (a.Animal_SpeciesId == species.Species_Id) select a).Any();
                if (b)
                    MessageBox.Show("Неможливо видалити цей вид, бо його представники є у магазинах");
                else
                {
                    var speciesFood = (from sp in ctx.SpeciesFood where (sp.Species_Id == species.Species_Id) select sp);
                    foreach (SpeciesFood speciesfood in speciesFood.ToArray())
                        ctx.SpeciesFood.Remove(speciesfood);
                    speciesBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }

        }

        private void animalsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("Введено некоректні дані");
        }

        private void shopsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");
        }

        private void speciesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введено некоректні дані");
        }

        private void speciesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (speciesDataGridView.CurrentCell.ColumnIndex == 2)
            {
                int lifeTime;
                try
                {
                    lifeTime = (int)speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value;

                }
                catch (Exception)
                {
                    speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value = 1;
                    return;

                }
                if (lifeTime <= 0)
                {
                    MessageBox.Show("Помилкові дані. Тривалість життя не може бути недодатньою");
                    speciesDataGridView.CurrentRow.Cells["speciesLifetimeDataGridViewTextBoxColumn"].Value = 1;
                }

            }
        }

        private void cellsInfoButton_Click(object sender, EventArgs e)
        {
            CagesForm cagesForm = new CagesForm((int)shopsDataGridView.CurrentRow.Cells["shopIdDataGridViewTextBoxColumn"].Value);
            cagesForm.ShowDialog(this);
            cagesForm.Dispose();
        }

        private void animalsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (animalsDataGridView.CurrentCell.ColumnIndex == 5)
                {
                    int shop_id;
                    try
                    {
                        shop_id = (int)animalsDataGridView.CurrentRow.Cells["animalShopIdDataGridViewTextBoxColumn"].Value;

                    }
  
                    catch (Exception)
                    {
                        animalsDataGridView.CurrentRow.Cells["animalCageIdDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        return;

                    }
                    int count = (from c in ctx.Cage where (c.Cage_ShopId == shop_id) select c).Count();
                    if (count == 0)
                    {
                        MessageBox.Show("Неможливо обрати цей магазин,тому що у ньому немає жодної клітки для тварин");
                        animalsDataGridView.CurrentRow.Cells["animalCageIdDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        animalsDataGridView.CurrentRow.Cells["animalShopIdDataGridViewTextBoxColumn"].Value = System.DBNull.Value;
                        animalsDataGridView.CurrentRow.Cells["AnimalsShopColumn"].Value = "";
                        return;

                    }
                    ChooseCagesForm chooseCagesForm = new ChooseCagesForm(shop_id, animalsDataGridView);
                    chooseCagesForm.ShowDialog(this);
                    chooseCagesForm.Dispose();

                }
                if (animalsDataGridView.CurrentCell.ColumnIndex == 12)
                {
                    int price;
                    try
                    {
                        price = (int)animalsDataGridView.CurrentRow.Cells["animalPriceDataGridViewTextBoxColumn"].Value;

                    }
                    catch (Exception)
                    {
                        animalsDataGridView.CurrentRow.Cells["animalPriceDataGridViewTextBoxColumn"].Value = 1;
                        return;

                    }
                    if (price < 0)
                    {
                        MessageBox.Show("Помилкові дані.Ціна не може бути від'ємною");
                        animalsDataGridView.CurrentRow.Cells["animalPriceDataGridViewTextBoxColumn"].Value = 1;
                    }
                }
            }
            catch(Exception)
            { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
   "Ви дійсно хочете закрити це вікно?",
   "Завершення програми",
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

        private void showFoodButton_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm((int)speciesDataGridView.CurrentRow.Cells["speciesIdDataGridViewTextBoxColumn"].Value);
            foodForm.ShowDialog(this);
            foodForm.Dispose();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog(this);
            searchForm.Dispose();
        }
    }
}
