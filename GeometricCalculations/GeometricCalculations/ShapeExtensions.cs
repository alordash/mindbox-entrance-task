using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricCalculations.Shapes;

namespace GeometricCalculations {
	public static class ShapeExtensions {
		public static double CalculateArea(this ICircle circle) {
			return Math.PI * Math.Pow(circle.Radius, 2.0);
		}

		public static double CalculateArea(this ITriangle triangle) {
			double semiPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2.0;
			return Math.Sqrt(
				(semiPerimeter - triangle.SideA) *
				(semiPerimeter - triangle.SideB) *
				(semiPerimeter - triangle.SideC) *
				semiPerimeter
			);
		}
	}
}
