using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuProjeto
{
    public partial class frmAtualizarProduto : Form
    {
        public frmAtualizarProduto()
        {
            InitializeComponent();
        }

        private void frmAtualizarProduto_Load(object sender, EventArgs e)
        {

        }
        private void CarregarDGV()
        {
            Classes.Tela produto = new Classes.Tela();
            DataTable datatable = produto.CarregarMenuPedido();
            dgvAtualizarProduto.DataSource = datatable;
            dgvAtualizarProduto.Refresh();
        }
    }
}
