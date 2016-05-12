namespace MarsRoverKata.Src
{
    class Direction
    {
        public static Direction Facing(char direction)
        {
            return new Direction(direction);
        }

        private readonly char _direction;

        private Direction(char direction)
        {
            _direction = direction;
        }

        public Direction RotateLeft()
        {
            if (_direction == 'N')
                return Facing('W');
            if (_direction == 'E')
                return Facing('N');
            if (_direction == 'S')
                return Facing('E');
            if (_direction == 'W')
                return Facing('S');

            return Facing(char.MinValue);
        }

        public Direction RotateRight()
        {
            if (_direction == 'N')
                return Facing('E');
            if (_direction == 'E')
                return Facing('S');
            if (_direction == 'S')
                return Facing('W');
            if (_direction == 'W')
                return Facing('N');

            return Facing(char.MinValue);
        }

        public override string ToString()
        {
            return $"{_direction}";
        }
    }
}