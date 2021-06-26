using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Produto
    {
        public string _nomeProduto {
            get { return _nomeProduto; }
            set
            {
                if (value != null && value.Length > 1)
                    _nomeProduto = value;
            }
        }
        public double PrecoProduto { get; private set; }
        public int QntProduto { get; private set; }

        public Produto()
        {
            QntProduto = 0; 
        }

        public Produto(string nomeProduto, double precoProduto, int qntProduto)
        {
            this._nomeProduto = nomeProduto;
            this.PrecoProduto = precoProduto;
            this.QntProduto = qntProduto;
        }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = QntProduto * PrecoProduto;
            return valorTotal;
        }

        public void AdicionarProdutos(int qnt)
        {
            QntProduto = QntProduto + qnt;
        }

        public void RemoverProdutos(int qnt)
        {
            QntProduto = QntProduto - qnt;
        }

        public override string ToString()
        {
            return _nomeProduto
                + ",Valor: R$"
                + PrecoProduto.ToString("F2", CultureInfo.InvariantCulture) 
                + " Quantidade: " 
                + QntProduto 
                + " Valor Estoque: R$" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
