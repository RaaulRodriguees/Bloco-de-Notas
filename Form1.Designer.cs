namespace Bloco_de_Notas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sttsStrp = new StatusStrip();
            tlStrpSttsLblCodificacao = new ToolStripStatusLabel();
            tlStrpSttsLblFormato = new ToolStripStatusLabel();
            tlStrpSttsLblZoom = new ToolStripStatusLabel();
            tlStrpSttsLblCursor = new ToolStripStatusLabel();
            mnStrp = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            novaJanelaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            conToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            localizarToolStripMenuItem = new ToolStripMenuItem();
            localizarPróximaToolStripMenuItem = new ToolStripMenuItem();
            localizarToolStripMenuItem1 = new ToolStripMenuItem();
            substituirToolStripMenuItem = new ToolStripMenuItem();
            irParaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            selecionarTudoToolStripMenuItem = new ToolStripMenuItem();
            horaDataToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            quebraAutomáticaDaLinhaToolStripMenuItem = new ToolStripMenuItem();
            fonteToolStripMenuItem = new ToolStripMenuItem();
            corToolStripMenuItem = new ToolStripMenuItem();
            exibirToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            ampliarToolStripMenuItem = new ToolStripMenuItem();
            reduzirToolStripMenuItem = new ToolStripMenuItem();
            restaurarZoomPadrãoToolStripMenuItem = new ToolStripMenuItem();
            barraDeStatusToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            exibirAjudaToolStripMenuItem = new ToolStripMenuItem();
            enviarComentáriosToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            sobreOBlocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            opnFlDlgAbrir = new OpenFileDialog();
            rchTxtBx = new RichTextBox();
            svFlDlg = new SaveFileDialog();
            prntDcmnt = new System.Drawing.Printing.PrintDocument();
            pgStpDlg = new PageSetupDialog();
            prntDlg = new PrintDialog();
            fntDlg = new FontDialog();
            clrDlg = new ColorDialog();
            sttsStrp.SuspendLayout();
            mnStrp.SuspendLayout();
            SuspendLayout();
            // 
            // sttsStrp
            // 
            sttsStrp.Items.AddRange(new ToolStripItem[] { tlStrpSttsLblCodificacao, tlStrpSttsLblFormato, tlStrpSttsLblZoom, tlStrpSttsLblCursor });
            sttsStrp.Location = new Point(0, 322);
            sttsStrp.Name = "sttsStrp";
            sttsStrp.RightToLeft = RightToLeft.Yes;
            sttsStrp.Size = new Size(630, 24);
            sttsStrp.TabIndex = 0;
            sttsStrp.Text = "statusStrip1";
            // 
            // tlStrpSttsLblCodificacao
            // 
            tlStrpSttsLblCodificacao.Name = "tlStrpSttsLblCodificacao";
            tlStrpSttsLblCodificacao.Size = new Size(38, 19);
            tlStrpSttsLblCodificacao.Text = "UTF-8";
            // 
            // tlStrpSttsLblFormato
            // 
            tlStrpSttsLblFormato.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tlStrpSttsLblFormato.Name = "tlStrpSttsLblFormato";
            tlStrpSttsLblFormato.Size = new Size(100, 19);
            tlStrpSttsLblFormato.Text = "Windows(CR-LF)";
            // 
            // tlStrpSttsLblZoom
            // 
            tlStrpSttsLblZoom.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tlStrpSttsLblZoom.Name = "tlStrpSttsLblZoom";
            tlStrpSttsLblZoom.Size = new Size(39, 19);
            tlStrpSttsLblZoom.Text = "100%";
            // 
            // tlStrpSttsLblCursor
            // 
            tlStrpSttsLblCursor.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tlStrpSttsLblCursor.Name = "tlStrpSttsLblCursor";
            tlStrpSttsLblCursor.Size = new Size(57, 19);
            tlStrpSttsLblCursor.Text = "Ln: , Col:";
            // 
            // mnStrp
            // 
            mnStrp.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem, exibirToolStripMenuItem, ajudaToolStripMenuItem });
            mnStrp.Location = new Point(0, 0);
            mnStrp.Name = "mnStrp";
            mnStrp.Size = new Size(630, 24);
            mnStrp.TabIndex = 1;
            mnStrp.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, novaJanelaToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, salvarComoToolStripMenuItem, toolStripMenuItem2, conToolStripMenuItem, imprimirToolStripMenuItem, toolStripMenuItem3, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novoToolStripMenuItem.Size = new Size(280, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // novaJanelaToolStripMenuItem
            // 
            novaJanelaToolStripMenuItem.Name = "novaJanelaToolStripMenuItem";
            novaJanelaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            novaJanelaToolStripMenuItem.Size = new Size(280, 22);
            novaJanelaToolStripMenuItem.Text = "Nova janela                       ";
            novaJanelaToolStripMenuItem.Click += novaJanelaToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(280, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            salvarToolStripMenuItem.Size = new Size(280, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            salvarComoToolStripMenuItem.Size = new Size(280, 22);
            salvarComoToolStripMenuItem.Text = "Salvar como...";
            salvarComoToolStripMenuItem.Click += salvarComoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(277, 6);
            // 
            // conToolStripMenuItem
            // 
            conToolStripMenuItem.Name = "conToolStripMenuItem";
            conToolStripMenuItem.Size = new Size(280, 22);
            conToolStripMenuItem.Text = "Configurar página...";
            conToolStripMenuItem.Click += conToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(280, 22);
            imprimirToolStripMenuItem.Text = "Imprimir...";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(277, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(280, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desfazerToolStripMenuItem, toolStripMenuItem1, recortarToolStripMenuItem, copiarToolStripMenuItem, colarToolStripMenuItem, excluirToolStripMenuItem, toolStripMenuItem4, buscarToolStripMenuItem, localizarToolStripMenuItem, localizarPróximaToolStripMenuItem, localizarToolStripMenuItem1, substituirToolStripMenuItem, irParaToolStripMenuItem, toolStripMenuItem5, selecionarTudoToolStripMenuItem, horaDataToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            desfazerToolStripMenuItem.Size = new Size(250, 22);
            desfazerToolStripMenuItem.Text = "Desfazer";
            desfazerToolStripMenuItem.Click += desfazerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(247, 6);
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            recortarToolStripMenuItem.Size = new Size(250, 22);
            recortarToolStripMenuItem.Text = "Recortar";
            recortarToolStripMenuItem.Click += recortarToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(250, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(250, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            excluirToolStripMenuItem.ShortcutKeys = Keys.Delete;
            excluirToolStripMenuItem.Size = new Size(250, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(247, 6);
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            buscarToolStripMenuItem.Size = new Size(250, 22);
            buscarToolStripMenuItem.Text = "Buscar com o Bing...";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // localizarToolStripMenuItem
            // 
            localizarToolStripMenuItem.Name = "localizarToolStripMenuItem";
            localizarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            localizarToolStripMenuItem.Size = new Size(250, 22);
            localizarToolStripMenuItem.Text = "Localizar...";
            localizarToolStripMenuItem.Click += localizarToolStripMenuItem_Click;
            // 
            // localizarPróximaToolStripMenuItem
            // 
            localizarPróximaToolStripMenuItem.Name = "localizarPróximaToolStripMenuItem";
            localizarPróximaToolStripMenuItem.ShortcutKeys = Keys.F3;
            localizarPróximaToolStripMenuItem.Size = new Size(250, 22);
            localizarPróximaToolStripMenuItem.Text = "Localizar próxima";
            // 
            // localizarToolStripMenuItem1
            // 
            localizarToolStripMenuItem1.Name = "localizarToolStripMenuItem1";
            localizarToolStripMenuItem1.ShortcutKeys = Keys.Shift | Keys.F3;
            localizarToolStripMenuItem1.Size = new Size(250, 22);
            localizarToolStripMenuItem1.Text = "Localizar Anterior           ";
            // 
            // substituirToolStripMenuItem
            // 
            substituirToolStripMenuItem.Name = "substituirToolStripMenuItem";
            substituirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            substituirToolStripMenuItem.Size = new Size(250, 22);
            substituirToolStripMenuItem.Text = "Substituir";
            substituirToolStripMenuItem.Click += substituirToolStripMenuItem_Click;
            // 
            // irParaToolStripMenuItem
            // 
            irParaToolStripMenuItem.Name = "irParaToolStripMenuItem";
            irParaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            irParaToolStripMenuItem.Size = new Size(250, 22);
            irParaToolStripMenuItem.Text = "Ir para...";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(247, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            selecionarTudoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selecionarTudoToolStripMenuItem.Size = new Size(250, 22);
            selecionarTudoToolStripMenuItem.Text = "Selecionar tudo";
            selecionarTudoToolStripMenuItem.Click += selecionarTudoToolStripMenuItem_Click;
            // 
            // horaDataToolStripMenuItem
            // 
            horaDataToolStripMenuItem.Name = "horaDataToolStripMenuItem";
            horaDataToolStripMenuItem.ShortcutKeys = Keys.F5;
            horaDataToolStripMenuItem.Size = new Size(250, 22);
            horaDataToolStripMenuItem.Text = "Hora/Data";
            horaDataToolStripMenuItem.Click += horaDataToolStripMenuItem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quebraAutomáticaDaLinhaToolStripMenuItem, fonteToolStripMenuItem, corToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "&Formatar";
            // 
            // quebraAutomáticaDaLinhaToolStripMenuItem
            // 
            quebraAutomáticaDaLinhaToolStripMenuItem.Name = "quebraAutomáticaDaLinhaToolStripMenuItem";
            quebraAutomáticaDaLinhaToolStripMenuItem.Size = new Size(221, 22);
            quebraAutomáticaDaLinhaToolStripMenuItem.Text = "Quebra automática da linha";
            quebraAutomáticaDaLinhaToolStripMenuItem.Click += quebraAutomáticaDaLinhaToolStripMenuItem_Click;
            // 
            // fonteToolStripMenuItem
            // 
            fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            fonteToolStripMenuItem.Size = new Size(221, 22);
            fonteToolStripMenuItem.Text = "Fonte...";
            fonteToolStripMenuItem.Click += fonteToolStripMenuItem_Click;
            // 
            // corToolStripMenuItem
            // 
            corToolStripMenuItem.Name = "corToolStripMenuItem";
            corToolStripMenuItem.Size = new Size(221, 22);
            corToolStripMenuItem.Text = "Cor...";
            corToolStripMenuItem.Click += corToolStripMenuItem_Click;
            // 
            // exibirToolStripMenuItem
            // 
            exibirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, barraDeStatusToolStripMenuItem });
            exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            exibirToolStripMenuItem.Size = new Size(48, 20);
            exibirToolStripMenuItem.Text = "E&xibir";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ampliarToolStripMenuItem, reduzirToolStripMenuItem, restaurarZoomPadrãoToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(180, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // ampliarToolStripMenuItem
            // 
            ampliarToolStripMenuItem.Name = "ampliarToolStripMenuItem";
            ampliarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + sinal de adição";
            ampliarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            ampliarToolStripMenuItem.Size = new Size(248, 22);
            ampliarToolStripMenuItem.Text = "Ampliar";
            ampliarToolStripMenuItem.Click += ampliarToolStripMenuItem_Click;
            // 
            // reduzirToolStripMenuItem
            // 
            reduzirToolStripMenuItem.Name = "reduzirToolStripMenuItem";
            reduzirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            reduzirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            reduzirToolStripMenuItem.Size = new Size(248, 22);
            reduzirToolStripMenuItem.Text = "Reduzir";
            reduzirToolStripMenuItem.Click += reduzirToolStripMenuItem_Click;
            // 
            // restaurarZoomPadrãoToolStripMenuItem
            // 
            restaurarZoomPadrãoToolStripMenuItem.Name = "restaurarZoomPadrãoToolStripMenuItem";
            restaurarZoomPadrãoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            restaurarZoomPadrãoToolStripMenuItem.Size = new Size(248, 22);
            restaurarZoomPadrãoToolStripMenuItem.Text = "Restaurar zoom padrão";
            restaurarZoomPadrãoToolStripMenuItem.Click += restaurarZoomPadrãoToolStripMenuItem_Click;
            // 
            // barraDeStatusToolStripMenuItem
            // 
            barraDeStatusToolStripMenuItem.Name = "barraDeStatusToolStripMenuItem";
            barraDeStatusToolStripMenuItem.Size = new Size(180, 22);
            barraDeStatusToolStripMenuItem.Text = "Barra de status";
            barraDeStatusToolStripMenuItem.Click += barraDeStatusToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exibirAjudaToolStripMenuItem, enviarComentáriosToolStripMenuItem, toolStripMenuItem6, sobreOBlocoDeNotasToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // exibirAjudaToolStripMenuItem
            // 
            exibirAjudaToolStripMenuItem.Name = "exibirAjudaToolStripMenuItem";
            exibirAjudaToolStripMenuItem.Size = new Size(195, 22);
            exibirAjudaToolStripMenuItem.Text = "Exibir ajuda";
            // 
            // enviarComentáriosToolStripMenuItem
            // 
            enviarComentáriosToolStripMenuItem.Name = "enviarComentáriosToolStripMenuItem";
            enviarComentáriosToolStripMenuItem.Size = new Size(195, 22);
            enviarComentáriosToolStripMenuItem.Text = "Enviar comentários";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(192, 6);
            // 
            // sobreOBlocoDeNotasToolStripMenuItem
            // 
            sobreOBlocoDeNotasToolStripMenuItem.Name = "sobreOBlocoDeNotasToolStripMenuItem";
            sobreOBlocoDeNotasToolStripMenuItem.Size = new Size(195, 22);
            sobreOBlocoDeNotasToolStripMenuItem.Text = "Sobre o bloco de notas";
            // 
            // opnFlDlgAbrir
            // 
            opnFlDlgAbrir.Filter = "Todos os arquivos (*.*)|*.*|Arquivo de Texto (*.txt)|*.txt|Documentos de Texto (*.rtf)|*.rtf|Todas as Imagens(*.jpg;*.jpeg;*.png;*.gif;*.webp;*.ico)|*.jpg;*.jpeg;*.png;*.gif;*.webp;*.ico";
            opnFlDlgAbrir.InitialDirectory = "C:";
            opnFlDlgAbrir.Title = "Abrir arquivo";
            // 
            // rchTxtBx
            // 
            rchTxtBx.BackColor = SystemColors.ScrollBar;
            rchTxtBx.Dock = DockStyle.Fill;
            rchTxtBx.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rchTxtBx.Location = new Point(0, 24);
            rchTxtBx.Name = "rchTxtBx";
            rchTxtBx.Size = new Size(630, 298);
            rchTxtBx.TabIndex = 2;
            rchTxtBx.Text = "";
            rchTxtBx.TextChanged += rchTxtBx_TextChanged;
            // 
            // svFlDlg
            // 
            svFlDlg.Filter = "Arquivo de Texto (*.txt)|*.txt|Documentos de Texto (*.rtf)|*.rtf|Todos os arquivos (*.*)|*.* ";
            svFlDlg.Title = "Salvar como...";
            // 
            // pgStpDlg
            // 
            pgStpDlg.Document = prntDcmnt;
            // 
            // prntDlg
            // 
            prntDlg.Document = prntDcmnt;
            prntDlg.UseEXDialog = true;
            // 
            // fntDlg
            // 
            fntDlg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 346);
            Controls.Add(rchTxtBx);
            Controls.Add(sttsStrp);
            Controls.Add(mnStrp);
            KeyPreview = true;
            MainMenuStrip = mnStrp;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            sttsStrp.ResumeLayout(false);
            sttsStrp.PerformLayout();
            mnStrp.ResumeLayout(false);
            mnStrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip sttsStrp;
        private MenuStrip mnStrp;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem exibirToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem novaJanelaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripMenuItem conToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem ampliarToolStripMenuItem;
        private ToolStripMenuItem reduzirToolStripMenuItem;
        private ToolStripMenuItem restaurarZoomPadrãoToolStripMenuItem;
        private ToolStripMenuItem barraDeStatusToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem quebraAutomáticaDaLinhaToolStripMenuItem;
        private ToolStripMenuItem fonteToolStripMenuItem;
        private ToolStripMenuItem localizarToolStripMenuItem;
        private ToolStripMenuItem localizarPróximaToolStripMenuItem;
        private ToolStripMenuItem localizarToolStripMenuItem1;
        private ToolStripMenuItem substituirToolStripMenuItem;
        private ToolStripMenuItem irParaToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private ToolStripMenuItem horaDataToolStripMenuItem;
        private ToolStripMenuItem exibirAjudaToolStripMenuItem;
        private ToolStripMenuItem enviarComentáriosToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem sobreOBlocoDeNotasToolStripMenuItem;
        private OpenFileDialog opnFlDlgAbrir;
        private SaveFileDialog svFlDlg;
        private System.Drawing.Printing.PrintDocument prntDcmnt;
        private PageSetupDialog pgStpDlg;
        private PrintDialog prntDlg;
        private FontDialog fntDlg;
        private ToolStripStatusLabel tlStrpSttsLblCodificacao;
        private ToolStripStatusLabel tlStrpSttsLblFormato;
        private ToolStripStatusLabel tlStrpSttsLblZoom;
        private ToolStripStatusLabel tlStrpSttsLblCursor;
        private ToolStripMenuItem corToolStripMenuItem;
        private ColorDialog clrDlg;
        public RichTextBox rchTxtBx;
    }
}