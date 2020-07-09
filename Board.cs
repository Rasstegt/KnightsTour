using System;

namespace KnightsTour
{
    class Board : Tour
    {
        private const int Row = 8;
        private const int Col = 8;
        private static int[,] moves = new int[Row, Col];
        public string output;

        public Board()
        {
            moves = base.Moves;
        }

        public string PrintBoard(int steps, int average, string deviation)
        {
            for (int r = 0; r < Row; r++)
            {
                for (int c = 0; c < Col; c++)
                {
                    output += String.Format("0\t", moves[r, c]);
                }
                output += "\n";
            }
            output += String.Format("\nKnight was able to do {0} steps in this tour.", steps);
            output += String.Format("\nAverage of steps: {0}", average);
            output += String.Format("\nStandard deviation: {0}", deviation);

            return output;
        }

        public void CleanBoard()
        {
            for (int r = 0; r < Row; r++)
                for (int c = 0; c < Col; c++)
                    moves[r, c] = 0;
        }

    }
}
