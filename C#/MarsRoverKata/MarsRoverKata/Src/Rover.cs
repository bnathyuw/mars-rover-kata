namespace MarsRoverKata.Src
{
    class Direction
    {
        private readonly char _direction;

        public Direction(char direction)
        {
            _direction = direction;
        }

        public Direction RotateLeft()
        {
            if (_direction == 'N')
                return new Direction('W');
            if (_direction == 'E')
                return new Direction('N');
            if (_direction == 'S')
                return new Direction('E');
            if (_direction == 'W')
                return new Direction('S');

            return new Direction(char.MinValue);
        }

        public Direction RotateRight()
        {
            if (_direction == 'N')
                return new Direction('E');
            if (_direction == 'E')
                return new Direction('S');
            if (_direction == 'S')
                return new Direction('W');
            if (_direction == 'W')
                return new Direction('N');

            return new Direction(char.MinValue);
        }

        public override string ToString()
        {
            return $"{_direction}";
        }
    }

    class Rover
    {
        private int _x = 0;
        private int _y = 0;
        private Direction _direction = new Direction('N');

        public string Move(string instructions = null)
        {
            if (instructions != null)
            {
                foreach (var instruction in instructions)
                {
                    if (instruction == 'M')
                        MoveForward();
                    if (instruction == 'L')
                        _direction = _direction.RotateLeft();
                    if (instruction == 'R')
                        _direction = _direction.RotateRight();
                }
            }

            return $"{_x}{_y}{_direction}";
        }

        private void MoveForward()
        {
            _y += 1;
        }
    }
}
