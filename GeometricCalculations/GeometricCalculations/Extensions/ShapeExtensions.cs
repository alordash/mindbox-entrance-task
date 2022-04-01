using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricCalculations.Shapes;

namespace GeometricCalculations {
	public static class ShapeExtensions {
		static double CalculateCircleArea(ICircle circle) {
			return Math.PI * Math.Pow(circle.Radius, 2.0);
		}

		static double CalculateTriangleArea(ITriangle triangle) {
			double semiPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2.0;
			return Math.Sqrt(
				(semiPerimeter - triangle.SideA) *
				(semiPerimeter - triangle.SideB) *
				(semiPerimeter - triangle.SideC) *
				semiPerimeter
			);
		}

		public static double CalculateArea(this IShape shape) {
			return shape switch {
				ICircle circle => CalculateCircleArea(circle),
				ITriangle triangle => CalculateTriangleArea(triangle),
				_ => throw new NotImplementedException()
			};
		}
	}
}
