using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum BoardComponents
    {
        FREE_SQUARE = 0,
        SNAKE_HEAD = 1,
        SNAKE_BODYPART = 2,
        FOOD = 3,
        WALL = 4
    }

    public enum Direction
    {
        NORTH = 0,
        SOUTH = 1,
        WEST = 2,
        EAST = 3
    }
}
