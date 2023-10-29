namespace Bloco_de_Notas
{
    public partial class Form1 : Form
    {
        bool alterado = false;
        int zoom = 100;
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            rchTxtBx.TextChanged += rchTxtBx_TextChanged;

            barraDeStatusToolStripMenuItem.Checked = true;
        }

        private void atualizaPosicao()
        {
            int linha = rchTxtBx.GetLineFromCharIndex(rchTxtBx.SelectionStart);
            int coluna = rchTxtBx.SelectionStart - rchTxtBx.GetFirstCharIndexFromLine(linha);
            tlStrpSttsLblCursor.Text = "Ln: " + linha.ToString() + " Col: " + coluna.ToString();
        }

        private void rchTxtBx_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alterado)
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.Text != "")
                    {
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //Coloca o nome do arquivo como titulo
                this.Text = opnFlDlgAbrir.FileName;

                //Para ler todo o conteúdo e colocar no richTextBox
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    rchTxtBx.Rtf = reader.ReadToEnd();
                    alterado = false;
                }
            }
        }

        private void salvar(String arquivo)
        //Salvar arquivo
        {
            if (arquivo != "")
            {
                try
                {
                    rchTxtBx.SaveFile(arquivo, RichTextBoxStreamType.RichText);
                    //Isso fará o nome da janela ser o nome do arquivo
                    this.Text = arquivo;
                    // Indica que o arquivo salvo não está mais alterado
                    alterado = false;
                }
                //Caso tenho algum erro ao salvar, esse catch irá fazer aparecer uma mensagem de erro
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Se o nome do arquivo for inválido, cairá aqui
            else
            {
                MessageBox.Show("Nome de arquivo é inválido.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void salvarComo()
        {
            if (svFlDlg.ShowDialog() == DialogResult.OK)
            {
                this.salvar(svFlDlg.FileName);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                this.salvar(this.Text);
            }
            else
            {
                this.salvarComo();
            }
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.salvarComo();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBx.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBx.SelectedRtf != "")
            {
                //Colocar como objeto, pq como texto ele não salvará as info de cores e fonte, mas como objeto ele salva essas info

                //Aqui ele vai salvar o texto recortado no Clipboard
                Clipboard.SetDataObject(rchTxtBx.SelectedRtf);
                //Aqui ele apagará o texto recortado do RichTextBox
                rchTxtBx.SelectedRtf = "";
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBx.SelectedRtf != "")
            {
                //Aqui ele vai salvar o texto recortado no Clipboard
                Clipboard.SetDataObject(rchTxtBx.SelectedRtf);
            }
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verifica se há um texto no Clipboard, caso tenha uma imagem ou outro tipo de arquivo não abrirá no RichTextBox
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                rchTxtBx.SelectedText = (String)Clipboard.GetData(DataFormats.Text);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBx.SelectedRtf != "")
            {
                rchTxtBx.SelectedRtf = "";
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBx.SelectedText != "")
            {
                //Para poder modificar os espaços sem mudar o conteudo do RichTextBox
                string texto = rchTxtBx.SelectedText;
                //Troca todos os espaços em branco para um sinal de +
                texto.Replace(' ', '+');
                //Aqui ele irá abrir o Microsft edge e já ir para a busca automática
                System.Diagnostics.Process.Start("microsoft-edge:https://www.bing.com/search?q=" + texto);
            }
            else
            {
                MessageBox.Show("Selecione o texto que deseja pesquisar", "Buscar com Bing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rchTxtBx.SelectAll();
        }

        private void horaDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Vai quebrar a linha e adicionar a data/hora atual
            rchTxtBx.SelectedText = System.Environment.NewLine + DateTime.Now;
        }

        private void quebraAutomáticaDaLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quebraAutomáticaDaLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                quebraAutomáticaDaLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                rchTxtBx.WordWrap = false;
            }
            else
            {
                quebraAutomáticaDaLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                rchTxtBx.WordWrap = true;
            }
        }

        private void conToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgStpDlg.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prntDlg.ShowDialog();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alterado)
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.Text != "")
                    {
                        this.salvar(this.Text);
                    }
                    else
                    {
                        this.salvarComo();
                    }
                }
            }
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //Coloca o nome do arquivo como titulo
                this.Text = opnFlDlgAbrir.FileName;

                //Para ler todo o conteúdo e colocar no richTextBox
                using (StreamReader reader = new StreamReader(opnFlDlgAbrir.OpenFile()))
                {
                    rchTxtBx.Text = reader.ReadToEnd();
                    alterado = false;
                }
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fntDlg.ShowDialog() == DialogResult.OK)
            {
                rchTxtBx.SelectionFont = fntDlg.Font;
            }
        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            sttsStrp.Visible = !sttsStrp.Visible;
        }

        private void atualizaZoom()
        {
            tlStrpSttsLblZoom.Text = this.zoom.ToString() + "%";
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom++;
            rchTxtBx.Font = new Font(rchTxtBx.Font.FontFamily, rchTxtBx.Font.Size + 1, rchTxtBx.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom--;
            rchTxtBx.Font = new Font(rchTxtBx.Font.FontFamily, rchTxtBx.Font.Size - 1, rchTxtBx.Font.Style);
            this.atualizaZoom();
        }

        private void restaurarZoomPadrãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            rchTxtBx.Font = new Font(rchTxtBx.Font.FontFamily, 12, rchTxtBx.Font.Style);
            this.atualizaZoom();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                rchTxtBx.SelectionColor = clrDlg.Color;
            }
        }

        private void substituirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Substituir frm = new Substituir();
            frm.txtBx1.Text = rchTxtBx.SelectedText;
            frm.Show(this);
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizar frm = new Localizar();
            frm.txtBxLoc.Text = rchTxtBx.SelectedText;
            frm.Show(this);
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e, string imagePath)
        {


        }
    }
}