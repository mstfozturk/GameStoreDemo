using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class SalesManager : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " adlı kullanıcı " + game.Name + " adlı oyunu aldı.");
        }
    }
}
