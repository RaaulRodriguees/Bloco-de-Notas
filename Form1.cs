namespace Bloco_de_Notas
{
    public partial class Form1 : Form
    {
        //Para indicar se h� alguma altera��o no texto
        bool alterado = false;
        //V�riavel zoom que por padr�o ter� o valor 100
        int zoom = 100;
        public Form1()
        {
            InitializeComponent();
            this.Text = "";
            rchTxtBx.TextChanged += rchTxtBx_TextChanged;
            //Mostra a barra de status como ativada
            barraDeStatusToolStripMenuItem.Checked = true;
        }

        private void atualizaPosicao()
        {
            //Aqui iremos obter a localiza��o da linha e coluna atual que estamos digitando
            int linha = rchTxtBx.GetLineFromCharIndex(rchTxtBx.SelectionStart);
            int coluna = rchTxtBx.SelectionStart - rchTxtBx.GetFirstCharIndexFromLine(linha);
            //E aqui ser� na barra de status ser� atualizado com essas localiza��es
            tlStrpSttsLblCursor.Text = "Ln: " + linha.ToString() + " Col: " + coluna.ToString();
        }

        private void rchTxtBx_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
            this.atualizaPosicao();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Verifica se o texto foi alterado
            if (alterado)
            {
                if (MessageBox.Show("Seu arquivo foi alterado. Deseja salvar?", "Bloco de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Verifica se o nome do arquivo n�o est� vazio
                    if (this.Text != "")
                    {
                        this.salvar(this.Text);
                    }
                    else
                    {
                        //Se estiver tudo ok, ele chama o salvarComo e salva o arquivo
                        this.salvarComo();
                    }
                }
            }
            if (opnFlDlgAbrir.ShowDialog() == DialogResult.OK)
            {
                //Coloca o nome do arquivo como titulo
                this.Text = opnFlDlgAbrir.FileName;

                //Para ler todo o conte�do e colocar no richTextBox
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
                    //Salva o conte�do do RichTextBox no arquivo especificado
                    rchTxtBx.SaveFile(arquivo, RichTextBoxStreamType.RichText);
                    //Isso far� o nome da janela ser o nome do arquivo
                    this.Text = arquivo;
                    // Indica que o arquivo salvo n�o est� mais alterado
                    alterado = false;
                }
                //Caso tenho algum erro ao salvar, esse catch ir� fazer aparecer uma mensagem de erro
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Se o nome do arquivo for inv�lido, cair� aqui
            else
            {
                MessageBox.Show("Nome de arquivo � inv�lido.", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Desfaz a �ltima opera��o no RichTextBox
            rchTxtBx.Undo();
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rchTxtBx.SelectedRtf != "")
            {
                //Aqui ele vai salvar o texto recortado no Clipboard
                Clipboard.SetDataObject(rchTxtBx.SelectedRtf);
                //Aqui ele apagar� o texto recortado do RichTextBox
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
            // Verifica se h� texto no Clipboard
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                //Cola o texto do Clipboard no RichTextBox
                rchTxtBx.SelectedRtf = Clipboard.GetData(DataFormats.Text) as string; 
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
                //Para poder modificar os espa�os sem mudar o conteudo do RichTextBox
                string texto = rchTxtBx.SelectedText;
                //Troca todos os espa�os em branco para um sinal de +
                texto.Replace(' ', '+');
                //Aqui ele ir� abrir o Microsft edge e j� ir para a busca autom�tica
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

        private void quebraAutom�ticaDaLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verifica a op��o da quebra de linha
            if (quebraAutom�ticaDaLinhaToolStripMenuItem.CheckState == CheckState.Checked)
            {
                //Se a quebra de linha estiver desmarcada, ela ficar� desativada
                quebraAutom�ticaDaLinhaToolStripMenuItem.CheckState = CheckState.Unchecked;
                //Desativa a quebra de linha
                rchTxtBx.WordWrap = false;
            }
            else
            {
                //Se a quebra de linha estiver marcada, ela ficar� ativa
                quebraAutom�ticaDaLinhaToolStripMenuItem.CheckState = CheckState.Checked;
                //Ativa a quebra de linha
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

                //Para ler todo o conte�do e colocar no richTextBox
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
                //Abre a caixinha de fontes do VisualStudio
                rchTxtBx.SelectionFont = fntDlg.Font;
            }
        }

        private void barraDeStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Verifica se a barra de status est� ativada ou n�o
            barraDeStatusToolStripMenuItem.Checked = !barraDeStatusToolStripMenuItem.Checked;
            //Mostra ou tira a barra de status
            sttsStrp.Visible = !sttsStrp.Visible;
        }

        private void atualizaZoom()
        {
            //Atualiza o nivel de zoom na barra de status
            tlStrpSttsLblZoom.Text = this.zoom.ToString() + "%";
        }

        private void ampliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aumenta o zoom em 1
            this.zoom++;
            rchTxtBx.Font = new Font(rchTxtBx.Font.FontFamily, rchTxtBx.Font.Size + 1, rchTxtBx.Font.Style);
            this.atualizaZoom();
        }

        private void reduzirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Diminui o zoom em 1
            this.zoom--;
            rchTxtBx.Font = new Font(rchTxtBx.Font.FontFamily, rchTxtBx.Font.Size - 1, rchTxtBx.Font.Style);
            this.atualizaZoom();
        }

        private void restaurarZoomPadr�oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.zoom = 100;
            rchTxtBx.Font = new Font(rchTxtBx.Font.FontFamily, 12, rchTxtBx.Font.Style);
            this.atualizaZoom();
        }

        private void corToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                //Abre a caixinha de cores do VisualStudio
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
    }
}