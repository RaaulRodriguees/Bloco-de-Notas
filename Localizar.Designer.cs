namespace Bloco_de_Notas
{
    partial class Localizar
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
            bttn2 = new Button();
            bttn1 = new Button();
            txtBxLoc = new TextBox();
            chckBx2 = new CheckBox();
            chckBx1 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // bttn2
            // 
            bttn2.Location = new Point(256, 49);
            bttn2.Name = "bttn2";
            bttn2.Size = new Size(131, 28);
            bttn2.TabIndex = 11;
            bttn2.Text = "Cancelar";
            bttn2.UseVisualStyleBackColor = true;
            bttn2.Click += bttn2_Click;
            // 
            // bttn1
            // 
            bttn1.Location = new Point(256, 18);
            bttn1.Name = "bttn1";
            bttn1.Size = new Size(131, 28);
            bttn1.TabIndex = 10;
            bttn1.Text = "Localizar todas...";
            bttn1.UseVisualStyleBackColor = true;
            bttn1.Click += bttn1_Click;
            // 
            // txtBxLoc
            // 
            txtBxLoc.Location = new Point(74, 21);
            txtBxLoc.Name = "txtBxLoc";
            txtBxLoc.Size = new Size(163, 23);
            txtBxLoc.TabIndex = 9;
            // 
            // chckBx2
            // 
            chckBx2.AutoSize = true;
            chckBx2.Location = new Point(13, 80);
            chckBx2.Name = "chckBx2";
            chckBx2.Size = new Size(151, 19);
            chckBx2.TabIndex = 8;
            chckBx2.Text = "Coincidir palavra inteira";
            chckBx2.UseVisualStyleBackColor = true;
            // 
            // chckBx1
            // 
            chckBx1.AutoSize = true;
            chckBx1.Location = new Point(13, 55);
            chckBx1.Name = "chckBx1";
            chckBx1.Size = new Size(214, 19);
            chckBx1.TabIndex = 7;
            chckBx1.Text = "Diferenciar maiúscula de minúscula";
            chckBx1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Localizar:";
            // 
            // Localizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 103);
            Controls.Add(bttn2);
            Controls.Add(bttn1);
            Controls.Add(txtBxLoc);
            Controls.Add(chckBx2);
            Controls.Add(chckBx1);
            Controls.Add(label1);
            Name = "Localizar";
            Text = "Localizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn2;
        private Button bttn1;
        public TextBox txtBxLoc;
        private CheckBox chckBx2;
        private CheckBox chckBx1;
        private Label label1;
    }
}