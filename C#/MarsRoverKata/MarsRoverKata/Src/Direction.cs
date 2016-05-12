using System;

namespace MarsRoverKata.Src
{
    abstract class Direction
    {
        public static Direction Facing(char direction)
        {
            if (direction == 'N') return new North();
            if (direction == 'E') return new East();
            if (direction == 'S') return new South();
            if (direction == 'W') return new West();
            throw new Exception("Unknown compass point");
        }

        protected readonly char _direction;

        private Direction(char direction)
        {
            _direction = direction;
        }

        public abstract Direction RotateLeft();

        public abstract Direction RotateRight();

        private class North : Direction
        {
            public North() : base('N')
            {
            }

            public override Direction RotateLeft()
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

            public override Direction RotateRight()
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

        private class East : Direction
        {
            public East() : base('E')
            {
            }

            public override Direction RotateLeft()
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

            public override Direction RotateRight()
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

        private class South : Direction
        {
            public South() : base('S')
            {
            }

            public override Direction RotateLeft()
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

            public override Direction RotateRight()
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

        private class West : Direction
        {
            public West() : base('W')
            {
            }

            public override Direction RotateLeft()
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

            public override Direction RotateRight()
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
}