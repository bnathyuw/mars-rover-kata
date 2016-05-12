using System;

namespace MarsRoverKata.Src
{
    abstract class Direction
    {
        public static Direction Initial()
        {
            return new North();
        }

        private Direction()
        {
        }

        public abstract Direction RotateLeft();

        public abstract Direction RotateRight();

        private class North : Direction
        {
            public override Direction RotateLeft()
            {
                return new West();
            }

            public override Direction RotateRight()
            {
                return new East();
            }

            public override string ToString()
            {
                return "N";
            }
        }

        private class East : Direction
        {
            public override Direction RotateLeft()
            {
                return new North();
            }

            public override Direction RotateRight()
            {
                return new South();
            }

            public override string ToString()
            {
                return "E";
            }
        }

        private class South : Direction
        {
            public override Direction RotateLeft()
            {
                return new East();
            }

            public override Direction RotateRight()
            {
                return new West();
            }

            public override string ToString()
            {
                return "S";
            }
        }

        private class West : Direction
        {
            public override Direction RotateLeft()
            {
                return new South();
            }

            public override Direction RotateRight()
            {
                return new North();
            }

            public override string ToString()
            {
                return "W";
            }
        }
    }
}