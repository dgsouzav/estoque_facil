﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class formCadastroUsuario : Form
    {
        public formCadastroUsuario()
        {
            InitializeComponent();
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.cmbNivelAcesso.Items.Add("Administrador");
            this.cmbNivelAcesso.Items.Add("Caixa");
            this.cmbNivelAcesso.Items.Add("Vendedor");
            this.cmbNivelAcesso.SelectedIndex = 0;
        }
    }
}
