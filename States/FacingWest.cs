using System;

namespace MarsRoverAssignment.States
{
	internal class FacingWest : IState
	{
		private readonly Motors _motor;
		public FacingWest(Motors motor)
		{
			_motor = motor;
		}

        public bool CheckBackward()
        {
			return _motor.CheckXForward();
        }

        public bool CheckForward()
        {
			return _motor.CheckXBackward();
		}

        public void Icon()
        {
            Console.Write('<');
        }

        public void MoveBackward()
		{
			_motor.MoveXForward();
		}

		public void MoveForward()
		{
			_motor.MoveYBackward();
		}

		public IState TurnLeft()
		{
			return new FacingSouth(_motor);
		}

		public IState TurnRight()
		{
			return new FacingNorth(_motor);
		}
        public override string ToString()
        {
            return "West";
        }
    }
}