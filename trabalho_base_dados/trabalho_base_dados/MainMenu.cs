﻿using System;
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
            Funcionarios clientes = new Funcionarios();
            clientes.Show();
        }

        private void producaoBtn_Click(object sender, EventArgs e)
        {

        }
        private void armazemBtn_Click(object sender, EventArgs e)
        {

        }
        private void marketBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
