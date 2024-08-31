using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lanchonete
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Pedido pendente! Preencha todos os campos.", "Aviso");
            }
            else
            {
               
                MessageBox.Show("Pedido confirmado, Dirija-se ao balcão de atendimento.", "Confirmação");
            }
        }

        private void CARDÁPIO_Click(object sender, EventArgs e)
        {

        }
    }
}


