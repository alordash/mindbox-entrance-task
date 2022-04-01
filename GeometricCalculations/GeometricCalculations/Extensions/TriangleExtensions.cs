using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculations.Shapes {
	public static class TriangleExtensions {
		public static bool IsRight(this ITriangle triangle) {
			var sides = new double[] { triangle.SideA, triangle.SideB, triangle.SideC };
			sides = sides.OrderByDescending(x => x).ToArray();

			return Math.Pow(sides[0], 2.0) == Math.Pow(sides[1], 2.0) + Math.Pow(sides[2], 2.0);
		}
	}
}
