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
    public partial class MainBoard : Form
    {
        ControllerClientes controllerClientes;
        public MainBoard()
        {
            InitializeComponent();
            controllerClientes = new ControllerClientes();
            listBox1.DataSource = controllerClientes.ClienteList;
            listBox1.DisplayMember= "Cliente_Nome";
        }
    }
}
