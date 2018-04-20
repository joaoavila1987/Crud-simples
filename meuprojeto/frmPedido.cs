using MeuProjeto.Classes;
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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

     

        private void frmPedido_Load(object sender, EventArgs e)
        {
            DGVTabelaDeProdutos();
            DGVTabelaDePedido();
        }
        private void DGVTabelaDeProdutos()
        {

            //esta trazendo informações de Nome do produto, Custo

            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarMenuPedido();
            dgvListaProdutos.DataSource = datatable;
            dgvListaProdutos.Refresh();
        }

        private void DGVTabelaDePedido()
        {
            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarTelaPedido();
            dgvpedido.DataSource = datatable;
            dgvpedido.Refresh();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        
            

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
