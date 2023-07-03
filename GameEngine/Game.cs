using GameEngine.Entity;
using GameEngine.Enums;

namespace GameEngine
{
    public class Game
    {
        private Mapper _mapper;
        private Packman _packman;
        private Input _input;
        public Game() 
        {
            _mapper = new Mapper();
            _packman = new Packman();
            _input = new Input();  
        }

        public void Run()
        {
            char[,] map = _mapper.GetMap();
            Console.CursorVisible = false;
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo();

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Drawer.DrawMap(map);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(_packman.xPosition, _packman.yPosition);
                Console.Write($"{_packman.charForRender}");
                Score.Render();
                pressedKey = Console.ReadKey();
                _input.HandleInput(pressedKey, _packman, map);
            }

        }
    }
}
