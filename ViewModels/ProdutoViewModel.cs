namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe responsável pelas informações do produto
    /// Herda da classe BaseViewModel
    /// </summary>
    public class ProdutoViewModel : BaseViewModel
    {
        /// <summary>
        /// Descrição do Produto
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Preco { get; set; }
        /// <summary>
        /// Categoria do Produto
        /// </summary>
        public string Categoria { get; set; }
    }
}