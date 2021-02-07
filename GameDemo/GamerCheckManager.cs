using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            return true;
        }
    }
}
