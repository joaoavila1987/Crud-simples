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
    public partial class frmformacaoComposto : Form
    {
        public frmformacaoComposto()
        {
            InitializeComponent();
        }

        private void frmformacaoComposto_Load(object sender, EventArgs e)
        {
            CarregarDGV();

        }
        private void CarregarDGV()
        {
            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarMenuPedido();
            dgvprodutos.DataSource = datatable;
            dgvprodutos.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Classes.Go acao = new Classes.Go();

            TiposDeProdutos produto = new TiposDeProdutos()
            {
                //criar aqui a parte de captura dos dados para mandar para a composto stage 4
            };


        }
    }
}
