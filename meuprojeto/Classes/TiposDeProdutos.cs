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
        public string Tipo { get; set; }  //"s" quando produto simples e "c" quando produtos compostos, essa tipificação será util nos relatórios
        //Itens para a tabela SAIDA STAGE 2
        public int ID { get; set; }
        public int IDProdutoS{get;set;}
        public string Produto { get; set; }
        public int Und {get;set;}
        public decimal Custo{ get; set; }
        public decimal SubTotal{ get; set; }
        public decimal Venda { get; set; }
        //Itens para a tabela saida history 2
        public DateTime DataPedido { get; set; }
        public string Funcionario { get; set; }
        public int Cod { get; set; }
        public string ProdutoSaida { get; set; }
        public int Quantidade { get; set; }
        public decimal CustoS { get; set; }
        public decimal VendaS { get; set; }
        //itens usados na tabela composto stage.
        public string Composto { get; set; }
        public decimal Cvenda { get; set; }
        public int ccod { get; set; }
        public string cnome { get; set; }
        public decimal  ccusto { get; set; }
        public decimal cvenda { get; set; }













    }
}
