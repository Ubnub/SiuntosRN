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
    public partial class CreateNewItemForm : Form
    {
        private readonly List<Preke> addList;
        private Action<List<Preke>> Refresh;
        Random rng = new Random();
        public CreateNewItemForm(List<Preke> katalogas,Action<List<Preke>> refresh)
        {
            InitializeComponent();
            addList = katalogas;
            Refresh = refresh;
            
        }
        public int GenerateUniqueID()
        {
            int a = 0;
            bool notuniq = true;
            while (notuniq)
            {
                bool found = false;
                a = rng.Next(10000, 100000);
                for (int i = 0; i < addList.Count; i++)
                {
                    if (addList[i].ID == a)
                    {
                        found = true;
                        break;
                    }
                }
                if (found) { }
                else
                {
                    notuniq = false;                   
                }
            }
            return a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void SaveNewItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameNewItem.Text)||string.IsNullOrWhiteSpace(NameNewItem.Text)|| string.IsNullOrEmpty(PriceNewItem.Text) || string.IsNullOrWhiteSpace(PriceNewItem.Text) || string.IsNullOrEmpty(AmmNewItem.Text) || string.IsNullOrWhiteSpace(AmmNewItem.Text))
            {
                MessageBox.Show("Visi laukai turi buti uzpildyti");
            }
            else
            {
                int a = GenerateUniqueID();
                Preke B = new Preke(a, Convert.ToInt32(PriceNewItem.Text), NameNewItem.Text, Convert.ToInt32(AmmNewItem.Text));
                addList.Add(B);
            }
            Refresh(addList);
            Close();
        }
    }
}
