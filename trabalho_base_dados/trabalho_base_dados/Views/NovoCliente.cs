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
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nelsadaDataSet.MORADAS'. Você pode movê-la ou removê-la conforme necessário.
            this.mORADASTableAdapter.Fill(this.nelsadaDataSet.MORADAS);

        }

        private void mORADASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mORADASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nelsadaDataSet);

        }
    }
}
