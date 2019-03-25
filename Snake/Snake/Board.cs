using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;

namespace Snake
{
    public class Board
    {
        const int BOARD_HEIGHT = 32;
        const int BOARD_WIDTH = 32;
        const int TEXTURE_HEIGHT = 15;
        const int TEXTURE_WIDTH = 15;

        Random rand = new Random();

        bool hasWon = false;
        Direction heading;
        BoardComponents[,] map = new BoardComponents[BOARD_WIDTH, BOARD_HEIGHT];
        int remainingFood;
        List<Point> snakeTrace = new List<Point>();

        public bool HasWon { get => hasWon; set => hasWon = value; }
        public int RemainingFood { get => remainingFood; }

        public Board(Point snakeStartingPosition, Direction snakeStartingDirection, int amountOfFoodToWin, BoardComponents[,] levelMap)
        {
            map = levelMap;
            map[snakeStartingPosition.X, snakeStartingPosition.Y] = BoardComponents.SNAKE_HEAD;
            snakeTrace.Add(snakeStartingPosition);
            heading = snakeStartingDirection;
            remainingFood = amountOfFoodToWin;
            spawnFood();
        }

        private bool isEating()
        {
            Point snakeHead = snakeTrace[0];
            return map[snakeHead.X, snakeHead.Y] == BoardComponents.FOOD;
        }

        private bool isGameOver()
        {
            if (RemainingFood == 0)
            {
                hasWon = true;
                return true;
            }
            Point snakeHead = snakeTrace[0];
            if (snakeHead.X < 0 ||
                snakeHead.X >= BOARD_WIDTH ||
                snakeHead.Y < 0 ||
                snakeHead.Y >= BOARD_HEIGHT)
                return true;
            if (map[snakeHead.X, snakeHead.Y] != BoardComponents.FREE_SQUARE &&
                map[snakeHead.X, snakeHead.Y] != BoardComponents.FOOD)
                return true;
            for (int npos = 1; npos < snakeTrace.Count; ++npos)
                if (snakeTrace[npos] == snakeHead)
                    return true;
            return false;
        }

        private void spawnFood()
        {
            List<Point> availableSquares = new List<Point>();
            for (int row = 0; row < BOARD_WIDTH; ++row)
                for (int col = 0; col < BOARD_HEIGHT; ++col)
                    if (map[row, col] == BoardComponents.FREE_SQUARE)
                        availableSquares.Add(new Point(row, col));
            foreach (Point point in snakeTrace)
                if (availableSquares.Contains(point))
                    availableSquares.Remove(point);
            Point food = availableSquares[rand.Next(0, availableSquares.Count - 1)];
            map[food.X, food.Y] = BoardComponents.FOOD;
        }

        public void changeSnakeDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.NORTH: if (heading != Direction.SOUTH) heading = Direction.NORTH; break;
                case Direction.SOUTH: if (heading != Direction.NORTH) heading = Direction.SOUTH; break;
                case Direction.WEST: if (heading != Direction.EAST) heading = Direction.WEST; break;
                case Direction.EAST: if (heading != Direction.WEST) heading = Direction.EAST; break;
            }
        }

        public void drawBoardOnGraphics(Graphics graphics)
        {
            Brush brush = new SolidBrush(Settings.Instance.BoardColor);
            graphics.FillRegion(brush, graphics.Clip);
            for (int row = 0; row < BOARD_HEIGHT; ++row)
                for (int col = 0; col < BOARD_WIDTH; ++col)
                {
                    switch (map[row, col])
                    {
                        case BoardComponents.FOOD: brush = new SolidBrush(Settings.Instance.FoodColor); break;
                        case BoardComponents.SNAKE_BODYPART: brush = new SolidBrush(Settings.Instance.BodyColor); break;
                        case BoardComponents.SNAKE_HEAD: brush = new SolidBrush(Settings.Instance.HeadColor); break;
                        case BoardComponents.WALL: brush = new SolidBrush(Settings.Instance.WallColor); break;
                        default: brush = new SolidBrush(Settings.Instance.BoardColor); break;
                    }
                    graphics.FillRectangle(brush,
                        row * TEXTURE_HEIGHT + 1, col * TEXTURE_WIDTH + 1,
                        TEXTURE_WIDTH - 1, TEXTURE_HEIGHT - 1);
                }
        }

        public bool isGameOverBySnakeAdvancing()
        {
            Point newSnakeHead = new Point();
            Point snakeHead = snakeTrace[0];
            switch (heading)
            {
                case Direction.NORTH: newSnakeHead = new Point(snakeHead.X, snakeHead.Y - 1); break;
                case Direction.SOUTH: newSnakeHead = new Point(snakeHead.X, snakeHead.Y + 1); break;
                case Direction.WEST: newSnakeHead = new Point(snakeHead.X - 1, snakeHead.Y); break;
                case Direction.EAST: newSnakeHead = new Point(snakeHead.X + 1, snakeHead.Y); break;
            }
            snakeTrace.Insert(0, newSnakeHead);
            if (!isGameOver())
            {
                map[snakeHead.X, snakeHead.Y] = BoardComponents.SNAKE_BODYPART;
                if (!isEating())
                {
                    Point lastBodypart = snakeTrace[snakeTrace.Count - 1];
                    map[lastBodypart.X, lastBodypart.Y] = BoardComponents.FREE_SQUARE;
                    snakeTrace.Remove(lastBodypart);
                }
                else
                {
                    if (Settings.Instance.IsSoundsOn)
                    {
                        SoundPlayer eatSound = new SoundPlayer(Properties.Resources.eat);
                        eatSound.Play();
                    }
                    remainingFood--;
                    spawnFood();
                }
                map[newSnakeHead.X, newSnakeHead.Y] = BoardComponents.SNAKE_HEAD;
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
