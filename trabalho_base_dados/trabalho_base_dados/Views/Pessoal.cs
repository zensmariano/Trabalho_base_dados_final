using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho_base_dados.Model;
using trabalho_base_dados.Controller;

namespace trabalho_base_dados
{
    public partial class Pessoal : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        List<Cliente> clientes = new List<Cliente>();
=======
        List<ClienteMoradaContacto> clientes = new List<ClienteMoradaContacto>();
>>>>>>> parent of cb7212f... ALMOST
        ClienteController cc = new ClienteController();
=======
        List<ClienteMoradaContacto> clientes = new List<ClienteMoradaContacto>();
        ClienteController cc = new ClienteController();
        FuncionarioController cc = new FuncionarioController();
        FornecedorController cc = new FornecedorController();
>>>>>>> origin/nelionBlade
        public Pessoal()
        {
            InitializeComponent();
            //clientes = cc.GetClientes();
            UpdateBindingCliente();
        }
        public void UpdateBindingCliente()
        {
            ClienteDataGridView.DataSource = clientes;
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

        private void NometxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        // adicionar
        private void addBtn_Click(object sender, EventArgs e)
        {
            
            //clientes = cc.AddClient(
            //    NomeTxtBox.Text,
            //    Int32.Parse(NifTxtBox.Text),
            //    DateTime.Now.Date);
            //clientes = 
            UpdateBindingCliente();
        }
        // ver
        private void verBtn_Click(object sender, EventArgs e)
        {
            ClienteController cc = new ClienteController();

            //clientes = cc.GetClientes();
            clientes = cc.GetClientesTotal();
            ClienteDataGridView.DataSource = clientes;
<<<<<<< HEAD
<<<<<<< HEAD
            ClienteDataGridView.Refresh();
=======
           // ClienteDataGridView.DataBind

>>>>>>> origin/nelionBlade
=======
            ClienteDataGridView.DataBind

>>>>>>> parent of cb7212f... ALMOST
        }

        private void ElmBtn_Click(object sender, EventArgs e)
        {
            ClienteController cc = new ClienteController();
            //clientes = cc.DeleteCliente();   
            foreach (DataGridViewCell cell in ClienteDataGridView.SelectedCells)
            {
                if (cell.OwningColumn.HeaderText.ToUpper() == "CLIENTE_ID")
                {
                    int id;
                    int.TryParse(cell.Value.ToString(), out id);
                    //clientes = cc.DeleteCliente(id);
                }
            }
            UpdateBindingCliente();
        }

        private void ClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AltBtn_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FuncionarioController cc = new FuncionarioController();
            //clientes = cc.DeleteCliente();   
            foreach (DataGridViewCell cell in ClienteDataGridView.SelectedCells)
            {
                if (cell.OwningColumn.HeaderText.ToUpper() == "FUNCIONARIO_ID")
                {
                    int id;
                    int.TryParse(cell.Value.ToString(), out id);
                    //clientes = cc.DeleteCliente(id);
                }
            }
            UpdateBindingCliente();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FornecedorController cc = new FornecedorController();
            //clientes = cc.DeleteCliente();   
            foreach (DataGridViewCell cell in ClienteDataGridView.SelectedCells)
            {
                if (cell.OwningColumn.HeaderText.ToUpper() == "FORNECEDOR_ID")
                {
                    int id;
                    int.TryParse(cell.Value.ToString(), out id);
                    //clientes = cc.DeleteCliente(id);
                }
            }
            UpdateBindingCliente();
        }
    }
}
