using MarsRoverAssignment.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
	//invoker per il command pattern
	public class CommandModule
	{
		private readonly Rover _rover;
		private readonly Dictionary<char, ICommand> _availableCommands;
		public CommandModule(Rover rover)
        {
			_rover = rover;
			_availableCommands = new Dictionary<char, ICommand>
			{
				{'f', new MoveForward(_rover) },
				{'b', new MoveBackward(_rover) },
				{'r', new TurnRight(_rover) },
				{'l', new TurnLeft(_rover)}
			};
        }

		public void SetCommand(string commands)
        {
			foreach(char command in commands.ToLower())
            {
				if (command == 'f' && _rover.State.CheckForward())
					break;
				else if (command == 'b' && _rover.State.CheckBackward())
					break;
				else
					_availableCommands[command].Execute();
            }
			Console.WriteLine($"Perseverance stopped @ X:{_rover._motor.XRover} Y:{_rover._motor.YRover} Facing: {_rover.State.ToString()}");
        }
	}
}
