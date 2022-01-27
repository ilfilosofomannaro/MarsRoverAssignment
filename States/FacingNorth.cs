using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment.States
{
	public class FacingNorth : IState
	{
		private readonly Motors _motor;
		public FacingNorth(Motors motor)
		{
			_motor = motor;
		}
        public void Icon()
        {
            Console.Write('^'); ;
        }
        public bool CheckForward()
        {
			return _motor.CheckYBackward();
        }

        public bool CheckBackward()
        {
			return _motor.CheckYForward();
        }
		public IState TurnLeft()
		{
			return new FacingWest(_motor);
		}

		public IState TurnRight()
		{
			return new FacingEast(_motor);
		}
		public void MoveForward()
		{
				_motor.MoveYBackward();
		}
		public void MoveBackward()
		{
				_motor.MoveYForward();
		}


		public override string ToString()
        {
			return "North";
        }

    }
}
