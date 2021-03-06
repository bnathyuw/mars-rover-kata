﻿namespace MarsRoverKata.Src
{
    class Grid
    {
        private readonly int _maxWidth;
        private readonly int _maxHeight;

        public Grid(int maxWidth, int maxHeight)
        {
            this._maxWidth = maxWidth;
            this._maxHeight = maxHeight;
        }

        public GridPosition MoveNorth(GridPosition position) =>
            WrapAroundIfNecessary(position.X, position.Y + 1);

        public GridPosition MoveEast(GridPosition position) =>
            WrapAroundIfNecessary(position.X + 1, position.Y);

        public GridPosition MoveSouth(GridPosition position) =>
            WrapAroundIfNecessary(position.X, position.Y - 1);

        public GridPosition MoveWest(GridPosition position) =>
            WrapAroundIfNecessary(position.X - 1, position.Y);

        public GridPosition WrapAroundIfNecessary(int x, int y)
        {
            if (x == _maxWidth)
                x = 0;
            if (x == -1)
                x = _maxWidth - 1;
            if (y == _maxHeight)
                y = 0;
            if (y == -1)
                y = _maxHeight - 1;

            return new GridPosition(x, y);
        }
    }
}