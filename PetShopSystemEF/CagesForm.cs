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
    public partial class CagesForm : Form
    {
        private AnimalsClassLibrary.AnimalsEntities ctx;
        private int shop_Id;


        public CagesForm(int shopId)
        {
            shop_Id = shopId;
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

        private void cagesDeletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Cage cage = (Cage)cagesDataGridView.CurrentRow.DataBoundItem;
                var b = (from a in ctx.Animal where (a.Animal_CageId == cage.Cage_Id) select a).Any();
                if (b)
                    MessageBox.Show("Неможливо видалити клітку, у якій є тварини");

                else
                {
                    Cage cage1 = (Cage)cagesDataGridView.CurrentRow.DataBoundItem;
                    cageBindingSource.DataSource = ctx.Cage.Local.ToBindingList();
                    cageBindingSource.Remove(cage1);
                    ctx.SaveChanges();
                    LoadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення");
            }
        }



        private void newCageButton_Click(object sender, EventArgs e)
        {
            int num=0;
            int square=0;
            try
            {
                num = int.Parse(numberTextBox.Text);
                square = int.Parse(squareTextBox.Text);
            }
            catch (Exception)
            { MessageBox.Show("Введено некоректні дані.Додавання неможливе");
                numberTextBox.Text = "";
                squareTextBox.Text = "";
                return;
            }
            if (num <= 0 || square <= 0)
            {
                MessageBox.Show("Недодатний номер або площа.Додавання неможливе");
                numberTextBox.Text = "";
                squareTextBox.Text = "";
                return;
            }
            Cage cage = new Cage();
            cage.Cage_Number = num;
            cage.Cage_ShopId = shop_Id;
            cage.Cage_Square = square;
            cageBindingSource.DataSource = ctx.Cage.Local.ToBindingList();
            cageBindingSource.Add(cage);
            ctx.SaveChanges();
            LoadData();



        }

        private void CagesForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
