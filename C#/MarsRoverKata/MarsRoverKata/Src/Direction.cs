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
                return Facing('W');
            }

            public override Direction RotateRight()
            {
                return Facing('E');
            }

            public override string ToString()
            {
                return "N";
            }
        }

        private class East : Direction
        {
            public East() : base('E')
            {
            }

            public override Direction RotateLeft()
            {
                return Facing('N');
            }

            public override Direction RotateRight()
            {
                return Facing('S');
            }

            public override string ToString()
            {
                return "E";
            }
        }

        private class South : Direction
        {
            public South() : base('S')
            {
            }

            public override Direction RotateLeft()
            {
                return Facing('E');
            }

            public override Direction RotateRight()
            {
                return Facing('W');
            }

            public override string ToString()
            {
                return "S";
            }
        }

        private class West : Direction
        {
            public West() : base('W')
            {
            }

            public override Direction RotateLeft()
            {
                return Facing('S');
            }

            public override Direction RotateRight()
            {
                return Facing('N');
            }

            public override string ToString()
            {
                return "W";
            }
        }
    }
}