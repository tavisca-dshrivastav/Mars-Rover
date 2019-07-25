namespace MarsRover
{
    public class Rover
    {
        public Rover(Map map, Direction direction)
        {
            _map = map;
            _direction = direction;
        }
        private Map _map;
        private Direction _direction;

        public string ExecuteInstruction(string Instructions)
        {
            foreach(var command in Instructions)
            {
                if (command == 'L')
                    _direction.OnMoveLeft();
                if (command == 'R')
                    _direction.OnMoveRight();
                if (command == 'F')
                    _direction.OnMoveForward(_map);
            }
            return $"{_map.CurrentPosition.XCordinate} {_map.CurrentPosition.YCordinate} {_direction.CurrentDirection}";
        }
    }
}
