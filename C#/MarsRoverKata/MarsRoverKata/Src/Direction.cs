namespace MarsRoverKata.Src
{
    abstract class Direction
    {
        public static Direction Initial() => new North();

        private Direction()
        {
        }

        public abstract Direction RotateLeft();

        public abstract Direction RotateRight();

        private class North : Direction
        {
            public override Direction RotateLeft() => new West();

            public override Direction RotateRight() => new East();

            public override string ToString() => "N";
        }

        private class East : Direction
        {
            public override Direction RotateLeft() => new North();

            public override Direction RotateRight() => new South();

            public override string ToString() => "E";
        }

        private class South : Direction
        {
            public override Direction RotateLeft() => new East();

            public override Direction RotateRight() => new West();

            public override string ToString() => "S";
        }

        private class West : Direction
        {
            public override Direction RotateLeft() => new South();

            public override Direction RotateRight() => new North();

            public override string ToString() => "W";
        }
    }
}