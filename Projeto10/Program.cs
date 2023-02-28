﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Projeto10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome; ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço; ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto Prod = new Produto();
            Prod.SetNome(nome);
            Prod.SetPreco(preco);
            Console.WriteLine();
            Console.WriteLine("Dados do produto; " +Prod);
            Console.WriteLine();
            Console.Write("Valor a ser somado no estoque; ");
            int qtd = int.Parse(Console.ReadLine());
            Prod.AdicionarProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados; " + Prod);
            Console.WriteLine();
            Console.Write("Valor a ser subtraído do estoque; ");
            qtd = int.Parse(Console.ReadLine());
            Prod.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados; " + Prod);
            Console.ReadLine();
        }
    }
}
