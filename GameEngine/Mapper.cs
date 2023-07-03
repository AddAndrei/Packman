using GameEngine.Interfaces;
using System.Globalization;

namespace GameEngine
{
    public class Mapper : IReadMap
    {
        private const string PATH = "map.txt";

        private char[,]? _map = null;

        public Mapper()
        {
            ReadMap();
        }

        public void ReadMap()
        {
            string[] file = File.ReadAllLines(PATH);
            _map = new char[GetMaxLengthOfLine(file), file.Length];
            for (int x = 0;  x < _map.GetLength(0); x++)
            {
                for(int y = 0;  y < _map.GetLength(1); y++)
                {
                    _map[x, y] = file[y][x];
                }
            }

        }

        public char[,] GetMap()
        {
            return _map;
        }

        private int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;
            foreach (var line in lines)
            {
                if(line.Length > maxLength)
                    maxLength = line.Length;
                
            }
            return maxLength;
        }
       
    }
}