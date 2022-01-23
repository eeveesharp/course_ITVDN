using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Field field = new Field();
            Player player = new Player();
            field.SetField();
            field.GetField();
            Game game = new Game(field,player);
            game.GetPosition();
            field.GetField();
        }
    }
}
