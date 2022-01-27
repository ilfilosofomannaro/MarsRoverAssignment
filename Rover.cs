using MarsRoverAssignment.Commands;
using MarsRoverAssignment.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
	//Rover è la classe context per State pattern.
	//Rover ha quattro stati diversi: Facing + punto cardinale (eg FacingNorth)
	public class Rover
	{
		public readonly Motors _motor;
		public IState State { get; set; }

		public Rover(Motors motor, IState state)
		{
			_motor = motor;
			State = state;
		}
	}
}
