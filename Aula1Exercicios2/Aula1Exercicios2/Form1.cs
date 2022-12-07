using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1Exercicios2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            Mensagem1.Visible = false;
        }

        private void Amarelo1_Click(object sender, EventArgs e)
        {
            Mensagem1.Visible=true;
            Mensagem1.BackColor = Color.Yellow;
            Mensagem1.Text = "Batata";
            
        }

        private void Vermelho1_Click(object sender, EventArgs e)
        {
            Mensagem1.Visible = true;
            Mensagem1.BackColor = Color.Red;
            Mensagem1.Text = "Tomate";
        }

        private void Mensagem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
