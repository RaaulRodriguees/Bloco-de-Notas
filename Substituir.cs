using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloco_de_Notas
{
    public partial class Substituir : Form
    {
        public Substituir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String busca = txtBx1.Text;
            String nova = txtBx2.Text;
            String texto = ((Form1)this.Owner).rchTxtBx.Text;

            ((Form1)this.Owner).rchTxtBx.Text = texto.Replace(busca, nova);

            this.Close();
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
