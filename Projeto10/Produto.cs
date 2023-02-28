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

        public string GetNome()
        {
            return _nome;   
        }
        public double GetPreco()
        {
            return _preco; 
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }
        public void SetPreco(double preco)
        {
            _preco = preco;
        }
        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }
        public Produto(){
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
