using GameEngine.Entity;

namespace GameEngine
{
    internal class Score
    {
        private static int playerScore = 0;

        private const int SCORE_X_POSITION = 32;

        private const int SCORE_Y_POSITION = 0;

        public static void AddScore(int score)
        {
            playerScore += score;
        }

        public static void Render()
        {
            Console.SetCursorPosition(SCORE_X_POSITION, SCORE_Y_POSITION);
            Console.WriteLine($"Score: {playerScore}");
        }
    }
}
