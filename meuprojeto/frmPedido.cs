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
using System.Data.Common;
using System.Data.SqlClient;

namespace MeuProjeto
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
            btnRemover.Enabled = false;
            btnSalva.Enabled = false;

        }
        private void frmPedido_Load(object sender, EventArgs e)
        {

            CarregarTelaPedido();
            CarregarCusto();
          
        }
        private void CarregarTelaPedido()
        {
            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarTelaDePedido();
            dgvpedido.DataSource = datatable;
            dgvpedido.Refresh();
        }
        private void CarregarCusto()
        {
            Classes.Tela Somacusto = new Classes.Tela();
            string custo = Somacusto.CarregarCusto();
            decimal custoD = Convert.ToDecimal(custo);
            statusStrip1.Items[1].Text = String.Format("{0:2F}", custoD.ToString());
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
            btnSalva.Enabled = true;
            frmIncluirProduto form = new frmIncluirProduto();
            form.ShowDialog();
            dgvpedido.Refresh();
            CarregarTelaPedido();
            CarregarCusto();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
                Classes.Del acao = new Classes.Del();
            try
            {
                int id = (int)dgvpedido.CurrentRow.Cells[0].Value;
                acao.ExcluirProdutoDoPedido(id);
                dgvpedido.Refresh();
                CarregarTelaPedido();
                CarregarCusto();
            }
            catch (System.NullReferenceException)
            {
                btnRemover.Enabled = false;
                MessageBox.Show("Opa, não temos mais itens para retirar ");
            }  
        }
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Go acao = new Classes.Go();
                Classes.Del limpa = new Classes.Del();
                TiposDeProdutos produto = new TiposDeProdutos();
                foreach (DataGridViewRow linha in dgvpedido.Rows)
                {
                    produto.DataPedido = Convert.ToDateTime(txtData.Text);
                    produto.Funcionario = txtFuncionario.Text;
                    produto.Cod = (int)linha.Cells[1].Value;
                    produto.ProdutoSaida = linha.Cells[2].Value.ToString();
                    produto.Quantidade = (int)linha.Cells[3].Value;
                    produto.CustoS = Convert.ToDecimal(linha.Cells[4].Value);
                    produto.VendaS = Convert.ToDecimal(linha.Cells[6].Value);
                    acao.InserirHistoricoSaida(produto);
                }
                this.Close();
                limpa.LimparTabelaPedido();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ops ,Algo esta errado com a sua Data, por favor verifique ! ");
            }
        }
    }
}
