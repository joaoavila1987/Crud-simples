using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.Classes
{
    public class TiposDeProdutos
    {
        public int IDProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal CustoProduto { get; set; }
        public decimal VendaProduto { get; set; }
        public int QuantidadeProduto { get; set; }

        public int IDPedido { get; set; }
        public DateTime DadaPedido { get; set; }
        public string Funcionario { get; set; }
        public int IDProdutoPedido { get; set; }



    }
}
