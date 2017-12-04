namespace Chess.Constants
{
    public static class Constant
    {
        private const int _row = 8;
        private const int _col = 8;
        private static readonly char[] _rowName = new char[8] {'A','B','C','D','E','F','G','H'};

        public static int Row
        {
            get
            {
                return _row;
            }
        }

        public static int Col
        {
            get
            {
                return _col;
            }
        }

        public static char GetRowName(int index)
        {
            return _rowName[index];
        }

    }
}