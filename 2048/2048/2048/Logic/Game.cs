
namespace _2048.Logic
{
    class Game
    {
        public Board GameBoard { get; set; }
        public GameStatus GameStatus { get; set; }
        public int Points { get; protected set; }
        public Game(Board board)
        {
            GameBoard = board;
            Points = 0;
        }
        public void UpdateStatus()
        {
            if(GameBoard.IsCell2048Exists())
            {
                GameStatus = GameStatus.Win;
            }
            else if(GameBoard.IsBoardFull())
            {
                GameStatus = GameStatus.Lose;
            }
            else
            {
                GameStatus = GameStatus.Idle;
            }
        }
        public void Move(Direction direction)
        {
            if(GameStatus != GameStatus.Lose)
            {
                GameBoard.Move(direction);
                UpdateStatus();
                Points += GameBoard.MovePoints;
            }
        }

    }
}
