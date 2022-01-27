using System;

namespace MarsRoverAssignment.States
{
	internal class FacingSouth : IState
	{
		private readonly Motors _motor;
		public FacingSouth(Motors motor)
		{
			_motor = motor;
		}

        public bool CheckBackward()
        {
			return _motor.CheckYBackward();
        }

        public bool CheckForward()
        {
			return _motor.CheckYForward();
		}

        public void Icon()
        {
            Console.Write('v'); ;
        }

        public void MoveBackward()
		{
			_motor.MoveYBackward();
		}

		public void MoveForward()
		{
			_motor.MoveYForward();
		}

		public IState TurnLeft()
		{
			return new FacingEast(_motor);
		}

		public IState TurnRight()
		{
			return new FacingWest(_motor);
		}
		public override string ToString()
		{
			return "South";
		}
	}
}