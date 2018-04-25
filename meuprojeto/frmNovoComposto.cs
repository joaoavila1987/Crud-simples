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
    public partial class frmNovoComposto : Form
    {
        public frmNovoComposto()
        {
            InitializeComponent();
        }
        private void frmNovoComposto_Load(object sender, EventArgs e)
        {
            CarregarDGV();
        }
        private void brnAdicionar_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmformacaoComposto forme = new frmformacaoComposto();
            forme.ShowDialog();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarDGV()
        {
            Classes.Tela visualizar = new Classes.Tela();
            DataTable datatable = visualizar.CarregarTelaCompostoStage();
            dgvproduto.DataSource = datatable;
            dgvproduto.Refresh();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Classes.Del deletar = new Classes.Del();
            
        }
    }
}
