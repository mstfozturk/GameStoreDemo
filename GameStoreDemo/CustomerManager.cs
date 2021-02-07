using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class CustomerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " deleted !!");
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " saved ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " Updated ");
        }
    }
}
