using GameLibraryDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationDemo
{
    class Game : IGame
    {
        IPlayer _player;
        public Game(IPlayer player)
        {
            _player = player;
        }

        public void Run()
        {
            _player.LookIntoBank();
            _player.CraftItem();
            
        }
    }
}
