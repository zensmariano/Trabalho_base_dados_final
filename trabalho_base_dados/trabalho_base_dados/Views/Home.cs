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
    public partial class Home : Form
    {
        private Panel panel;

        public Home()
        {
            InitializeComponent();
            Panel = panel1;
            Panel.Controls.Add(new UserControl1());
        }

        public Panel Panel { get => panel; set => panel = value; }
    }
}
