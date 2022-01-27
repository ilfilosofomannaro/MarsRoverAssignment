using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment.Commands
{
    class TurnRight : ICommand
    {
        private readonly Rover _rover;
        public TurnRight(Rover rover)
        {
            _rover = rover;
        }
        public void Execute()
        {
            _rover.State = _rover.State.TurnRight();
        }
    }
}
