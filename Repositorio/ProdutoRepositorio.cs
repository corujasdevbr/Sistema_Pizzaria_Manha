using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        static List<ProdutoViewModel> lsProdutos = new List<ProdutoViewModel>(); 

        /// <summary>
        /// Insere um novo produto
        /// </summary>
        /// <param name="produto">Produto que será inserido</param>
        /// <returns>Retorna o produto atualizado</returns>
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
            //Incrementa 1 no Id do objeto
            produto.Id = lsProdutos.Count + 1;
            //Altera a data de criação
            produto.DataCriacao = DateTime.Now;
            //Adiciona o produto na lista
            lsProdutos.Add(produto);
            //Retorna o produto
            return produto;
        }

        /// <summary>
        /// Lista os produtos
        /// </summary>
        /// <returns>Retorna uma lista de produtos</returns>
        public List<ProdutoViewModel> Listar(){
            return lsProdutos;
        }

        /// <summary>
        /// Buscar um Produto pelo seu Id
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Retorna o produto caso encontre ou null caso não encontre</returns>
        public  ProdutoViewModel BuscarPorId(int id){
            //Percorre a lista de Produtos
            foreach (ProdutoViewModel item in lsProdutos)
            {
                //Verifica se o Id do produto é igual ao id passado
                if(item.Id == id){
                    //Caso encontre retorna o item
                    return item;
                }
            }
            //caso não encontre retorna null
            return null;
        }
    }
}