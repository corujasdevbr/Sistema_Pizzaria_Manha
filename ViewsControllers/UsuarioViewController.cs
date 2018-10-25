using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorio;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewsControllers
{
    //Classe reponsável por receber e mostrar os dados
    // referente ao Usuário
    public static class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRep = new UsuarioRepositorio();

        /// <summary>
        /// Metodo que representa a tela de cadastro de usuário
        /// Obtem nome, email e senha e mandar inserir
        /// </summary>
        public static void CadastrarUsuario(){
            string nome, email, senha;

            do
            {
                System.Console.WriteLine("Informe seu nome");
                nome = Console.ReadLine();

                if(string.IsNullOrEmpty(nome)){
                    Console.WriteLine("Nome inválido");
                }

            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.WriteLine("Informe o email com @ e .");
                email = Console.ReadLine();
                
                //Valida o e-mail seguindo as regras do metodo ValidarEmail
                //da classe ValidacaoUtil
                if(!ValidacaoUtil.ValidarEmail(email)){
                    System.Console.WriteLine("Email inválido");
                }

            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                System.Console.WriteLine("Informe a senha");
                senha = Console.ReadLine();
                
                if(!ValidacaoUtil.ValidarSenha(senha)){
                    System.Console.WriteLine("Senha inválida");
                }
            } while (!ValidacaoUtil.ValidarSenha(senha));
            
            //Cria um objeto do tipo UsuarioViewModel
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            //Atribui os valores ao objeto
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            //Manda inserir o objeto
            usuarioRep.Inserir(usuarioViewModel);

            //Mostra mensagem de usuário cadastrado
            System.Console.WriteLine("Usuário Cadastrado");
        }

        public static void ListarUsuarios(){
            List<UsuarioViewModel> lsUsuarios = usuarioRep.Listar();

            foreach (UsuarioViewModel item in lsUsuarios)
            {
                System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email}");
            }
        }
    }
}