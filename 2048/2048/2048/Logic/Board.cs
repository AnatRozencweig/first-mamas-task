using System;


namespace _2048.Logic
{
    class Board
    {
        public int[,] Data { get; protected set; }
        public Board()
        {
            Data = new int[4,4];
        }
        public void PlacesSpecificCell(int x, int y, int value)
        {
            Data[x, y] = value;
        }
        public int ChooseTwoOrFour()
        {
            Random rnd = new Random();
            int zeroOrOne = rnd.Next(0,2);
            if(zeroOrOne == 0)
            {
                return 2;
            }
            else
            {
                return 4;
            }
        }
        public int ChooseRandomIndex()
        {
            Random rnd = new Random();
            int index = rnd.Next(Data.GetLength(0));
            return index;
        }
        public bool IsIndexEmpty(int x, int y)
        {
            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    if(i == x && j == y)
                    {
                        if (Data[x, y] == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            throw new InvalidOperationException("It looks like the index is not in range");
        }
        public void PlacesFirstTwoCells()
        {
            int x = ChooseRandomIndex();
            int y = ChooseRandomIndex();
            int value = ChooseTwoOrFour();
            PlacesSpecificCell(x, y, value);
            x = ChooseRandomIndex();
            y = ChooseRandomIndex();
            value = ChooseTwoOrFour();
            bool isIndexEmpty = IsIndexEmpty(x, y);
            while(! isIndexEmpty)
            {
                x = ChooseRandomIndex();
                y = ChooseRandomIndex();
                isIndexEmpty = IsIndexEmpty(x, y);
            }
            PlacesSpecificCell(x, y, value);
        }

    }
}
