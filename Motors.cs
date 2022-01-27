using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAssignment
{
	public class Motors 
	{
		private readonly char[,] _grid;
		public int XRover { get; set; }
		public int YRover { get; set; }
		
		public Motors( int xRover, int yRover, char[,] grid)
		{
			XRover = xRover;
			YRover = yRover;
			_grid = grid;
		}

		public void MoveYBackward()
		{
			if (YRover == 0)
				YRover = _grid.GetLength(0)-1;
			else
				YRover -= 1;
		}
		public void MoveYForward()
		{
			if (YRover == _grid.GetLength(0)-1)
				YRover = 0;
			else
				YRover += 1;
		}
		public void MoveXBackward()
		{
			if (XRover == 0)
				XRover = _grid.GetLength(1)-1;
			else
				XRover -= 1;
		}
		public void MoveXForward()
		{
			if (XRover == _grid.GetLength(0)-1)
				XRover = 0;
			else
				XRover += 1;
		}

		public bool CheckXForward()
		{
			if(XRover == _grid.GetLength(0)-1)
			{
				if (_grid[YRover, 0] == 'X')
				{
					Console.WriteLine($"Obstacle detected @ X:0 Y:{YRover} Relative Position: East");
					return true;
				}
				return false;
			}
			else if (_grid[YRover, XRover + 1] == 'X')
			{
				Console.WriteLine($"Obstacle detected @ X:{XRover + 1} Y:{YRover} Relative Position: East");
				return true;
			}
			return false;

		}

		public bool CheckXBackward()
		{
			if (XRover == 0 )
			{
				if(_grid[YRover, _grid.GetLength(1) - 1] == 'X')
                {
					Console.WriteLine($"Obstacle detected @ X:{ _grid.GetLength(1) - 1} Y:{YRover} Position: West");
					return true;
                }
				return false;
			}
			else if (_grid[YRover, XRover - 1] == 'X')
            {
				Console.WriteLine($"Obstacle detected @ X:{XRover - 1} Y:{YRover} Position: West");
				return true;

            }
			return false;
		}

		public bool CheckYForward()
		{
			if (YRover == _grid.GetLength(0) - 1)
			{
				if (_grid[0, XRover] == 'X')
				{
					Console.WriteLine($"Obstacle detected @ X:{XRover} Y:{0} Relative Position: South");
					return true;
				}
				return false;
			}
			else if (_grid[YRover + 1, XRover] == 'X')
            {
				Console.WriteLine($"Obstacle detected @ X:{XRover} Y:{YRover + 1} Relative Position: South");
				return true;
            }
			return false;

		}

		public bool CheckYBackward()
		{
			if (YRover == 0)
			{
				if (_grid[_grid.GetLength(0) - 1, XRover] == 'X')
				{
					Console.WriteLine($"Obstacle detected @ X:{XRover} Y:{_grid.GetLength(0) - 1} Relative Position: North");
					return true;
				}
				return false;
			}
			else if (_grid[YRover-1, XRover ] == 'X')
            {
				Console.WriteLine($"Obstacle detected @ X:{XRover} Y:{YRover - 1} Relative Position: North");
				return true;
            }
			return false;
		}

	}
}
