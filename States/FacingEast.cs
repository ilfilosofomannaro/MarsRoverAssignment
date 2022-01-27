using System;

namespace MarsRoverAssignment.States
{
	internal class FacingEast : IState
	{
		private readonly Motors _motor;
		public FacingEast(Motors motor)
		{
			_motor = motor;
		}

        public void Icon()
        {
            Console.Write('>'); ;
        }
        public bool CheckBackward()
        {
            return _motor.CheckXBackward();
        }

        public bool CheckForward()
        {
			return _motor.CheckXForward();
		}


        public void MoveBackward()
		{
				_motor.MoveXBackward();
		}

		public void MoveForward()
		{
				_motor.MoveXForward();
		}

		public IState TurnRight()
		{
			return new FacingSouth(_motor);
		}

		public IState TurnLeft()
		{
			return new FacingNorth(_motor);
		}

        public override string ToString()
        {
            return "East";
        }
    }
}