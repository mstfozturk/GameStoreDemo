using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    interface ISalesService
    {
        void Buy(Game game, Gamer gamer);
    }
}
