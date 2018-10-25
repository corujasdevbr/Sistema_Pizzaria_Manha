using System;

namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe que será utilizada como base para
    /// outras classes
    /// Abstract define que a classe não poderá ser instanciada
    /// </summary>
    public abstract class BaseViewModel
    {
        /// <summary>
        /// Id do Objeto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do objeto que será herdado
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de criação do objeto na base de dados
        /// </summary>
        public DateTime DataCriacao { get; set; }
    }
}