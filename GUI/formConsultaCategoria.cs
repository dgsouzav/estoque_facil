using BLL;
using DAL;
using System;
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
    public partial class formConsultaCategoria : Form
    {
        public int id = 0;
        public formConsultaCategoria()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            dtgvDados.DataSource = bll.Localizar(txtConsultaCategoria.Text);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // voltar ao FormPrincipal
            this.Close();
        }

        private void formConsultaCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click_1(sender, e);
            dtgvDados.Columns[0].HeaderText = "ID";
            dtgvDados.Columns[0].Width = 60;
            dtgvDados.Columns[1].HeaderText = "Categoria";
            dtgvDados.Columns[1].Width = 557;
        }
    }
}
