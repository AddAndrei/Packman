
using GameEngine.Entity;

namespace GameEngine
{
    internal class Input
    { 
        public void HandleInput(ConsoleKeyInfo pressedKey, Packman packman, char[,] map)
        {
            int[] directions = GetDirection(pressedKey);
            int nextPackmanPositionX = packman.xPosition + directions[0];
            int nextPackmanPositionY = packman.yPosition + directions[1];
            char nextCell = map[nextPackmanPositionX, nextPackmanPositionY];

            if (nextCell == ' ' || nextCell == '.')
            {
                packman.xPosition = nextPackmanPositionX;
                packman.yPosition = nextPackmanPositionY;

                if(nextCell == '.')
                {
                    Score.AddScore(1);
                    map[nextPackmanPositionX, nextPackmanPositionY] = ' ';
                }
            }
        }

        private int[] GetDirection(ConsoleKeyInfo pressedKey)
        {
            int[] direction = { 0, 0};

            switch (pressedKey.Key)
            {
                case ConsoleKey.RightArrow:
                    direction[0] = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    direction[0] = -1;
                    break;
                case ConsoleKey.UpArrow:
                    direction[1] = -1;
                    break;
                case ConsoleKey.DownArrow:
                    direction[1] = 1;
                    break;
            }

            return direction;
        }

    }
}
