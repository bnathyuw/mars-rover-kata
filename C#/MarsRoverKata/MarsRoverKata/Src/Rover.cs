namespace MarsRoverKata.Src
{
    class Direction
    {
        public char _direction;

        public Direction(char direction)
        {
            _direction = direction;
        }

        public char RotateLeft()
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

        public char RotateRight()
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
        private readonly Direction _direction = new Direction('N');

        public string Move(string instructions = null)
        {
            if (instructions != null)
            {
                foreach (var instruction in instructions)
                {
                    if (instruction == 'M')
                        MoveForward();
                    if (instruction == 'L')
                        _direction._direction = _direction.RotateLeft();
                    if (instruction == 'R')
                        _direction._direction = _direction.RotateRight();
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
