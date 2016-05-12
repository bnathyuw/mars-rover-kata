namespace MarsRoverKata.Src
{
    class Rover
    {
        private int _x = 0;
        private int _y = 0;
        private char _direction = 'N';

        public string Move(string instructions = null)
        {
            if (instructions != null)
            {
                foreach (var instruction in instructions)
                {
                    if (instruction == 'M')
                        MoveForward();
                    if (instruction == 'L')
                        _direction = RotateLeft();
                    if (instruction == 'R')
                        _direction = RotateRight();
                }
            }

            return $"{_x}{_y}{_direction}";
        }

        private char RotateLeft()
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

        private char RotateRight()
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

        private void MoveForward()
        {
            _y += 1;
        }
    }
}
