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
    public partial class ChooseCagesForm : Form
    {
        private AnimalsClassLibrary.AnimalsEntities ctx;
        private int shop_Id;
        private DataGridView myTable;

        public ChooseCagesForm(int shopId, DataGridView table)
        {
            shop_Id = shopId;
            myTable = table;
            InitializeComponent();
            ctx = new AnimalsClassLibrary.AnimalsEntities();
            LoadData();
        }

        private void LoadData()
        {
            ctx.Cage.Load();
            var query = ctx.Cage.Where(c => c.Cage_ShopId == shop_Id);
            cageBindingSource.DataSource = query.ToList();
        }

        private void chooseCagesButton_Click(object sender, EventArgs e)
        {
            //cage1TableAdapter.Update(animalsDataSet.Cage1);
            int num = int.Parse(cageNumsComboBox.Text);
            int cageId = (from cage in ctx.Cage where ((cage.Cage_ShopId == shop_Id)&& (cage.Cage_Number==num)) select cage.Cage_Id).First();
            myTable.CurrentRow.Cells["animalCageIdDataGridViewTextBoxColumn"].Value = cageId;
            ctx.SaveChanges();
            this.Close();
        }
    }
}
