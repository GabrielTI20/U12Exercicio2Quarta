namespace Aula1Exercicios2
{
    partial class form1
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
            this.Amarelo1 = new System.Windows.Forms.Button();
            this.Vermelho1 = new System.Windows.Forms.Button();
            this.Mensagem1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Amarelo1
            // 
            this.Amarelo1.BackColor = System.Drawing.Color.Yellow;
            this.Amarelo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amarelo1.Location = new System.Drawing.Point(84, 31);
            this.Amarelo1.Name = "Amarelo1";
            this.Amarelo1.Size = new System.Drawing.Size(162, 86);
            this.Amarelo1.TabIndex = 0;
            this.Amarelo1.Text = "Vegetal ";
            this.Amarelo1.UseVisualStyleBackColor = false;
            this.Amarelo1.Click += new System.EventHandler(this.Amarelo1_Click);
            // 
            // Vermelho1
            // 
            this.Vermelho1.BackColor = System.Drawing.Color.Red;
            this.Vermelho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vermelho1.Location = new System.Drawing.Point(84, 151);
            this.Vermelho1.Name = "Vermelho1";
            this.Vermelho1.Size = new System.Drawing.Size(162, 86);
            this.Vermelho1.TabIndex = 1;
            this.Vermelho1.Text = "vegetal";
            this.Vermelho1.UseVisualStyleBackColor = false;
            this.Vermelho1.Click += new System.EventHandler(this.Vermelho1_Click);
            // 
            // Mensagem1
            // 
            this.Mensagem1.AutoSize = true;
            this.Mensagem1.BackColor = System.Drawing.Color.White;
            this.Mensagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem1.Location = new System.Drawing.Point(284, 126);
            this.Mensagem1.Name = "Mensagem1";
            this.Mensagem1.Size = new System.Drawing.Size(96, 25);
            this.Mensagem1.TabIndex = 2;
            this.Mensagem1.Text = "Vegetais";
            this.Mensagem1.Click += new System.EventHandler(this.Mensagem1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mensagem1);
            this.Controls.Add(this.Vermelho1);
            this.Controls.Add(this.Amarelo1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Amarelo1;
        private System.Windows.Forms.Button Vermelho1;
        private System.Windows.Forms.Label Mensagem1;
    }
}

