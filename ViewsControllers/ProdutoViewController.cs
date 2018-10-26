using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewsControllers
{
    /// <summary>
    /// Classe responsável pela visualização e controle dos dados
    /// </summary>
    public static class ProdutoViewController
    {
        //Objeto responsável pela gravação e leitura dos dados
        static ProdutoRepositorio produtoRep = new ProdutoRepositorio();
        public static void CadastrarProduto(){
            string nome, descricao, categoria, preco;
            
            #region View
            do
            {
                System.Console.WriteLine("Informe o nome do produto");
                nome = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome do produto inválido");
                }

            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Informe a descrição do produto");
                descricao = Console.ReadLine();
                
                if(string.IsNullOrEmpty(descricao)){
                    System.Console.WriteLine("Descrição do produto inválido");
                }

            } while (string.IsNullOrEmpty(descricao));

            do
            {
                System.Console.WriteLine("Informe o preço do produto");
                preco = Console.ReadLine();
                
                if(string.IsNullOrEmpty(preco)){
                    System.Console.WriteLine("Preço do produto inválido");
                }

            } while (string.IsNullOrEmpty(preco));

            do
            {
                System.Console.WriteLine("Informe a categoria(pizza ou bebida)");
                categoria = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidarCategoria(categoria)){
                    System.Console.WriteLine("Categoria inválida");
                }
            } while (!ValidacaoUtil.ValidarCategoria(categoria));
            #endregion

            #region Controller
                //Cria um objeto do tipo ProdutoViewModel
                ProdutoViewModel produtoViewModel = new ProdutoViewModel();
                //Atribui os valores ao objeto
                produtoViewModel.Nome = nome;
                produtoViewModel.Descricao = descricao;
                produtoViewModel.Preco = decimal.Parse(preco);
                produtoViewModel.Categoria = categoria;
                //Insere um novo produto
                produtoRep.Inserir(produtoViewModel);
                //Mostra a mensagem para o usuário
                System.Console.WriteLine("Produto cadastrado");
            #endregion
        }

        public static void ListarProdutos(){
            int idProduto = 0;

            //Obtê lista de produtos
            List<ProdutoViewModel> lsProdutos = produtoRep.Listar();

            //Fica no laço até o usuário digitar 0
            do
            {
                //Percorre a lista de produtos
                foreach (ProdutoViewModel item in lsProdutos)
                {
                    //MOstra na tela os produtos da lista
                    System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco}");
                }

                System.Console.WriteLine("Informe o id do produto para mais informações ou 0 para sair");
                //Recebe do usuário o Id do Produto ou 0
                idProduto = int.Parse(Console.ReadLine());

                //Verifica se o usuário digitou 0, caso sim sai do laço
                if(idProduto == 0){
                    break;
                }

                //Busca um produto pelo Id
                ProdutoViewModel produtoViewModel = produtoRep.BuscarPorId(idProduto);

                //Verifica se retornou um produto
                if(produtoViewModel != null){
                    //Caso sim mostra os dados na tela
                    Console.WriteLine($"{produtoViewModel.Id} - {produtoViewModel.Nome} - {produtoViewModel.Descricao} - {produtoViewModel.Categoria} - R$ {produtoViewModel.Preco.ToString("N2")}");
                } else {
                    //Caso não mostra produto não encontrado
                    System.Console.WriteLine("Produto não encontrado");
                }

            } while (idProduto != 0);
        }

        public static void ExibirTotal(){
            //Armazena na variável lsProdutos os produtos cadastrados
            List<ProdutoViewModel> lsProdutos = produtoRep.Listar();

            decimal TotalPreco = 0.0M;
            //Percorre a lista de produtos
            foreach (ProdutoViewModel item in lsProdutos)
            {
                //Soma o preço do produto
                TotalPreco += item.Preco;
            }

            //Exibe na tela o valor total e quantidade de produtos cadastrados
            System.Console.WriteLine($"O preço total é de R$ {TotalPreco.ToString("N2")} e você possui {lsProdutos.Count} produtos cadastrados");

        }
    }
}