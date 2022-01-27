using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment.States
{
	public interface IState
	{
		public bool CheckForward();
		public bool CheckBackward();
		public void MoveForward();
		public void MoveBackward();
		IState TurnLeft();
		IState TurnRight();
		public void Icon();
	}
}
