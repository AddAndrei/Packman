namespace GameEngine
{
    public static class Drawer
    {
        public static void DrawMap(char[,] map)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

    }
}
