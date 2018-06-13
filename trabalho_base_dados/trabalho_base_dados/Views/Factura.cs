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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void faturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.faturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nelsadaDataSet);

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nelsadaDataSet.Fatura'. Você pode movê-la ou removê-la conforme necessário.
            this.faturaTableAdapter.Fill(this.nelsadaDataSet.Fatura);

        }

        private void faturaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
