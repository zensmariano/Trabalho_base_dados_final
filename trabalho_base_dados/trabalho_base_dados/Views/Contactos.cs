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
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private void contactosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nelsadaDataSet);

        }

        private void Contactos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'nelsadaDataSet.Contactos'. Você pode movê-la ou removê-la conforme necessário.
            this.contactosTableAdapter.Fill(this.nelsadaDataSet.Contactos);

        }
    }
}
