using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    public class Produto
    {
        public string nomeProduto;
        public double precoProduto;
        public int qntProduto;

        public double ValorTotalEmEstoque()
        {
            double valorTotal = qntProduto * precoProduto;
            return valorTotal;
        }

        public void AdicionarProdutos(int qnt)
        {
            qntProduto = qntProduto + qnt;
        }

        public void RemoverProdutos(int qnt)
        {
            qntProduto = qntProduto - qnt;
        }

        public override string ToString()
        {
            return nomeProduto
                + ",Valor: R$"
                + precoProduto.ToString("F2", CultureInfo.InvariantCulture) 
                + " Quantidade: " 
                + qntProduto 
                + " Valor Estoque: R$" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
