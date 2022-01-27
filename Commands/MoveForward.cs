using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment.Commands
{
    class MoveForward : ICommand
    {
        private readonly Rover _rover;
        public MoveForward(Rover rover)
        {
            _rover = rover;
        }
        public void Execute()
        {
            _rover.State.MoveForward();
        }
    }
}
