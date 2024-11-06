namespace Exercício_2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbPesoIdeal = new System.Windows.Forms.Label();
            this.lbMascFem = new System.Windows.Forms.Label();
            this.rBMasculino = new System.Windows.Forms.RadioButton();
            this.rBFeminino = new System.Windows.Forms.RadioButton();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPesoIdealMascFem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(26, 15);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(77, 13);
            this.lbAltura.TabIndex = 0;
            this.lbAltura.Text = "Altura (metros):";
            // 
            // lbPesoIdeal
            // 
            this.lbPesoIdeal.AutoSize = true;
            this.lbPesoIdeal.Location = new System.Drawing.Point(27, 13);
            this.lbPesoIdeal.Name = "lbPesoIdeal";
            this.lbPesoIdeal.Size = new System.Drawing.Size(57, 13);
            this.lbPesoIdeal.TabIndex = 1;
            this.lbPesoIdeal.Text = "Peso Ideal";
            // 
            // lbMascFem
            // 
            this.lbMascFem.AutoSize = true;
            this.lbMascFem.Location = new System.Drawing.Point(39, 32);
            this.lbMascFem.Name = "lbMascFem";
            this.lbMascFem.Size = new System.Drawing.Size(13, 13);
            this.lbMascFem.TabIndex = 2;
            this.lbMascFem.Text = "--";
            // 
            // rBMasculino
            // 
            this.rBMasculino.AutoSize = true;
            this.rBMasculino.Location = new System.Drawing.Point(28, 33);
            this.rBMasculino.Name = "rBMasculino";
            this.rBMasculino.Size = new System.Drawing.Size(73, 17);
            this.rBMasculino.TabIndex = 3;
            this.rBMasculino.TabStop = true;
            this.rBMasculino.Text = "Masculino";
            this.rBMasculino.UseVisualStyleBackColor = true;
            this.rBMasculino.CheckedChanged += new System.EventHandler(this.rBMasculino_CheckedChanged);
            // 
            // rBFeminino
            // 
            this.rBFeminino.AutoSize = true;
            this.rBFeminino.Location = new System.Drawing.Point(28, 60);
            this.rBFeminino.Name = "rBFeminino";
            this.rBFeminino.Size = new System.Drawing.Size(67, 17);
            this.rBFeminino.TabIndex = 4;
            this.rBFeminino.TabStop = true;
            this.rBFeminino.Text = "Feminino";
            this.rBFeminino.UseVisualStyleBackColor = true;
            this.rBFeminino.CheckedChanged += new System.EventHandler(this.rBFeminino_CheckedChanged);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(54, 158);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(137, 40);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(283, 158);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(125, 40);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtAltura);
            this.panel1.Controls.Add(this.lbAltura);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 44);
            this.panel1.TabIndex = 9;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(114, 12);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(77, 20);
            this.txtAltura.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPesoIdealMascFem);
            this.panel2.Controls.Add(this.lbPesoIdeal);
            this.panel2.Controls.Add(this.lbMascFem);
            this.panel2.Location = new System.Drawing.Point(25, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 59);
            this.panel2.TabIndex = 10;
            // 
            // txtPesoIdealMascFem
            // 
            this.txtPesoIdealMascFem.Enabled = false;
            this.txtPesoIdealMascFem.Location = new System.Drawing.Point(115, 20);
            this.txtPesoIdealMascFem.Name = "txtPesoIdealMascFem";
            this.txtPesoIdealMascFem.Size = new System.Drawing.Size(77, 20);
            this.txtPesoIdealMascFem.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rBMasculino);
            this.panel3.Controls.Add(this.rBFeminino);
            this.panel3.Location = new System.Drawing.Point(283, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 114);
            this.panel3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 230);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbPesoIdeal;
        private System.Windows.Forms.Label lbMascFem;
        private System.Windows.Forms.RadioButton rBMasculino;
        private System.Windows.Forms.RadioButton rBFeminino;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPesoIdealMascFem;
    }
}

