using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_base_dados
{
    public partial class Producao : Form
    {
        public Producao()
        {
            InitializeComponent();
        }

        private void Producao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nelsadaDataSet.Producao'. Você pode movê-la ou removê-la conforme necessário.
            this.producaoTableAdapter.Fill(nelsadaDataSet.PRODUCAO);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
