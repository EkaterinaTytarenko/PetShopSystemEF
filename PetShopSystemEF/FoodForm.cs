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

namespace PetShopSystemEF
{
    public partial class FoodForm : Form
    {
        private AnimalsClassLibrary.AnimalsEntities ctx;
        private int species_Id;

        public FoodForm(int speciesId)
        {
            species_Id = speciesId;
            InitializeComponent();
            ctx = new AnimalsClassLibrary.AnimalsEntities();
            ctx.Food1.Load();
            food1BindingSource.DataSource = ctx.Food1.Local.ToBindingList();
            LoadData();
        }

        private void LoadData()
        {
            ctx.SpeciesFood.Load();
            var query = ctx.SpeciesFood.Where(sf => sf.Species_Id == species_Id);
            speciesFoodBindingSource.DataSource = query.ToList();
            
        }

        private void FoodForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void foodDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                    SpeciesFood speciesFood = (SpeciesFood)foodDataGridView.CurrentRow.DataBoundItem;
                    speciesFoodBindingSource.DataSource = ctx.SpeciesFood.Local.ToBindingList();
                    speciesFoodBindingSource.Remove(speciesFood);
                    ctx.SaveChanges();
                    LoadData();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }

        private void newFoodButton_Click(object sender, EventArgs e)
        {
            string foodName = foodComboBox.Text;
            int foodId = (from f in ctx.Food1 where (f.Food_Name== foodName)select f.Food_Id).First();
            SpeciesFood speciesFood = new SpeciesFood();
            speciesFood.Food_Id = foodId;
            speciesFood.Species_Id = species_Id;
            speciesFoodBindingSource.DataSource = ctx.SpeciesFood.Local.ToBindingList();
            speciesFoodBindingSource.Add(speciesFood);
            ctx.SaveChanges();
            LoadData();


        }

        private void foodDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
