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
    public partial class Localizar : Form
    {
        public Localizar()
        {
            InitializeComponent();
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn1_Click(object sender, EventArgs e)
        {
            String busca = txtBxLoc.Text;
            String texto = ((Form1)this.Owner).rchTxtBx.Text;

            RichTextBoxFinds regra = RichTextBoxFinds.None;
            if(chckBx1.Checked == true)
            {
                regra = RichTextBoxFinds.MatchCase;
            }
            if(chckBx2.Checked = true)
            {
                regra = RichTextBoxFinds.WholeWord;
            }
            int index = 0;

            while(index < ((Form1)this.Owner).rchTxtBx.Text.LastIndexOf(busca))
            {
                ((Form1)this.Owner).rchTxtBx.Find(busca, index, texto.Length, regra);
                ((Form1)this.Owner).rchTxtBx.SelectionBackColor = Color.BlueViolet;
                index = ((Form1)this.Owner).rchTxtBx.Text.IndexOf(busca, index) + 1;
            }
            this.Close();
        }
    }
}
