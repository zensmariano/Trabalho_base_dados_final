using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_base_dados.Views
{
    public partial class TipoContacto : Form
    {
        public TipoContacto()
        {
            InitializeComponent();
        }

        private void tIPO_CONTACTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tIPO_CONTACTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nelsadaDataSet);

        }

        private void TipoContacto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nelsadaDataSet.TIPO_CONTACTO'. Você pode movê-la ou removê-la conforme necessário.
            this.tIPO_CONTACTOTableAdapter.Fill(this.nelsadaDataSet.TIPO_CONTACTO);

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }
    }
}
