﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionWindows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario del Cliente
            Mantenimiento.frmCliente fmr = new Mantenimiento.frmCliente();
            fmr.MdiParent = this;// Es hijo del formulario principal
            fmr.Show();
        }
    }
}
