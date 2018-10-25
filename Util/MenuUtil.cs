using System;

namespace Senai.OO.Pizzaria.MVC.Util
{
    /// <summary>
    /// Classe responsável pela criação dos menus 
    /// do sistema
    /// </summary>
    public static class MenuUtil
    {
        /// <summary>
        /// Mostra os opções do usuário deslogado
        /// </summary>
        public static void MenuDeslogado(){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria TkPizza---------------");
            Console.WriteLine("-------------      Conta      --------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Usuário            ");
            Console.WriteLine("           (2) Efetuar Login                ");
            Console.WriteLine("           (3) Listar                       ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }

        /// <summary>
        /// Mostra as opções do usuário logado
        /// </summary>
        public static void MenuLogado(){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Pizzaria TkPizza---------------");
            Console.WriteLine("-----------      Cardápio      -------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (1) Cadastrar Produto            ");
            Console.WriteLine("           (2) Listar                       ");
            Console.WriteLine("           (3) Valor Total                  ");
            Console.WriteLine("           (4) Alterar                      ");
            Console.WriteLine("           (4) Remover                      ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           (0) Sair                         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("           Escolha uma opção                ");
        }
    }
}
