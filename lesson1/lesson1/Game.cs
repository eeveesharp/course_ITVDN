using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1
{
    class Game
    {
        public Field Field { get; set; }

        public Player Player { get; set; }

        public Game(Field field,Player player)
        {
            Field = field;
            Player = player;
        }

        public void GetPosition()
        {
            Point point;

            point = Player.GetPosition();

            Field.PlayField[point.X, point.Y] = "X";           
        }
    }
}
