using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuProjeto.Classes
{
    public class TiposDeProdutos
    {

        //  usado na tabela de cadastro de produtos

        public int IDProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal CustoProduto { get; set; }
        public decimal VendaProduto { get; set; }
        public int QuantidadeProduto { get; set; }
        public int IDPedido { get; set; }
        public string DadaPedido { get; set; }
        public string Funcionario { get; set; }
        public int IDProdutoPedido { get; set; }
        public decimal CustoPedido { get; set; }
        public bool tipo { get; set; }  //false para simples,true para composto


    



    }
}
