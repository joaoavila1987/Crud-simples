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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovoSimples_Click(object sender, EventArgs e)
        {
            //abrindo a tela de cadastro de produto simples através do botão na tela principal.

            frmCadastroSimples cadastro = new frmCadastroSimples();
            cadastro.ShowDialog();
        }

        private void cadastroSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrindo a tela de novo cadastro de produto simples pelo menu superior da tela principal.

            frmCadastroSimples cadastro = new frmCadastroSimples();
            cadastro.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            // abrindo o formulário de Novo pedido atravé do botão na tela principal 

            frmPedido pedido = new frmPedido();
            pedido.ShowDialog();
            
        }

        private void btnNovoComposto_Click(object sender, EventArgs e)
        {
            //abrindo o formulário para novos produtos compostos

            frmNovoComposto form = new frmNovoComposto();
            form.ShowDialog();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo o formulário de Novo pedido através do menu superior

            frmPedido pedido = new frmPedido();
            pedido.ShowDialog();

        }

        private void atualizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo o formulário de atualização de Pedidos através do menu superior.

            frmListaPedidos form = new frmListaPedidos();
            form.ShowDialog();
        }

        private void cadastroCompostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo o formulário de produos compostos.

            frmNovoComposto form = new frmNovoComposto();
            form.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo formulário de atualização de produtos pelo menu

            frmAtualizarProduto forme = new frmAtualizarProduto();
            forme.ShowDialog();
        }
    }
}
