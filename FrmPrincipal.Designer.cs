namespace introducao
{
    partial class FrmPrincipal
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSoma = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(713, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(365, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Maior";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.BackColor = System.Drawing.Color.Snow;
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.Location = new System.Drawing.Point(60, 213);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(0, 24);
            this.lblSoma.TabIndex = 4;
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValor1.Location = new System.Drawing.Point(64, 60);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(242, 20);
            this.txtValor1.TabIndex = 0;
            this.txtValor1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtValor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor1_KeyPress);
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValor2.Location = new System.Drawing.Point(64, 121);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(242, 20);
            this.txtValor2.TabIndex = 1;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            this.txtValor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor2_KeyPress);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.BackColor = System.Drawing.Color.Snow;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(158, 102);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(56, 16);
            this.lable2.TabIndex = 6;
            this.lable2.Text = "Valor 2";
            this.lable2.Click += new System.EventHandler(this.lable2_Click);
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValor3.Location = new System.Drawing.Point(64, 186);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(242, 20);
            this.txtValor3.TabIndex = 7;
            this.txtValor3.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtValor3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor 3";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 510);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introdução";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Label label2;
    }
}

