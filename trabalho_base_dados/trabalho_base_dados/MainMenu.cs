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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }



        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pessoalBtn_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Pessoal pessoas = new Pessoal();
            pessoas.Show();
            
        }

        private void producaoBtn_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Producao vinho = new Producao();
            vinho.Show();
        }
        private void armazemBtn_Click(object sender, EventArgs e)
        {
            Armazem armazem = new Armazem();
            armazem.Show();
        }
        private void marketBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
