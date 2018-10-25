
namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe responsável pelos dados do Usuário
    /// Herda da classe Base
    /// Para herdar utilizar : e o nome da classe que deseja herdar
    /// </summary>
    public class UsuarioViewModel : BaseViewModel
    {
        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Senha { get; set; }
    }
}