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
    public partial class frmIncluirProduto : Form
    {
        public frmIncluirProduto()
        {
            InitializeComponent();
        }
        private void CarregarTelaProduto()
        {

            //esta trazendo informações de ID do Produro, Nome do produto, Custo

            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarMenuPedido();
            dgvPedido.DataSource = datatable;
            dgvPedido.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIncluirProduto_Load(object sender, EventArgs e)
        {
            CarregarTelaProduto();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Go acao = new Classes.Go();

                Classes.TiposDeProdutos produto = new Classes.TiposDeProdutos()
                {
                    IDProdutoS = (int)dgvPedido.CurrentRow.Cells[0].Value,
                    Produto = dgvPedido.CurrentRow.Cells[1].Value.ToString(),
                    Und = Convert.ToInt32(txbQuantidade.Text),
                    Custo = Convert.ToDecimal(dgvPedido.CurrentRow.Cells[2].Value),
                    SubTotal = Convert.ToInt32(txbQuantidade.Text)* Convert.ToDecimal(dgvPedido.CurrentRow.Cells[2].Value),
                    Venda = Convert.ToDecimal(dgvPedido.CurrentRow.Cells[3].Value)

                };
                acao.InserirDadosPedido(produto);
                this.Close();

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Opa, você esqueceu de lançar a quantidade ");
            }
            
        }
    }
}
//