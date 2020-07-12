using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiuntosRN
{
    public partial class Form1 : Form
    {
        private List<Preke> Katalogas;
        private List<Preke> Krepselis;

        private Preke Selected;
        private Preke SelectedKrepselis;
        public Form1()
        {
            InitializeComponent();
            Katalogas = new List<Preke>();
            Krepselis = new List<Preke>();
           // PrekiuKatalogas.DataSource = Katalogas;
        }

        private void NewItemCreate_Click(object sender, EventArgs e)
        {
            CreateNewItemForm form = new CreateNewItemForm(Katalogas, Refresh);
            form.Show();
        }
        private void Refresh(List<Preke> katalogas)
        {
            PrekiuKatalogas.DataSource = null;
            PrekiuKatalogas.DataSource = katalogas;
            PrekiuKatalogas.Refresh();
            PrekiuKatalogas.Update();
            Katalogas = katalogas;
        }
        private void PrekiuKatalogas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (PrekiuKatalogas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PrekiuKatalogas.CurrentRow.Selected = true;
                CurrentItem.Text = PrekiuKatalogas.Rows[e.RowIndex].Cells["Pavadinimas"].FormattedValue.ToString();
                foreach (var item in Katalogas)
                {
                    if (item.ID == Convert.ToInt32(PrekiuKatalogas.Rows[e.RowIndex].Cells["ID"].FormattedValue))
                    {
                        Selected = item;
                        break;
                        
                    }
                }
            }
        }
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            Katalogas.Remove(Selected);
            Selected = null;
            CurrentItem.Text = "-";
            PrekiuKatalogas.DataSource = null;
            PrekiuKatalogas.DataSource = Katalogas;
        }

        private void UpdatePrice_Click(object sender, EventArgs e)
        {           
            if (Selected != null)
            {

                foreach (var item in Katalogas)
                {
                    if (item.ID == Selected.ID)
                    {
                        item.Kaina = int.Parse(NaujaKaina.Text);
                        break;
                    }
                }
                PrekiuKatalogas.DataSource = null;
                PrekiuKatalogas.DataSource = Katalogas;
            }
           
        }

        private void AddKrepselisButton_Click(object sender, EventArgs e)
        {
            if (Selected!=null)
            {
                Preke a = new Preke(Selected.ID, Selected.Kaina, Selected.Pavadinimas, 1);                              
                foreach (var item in Katalogas)
                {
                    if (item.ID == Selected.ID)
                    {
                        item.Likutis--;
                        break;
                    }
                }
                Krepselis.Add(a);
                PrekiuKatalogas.DataSource = null;
                PrekiuKatalogas.DataSource = Katalogas;
                PrekiuKrepselisDG.DataSource = null;
                PrekiuKrepselisDG.DataSource = Krepselis;
            }
            
        }

        private void RemoveKrepselisButton_Click(object sender, EventArgs e)
        {           
            
            foreach (var item in Katalogas)
            {
                if (item.ID==SelectedKrepselis.ID)
                {
                    item.Likutis++;
                    break;
                }
            }
            Krepselis.Remove(SelectedKrepselis);
            SelectedKrepselis = null;
            CurrentPurchItem.Text = "-";
            PrekiuKrepselisDG.DataSource = null;
            PrekiuKrepselisDG.DataSource = Krepselis;
            PrekiuKatalogas.DataSource = null;
            PrekiuKatalogas.DataSource = Katalogas;
        }

        private void PrekiuKrepselisDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PrekiuKrepselisDG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                PrekiuKrepselisDG.CurrentRow.Selected = true;
                CurrentPurchItem.Text = PrekiuKrepselisDG.Rows[e.RowIndex].Cells["Pavadinimas"].FormattedValue.ToString();
                foreach (var item in Krepselis)
                {
                    if (item.ID == Convert.ToInt32(PrekiuKrepselisDG.Rows[e.RowIndex].Cells["ID"].FormattedValue))
                    {
                        SelectedKrepselis = item;
                        break;

                    }
                }
            }
        }
        private void BuyButton_Click(object sender, EventArgs e)
        {
            SiuntaForm form = new SiuntaForm(Krepselis);
            form.Show();
        }
    }
}
