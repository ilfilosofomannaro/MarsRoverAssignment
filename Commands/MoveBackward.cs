using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment.Commands
{
    class MoveBackward : ICommand
    {
        private readonly Rover _rover;
        public MoveBackward(Rover rover)
        {
            _rover = rover;
        }
        public void Execute()
        {
            _rover.State.MoveBackward();
        }
    }
}
