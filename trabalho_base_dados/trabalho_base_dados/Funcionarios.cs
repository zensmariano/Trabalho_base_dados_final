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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nelsadaDataSet);

        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nelsadaDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.nelsadaDataSet.Funcionario);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
