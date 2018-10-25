using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorio
{
    /// <summary>
    /// Classe responsável pela leitura e gravação do Usuario
    /// </summary>
    public class UsuarioRepositorio
    {
        //Criação do objeto List que esta presente no namespace System.Collection.Generic
        //Responsável por armazenar as informações do Usuário
        List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();

        /// <summary>
        /// Metódo responsável por armazenar um usuário
        /// </summary>
        /// <param name="usuario">Usuário que será armazenado</param>
        /// <returns>Retorna um Usuário com os dados alterados</returns>
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            //Incrementa 1 no Id do objeto
            usuario.Id = lsUsuarios.Count + 1;
            //Define a Data e Hora da inserção do objeto na lista
            usuario.DataCriacao = DateTime.Now;
            //Insere o objeto usuário na Lista
            lsUsuarios.Add(usuario);
            //Retorna um usuário
            return usuario;
        }

        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna a Lista de Usuários Cadastrados</returns>
        public List<UsuarioViewModel> Listar(){
            //Retorna 
            return lsUsuarios;
        }
        
        /// <summary>
        /// Verifica se um usuário é válido
        /// </summary>
        /// <param name="email">Email do usuário</param>
        /// <param name="senha">Senha do usuário</param>
        /// <returns>Retorna um usuário caso o mesmo seja válido ou null caso não existe</returns>
        public UsuarioViewModel EfetuarLogin(string email, string senha){
            
            //Percorre a lista de usuários
            foreach (UsuarioViewModel item in lsUsuarios)
            {
                //Verifica se um usuário é válido, caso seja retorna o usuário
                if(item.Email == email && item.Senha == senha){
                    return item;
                }    
            }
            
            //Usuário não válido retorna null
            return null;
        }
    }
}       