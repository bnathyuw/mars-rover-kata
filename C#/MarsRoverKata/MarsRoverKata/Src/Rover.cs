namespace MarsRoverKata.Src
{
    class Direction
    {
        private readonly char _direction;

        public Direction(char direction)
        {
            _direction = direction;
        }

        public char Rl()
        {
            if(_direction == 'N')
                return 'W';
            if(_direction == 'E')
                return 'N';
            if(_direction == 'S')
                return 'E';
            if(_direction == 'W')
                return 'S';

            return char.MinValue;
        }

        public char Rr()
        {
            if (_direction == 'N')
                return 'E';
            if (_direction == 'E')
                return 'S';
            if (_direction == 'S')
                return 'W';
            if (_direction == 'W')
                return 'N';

            return char.MinValue;
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
                        _direction = RotateLeft(_direction);
                    if (instruction == 'R')
                        _direction = RotateRight(_direction);
                }
            }

            return $"{_x}{_y}{_direction}";
        }

        private static Direction RotateLeft(Direction direction)
        {
            return new Direction(direction.Rl());
        }

        private static Direction RotateRight(Direction direction)
        {
            return new Direction(direction.Rr());
        }

        private void MoveForward()
        {
            _y += 1;
        }
    }
}
