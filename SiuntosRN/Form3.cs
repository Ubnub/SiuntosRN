using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiuntosRN
{
    public partial class SiuntaForm : Form
    {
        private readonly List<Preke> addList;
        private int Kaina;
        public SiuntaForm(List<Preke> krepselis)
        {
            InitializeComponent();
            addList = krepselis;
            Siunta Siunta = new Siunta(addList);
            SiuntaDGV.DataSource = addList;
            Siunta.SkaiciuotiDydi();
            Siunta.SkaiciuotiKaina();
            switch (Siunta.Dydis)
            {
                case 1:
                    SizeLabel.Text = "S";
                    break;
                case 2:
                    SizeLabel.Text = "M";
                    break;
                case 3:
                    SizeLabel.Text = "L";
                    break;
                default:
                    break;
            }
            PriceLabel.Text = (Siunta.Kaina).ToString();
            Kaina = Siunta.Kaina;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Apmokejimas sekmingas\nPirkinio kaina: " + Kaina),("Apmoketa!"));
            this.Close();
            this.Dispose();
        }
    }
}
