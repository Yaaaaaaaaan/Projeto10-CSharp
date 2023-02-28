using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto10
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value != 0)
                {
                    _preco = value;
                }
            }
        }
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value != 0)
                {
                    _quantidade = value;
                }
            }
        }
        public void SetQuantidade(int quantidade)
        {
            if(quantidade != 0) {
                _quantidade = quantidade;
            }
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
