﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFunilaria
{
    public partial class Cad_Veiculo : Form
    {
        public Cad_Veiculo()
        {
            InitializeComponent();
        }

        private void bt_Pesquisar_Click(object sender, EventArgs e)
        {
            Lista_CLientes frm = new Lista_CLientes();
            frm.Show();
        }
    }
}
