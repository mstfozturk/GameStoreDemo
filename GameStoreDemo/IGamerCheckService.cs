using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    interface IGamerCheckService
    {
        bool CheckPerson(Gamer gamer);
    }
}
