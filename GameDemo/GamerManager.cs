using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class GamerManager : CustomerManager
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Malesef Gerçek bir kişi değil.");
            }
        }
    }
}
