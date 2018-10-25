namespace Senai.OO.Pizzaria.MVC.Util
{
    /// <summary>
    /// Classe responsável pelas validações de campos do sistema
    /// </summary>
    public static class ValidacaoUtil
    {
        /// <summary>
        /// Valida email do usuário, verifica se o mesmo possui @ e .
        /// </summary>
        /// <param name="email">Email a ser validado</param>
        /// <returns>Retorna true caso o email possua @ e . ou false caso não possua</returns>
        public static bool ValidarEmail(string email){
            //Verifica se o e-mail possui @ e .
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica se senha informa possui mais que 6 caracteres
        /// </summary>
        /// <param name="senha">Senha a ser verificada</param>
        /// <returns>Retorna true caso a senha possua mais que 6 caracteres ou false caso não</returns>
        public static bool ValidarSenha(string senha){
            //Verifica se a senha possui mais que 6 caracteres
            if(senha.Length >= 6){
                return true;
            }

            return false;
        }
    }
}