﻿using System;


namespace _2048.Logic
{
    class Board
    {
        public int[,] Data { get; protected set; }
        public Board()
        {   
            Data = new int[4, 4];
        }
        public void PlacesSpecificCell(int x, int y, int value)
        {
            Data[x, y] = value;
        }
        public int ChooseTwoOrFour()
        {
            Random rnd = new Random();
            int zeroOrOne = rnd.Next(0, 2);
            if (zeroOrOne == 0)
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
                    if (i == x && j == y)
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
            while (!isIndexEmpty)
            {
                x = ChooseRandomIndex();
                y = ChooseRandomIndex();
                isIndexEmpty = IsIndexEmpty(x, y);
            }
            PlacesSpecificCell(x, y, value);
        }
        public void MoveNotZerosUp()
        {

            for (int x = 0; x < Data.GetLength(0); x++)
            {
                for (int y = 0; y < Data.GetLength(1); y++)
                {
                    if (y == 0)
                    {
                        continue;
                    }
                    else
                    {
                        int i = x;
                        int j = y;
                        while ((j - 1) >= 0 && Data[i, j - 1] == 0)
                        {
                            Data[i, j - 1] = Data[i, j];
                            Data[i, j] = 0;
                            j--;
                        }
                    }
                }
            }
        }
        public void MergeDuplicatesUp()
        {
            for (int x = 0; x < Data.GetLength(0); x++)
            {
                for (int y = 0; y < Data.GetLength(1); y++)
                {
                    if (y - 1 >= 0 && Data[x, y - 1] == Data[x, y])
                    {
                        Data[x, y - 1] = Data[x, y] * 2;
                        Data[x, y] = 0;
                    }
                }
            }
        }
        public void MoveUp()
        {
            MoveNotZerosUp();
            MergeDuplicatesUp();
            MoveNotZerosUp();

        }
        public void MoveNotZerosDown()
        {

            for (int x = 0; x < Data.GetLength(0); x++)
            {
                for (int y = Data.GetLength(1) - 1; y >= 0; y--)
                {
                    if (y == Data.GetLength(1) - 1)
                    {
                        continue;
                    }
                    else
                    {
                        int i = x;
                        int j = y;
                        while ((j + 1) <= Data.GetLength(1) - 1 && Data[i, j + 1] == 0)
                        {
                            Data[i, j + 1] = Data[i, j];
                            Data[i, j] = 0;
                            j++;
                        }
                    }
                }
            }

        }
        public void MergeDuplicatesDown()
        {
            for (int x = 0; x < Data.GetLength(0); x++)
            {
                for (int y = Data.GetLength(1) - 1; y >= 0; y--)
                {
                    if (y + 1 <= Data.GetLength(1) - 1 && Data[x, y + 1] == Data[x, y])
                    {
                        Data[x, y + 1] = Data[x, y] * 2;
                        Data[x, y] = 0;
                    }
                }
            }
        }
        public void MoveDown()
        {
            MoveNotZerosDown();
            MergeDuplicatesDown();
            MoveNotZerosDown();
        }
        public void MoveNotZerosLeft()
        {

            for (int y = 0; y < Data.GetLength(1); y++)
            {
                for (int x = 0; x < Data.GetLength(0); x++)
                {
                    if (x == 0)
                    {
                        continue;
                    }
                    else
                    {
                        int i = y;
                        int j = x;
                        while ((j - 1) >= 0 && Data[j - 1, i] == 0)
                        {
                            Data[j - 1,i] = Data[j,i];
                            Data[j,i] = 0;
                            j--;
                        }
                    }
                }
            }
        }
        public void MergeDuplicatesLeft()
        {
            for (int y = 0; y < Data.GetLength(1); y++)
            {
                for (int x = 0; x < Data.GetLength(0); x++)
                {
                    if (x - 1 >= 0 && Data[x - 1, y] == Data[x, y])
                    {
                        Data[x -1, y] = Data[x, y] * 2;
                        Data[x, y] = 0;
                    }
                }
            }
        }
        public void MoveLeft()
        {
            MoveNotZerosLeft();
            MergeDuplicatesLeft();
            MoveNotZerosLeft();

        }
        public void MoveByDirection(Direction direction)
        {
            if (direction == Direction.Up)
            {
                MoveUp();
            }
            else if (direction == Direction.Down)
            {
                MoveDown();
            }
            else if (direction == Direction.Left)
            {
                MoveLeft();
            }
            else if (direction == Direction.Left)
            {
                //MoveLeft();
            }

        }

    }
}
