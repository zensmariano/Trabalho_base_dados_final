using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_base_dados.Views
{
    public partial class ClienteUserControl : UserControl
    {
        ControllerClientes controllerClientes;
        public ClienteUserControl()
        {
            InitializeComponent();
            controllerClientes = new ControllerClientes();
            listBox1.DataSource = controllerClientes.ClienteList;
            listBox1.DisplayMember = "Cliente_Nome";
        }

    }
}
