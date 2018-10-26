using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;
using Senai.OO.Pizzaria.MVC.ViewsControllers;

namespace Senai.OO.Pizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0, opcaoLogado = 0;
                        
            do
            {
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:{
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    }
                    case 2:{
                        //Chama a página Login e aguarda o retorno
                        UsuarioViewModel usuarioViewModel = UsuarioViewController.EfetuarLogin();

                        //Usuário é Válido
                        if(usuarioViewModel != null){
                            //Mensagem de Boas vindas
                            System.Console.WriteLine(" Seja bem vindo " + usuarioViewModel.Nome);

                            //Laço menu logado
                            do
                            {
                                //Mostra menu logado
                                MenuUtil.MenuLogado();

                                //Obtêm opção do menu
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado)
                                {
                                    case 1:{
                                        ProdutoViewController.CadastrarProduto();
                                        break;
                                    }
                                    case 2:{
                                        ProdutoViewController.ListarProdutos();
                                        break;
                                    }
                                    case 3:{
                                        ProdutoViewController.ExibirTotal();
                                        break;
                                    }
                                    case 0:{
                                        System.Console.WriteLine("Tchau!!!");
                                        break;
                                    }
                                    default:{
                                        System.Console.WriteLine("Opção inválida");
                                        break;
                                    }
                                }

                            } while (opcaoLogado != 0);
                        }
                        break;
                    }
                    case 3:{
                        UsuarioViewController.ListarUsuarios();
                        break;
                    }
                    case 0:{
                        System.Console.WriteLine("Tchau");
                        break;
                    }
                    default:{
                        Console.WriteLine("Opção inválida");
                        break;
                    }
                }

            } while (opcaoDeslogado != 0);

        }
    }
}
