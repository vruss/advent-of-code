using System;

namespace day_3
{
    public class Santa
    {
        private Position _position;

        public Position Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    _position.Y++;
                    break;
                case Direction.Left:
                    _position.X--;
                    break;
                case Direction.Right:
                    _position.X++;
                    break;
                case Direction.Down:
                    _position.Y--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }

            return _position;
        }

        public Position Position => _position;
    }
}