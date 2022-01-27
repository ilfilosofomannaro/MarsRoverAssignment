using MarsRoverAssignment.States;
using System;

namespace MarsRoverAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			char[,] grid = new char[,] {	{ '.', '.', 'X','.' }, 
											{ '.', '.', '.' ,'X'}, 
											{ 'X', '.', '.','X' } };
			Motors motor = new Motors(1, 1, grid);
			FacingNorth state = new FacingNorth(motor);
			Rover perseverance = new Rover(motor, state);
			CommandModule commandModule = new CommandModule(perseverance);
			string commands = "";
			string functions = "";
			string menu = "";
			//ci sono sicuramente modi migliori per farlo, ma ho finito il tempo (sarebbe stato interessante studiare meglio questo
			//https://www.gamedeveloper.com/programming/procedurally-generating-wrapping-world-maps-in-unity-c-part-2)
			//manca anche un controllo che i comandi immessi siano accettabili.

			menu += "" +
				"\n1. Send commands to Perseverance" +
				"\n2. Deploy Ingenuity" +
				"\n3. Exit";

			Console.WriteLine($"Perseverance landed successfully! \nPerseverance actual position is X: {motor.XRover} Y: {motor.YRover} Facing: {perseverance.State.ToString()}");
			Console.WriteLine(menu);

			do
			{
				Console.WriteLine("Choose a function");
				functions = Console.ReadLine();
				switch (functions)
				{
					case "1":
						Console.WriteLine("Send commands to Perseverance");
						commands = Console.ReadLine().ToLower();
						commandModule.SetCommand(commands);
						break;
					case "2":
						Console.WriteLine("Map");
						for (int y = 0; y < grid.GetLength(0); y++)
						{
							for (int x = 0; x < grid.GetLength(1 ); x++)
							{
								if (motor.XRover == x && motor.YRover == y)
									perseverance.State.Icon();
								else
									Console.Write(grid[y, x]);
							}
							Console.Write("\n");
						}
						break;

				}
			} while (functions != "3");
		}	
	}
}
