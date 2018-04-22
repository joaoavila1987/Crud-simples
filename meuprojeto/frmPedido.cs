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
          
            CarregarTelaProduto();
        }
        private void CarregarTelaProduto()
        {

            //esta trazendo informações de ID do Produro, Nome do produto, Custo

            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarMenuPedido();
            dgvprodutos.DataSource = datatable;
            dgvprodutos.Refresh();
        }

        private void CarregarTelaPedido()
        {
            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarProdutosPedidos();
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


        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Classes.Go acao = new Classes.Go();

            TiposDeProdutos produto = new TiposDeProdutos()
            {
                DadaPedido = txtData.Text,
                Funcionario = txtFuncionario.Text,
                IDProdutoPedido = (int)dgvprodutos.CurrentRow.Cells[0].Value,
                CustoPedido = Convert.ToDecimal(dgvprodutos.CurrentRow.Cells[2].Value),
            };
            acao.InserirDadosPedido(produto);
            dgvpedido.Refresh();
            CarregarTelaPedido();
            
        }
    }
}
