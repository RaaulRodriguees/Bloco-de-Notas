namespace Bloco_de_Notas
{
    partial class Substituir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBx1 = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            txtBx2 = new TextBox();
            bttn1 = new Button();
            bttn2 = new Button();
            SuspendLayout();
            // 
            // txtBx1
            // 
            txtBx1.Location = new Point(93, 20);
            txtBx1.Name = "txtBx1";
            txtBx1.Size = new Size(160, 23);
            txtBx1.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(31, 23);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(56, 15);
            lbl1.TabIndex = 1;
            lbl1.Text = "Localizar:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(6, 58);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(81, 15);
            lbl2.TabIndex = 2;
            lbl2.Text = "Substituir por:";
            // 
            // txtBx2
            // 
            txtBx2.Location = new Point(93, 55);
            txtBx2.Name = "txtBx2";
            txtBx2.Size = new Size(160, 23);
            txtBx2.TabIndex = 3;
            // 
            // bttn1
            // 
            bttn1.Location = new Point(280, 14);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(137, 33);
            bttn1.TabIndex = 4;
            bttn1.Text = "Substituir tudo";
            bttn1.UseVisualStyleBackColor = true;
            bttn1.Click += button1_Click;
            // 
            // bttn2
            // 
            bttn2.Location = new Point(280, 55);
            bttn2.Name = "bttn2";
            bttn2.Size = new Size(137, 33);
            bttn2.TabIndex = 5;
            bttn2.Text = "Cancelar";
            bttn2.UseVisualStyleBackColor = true;
            bttn2.Click += bttn2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 93);
            Controls.Add(bttn2);
            Controls.Add(bttn1);
            Controls.Add(txtBx2);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtBx1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl1;
        private Label lbl2;
        private Button bttn1;
        private Button bttn2;
        public TextBox txtBx1;
        public TextBox txtBx2;
    }
}