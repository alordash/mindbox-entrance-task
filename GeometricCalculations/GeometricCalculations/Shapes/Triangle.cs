using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculations.Shapes {
	public class Triangle : IShape {
		double SideA;
		double SideB;
		double SideC;

		public Triangle(double sideA, double sideB, double sideC) {
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}

		public double CalculateArea() {
			double semiPerimeter = (SideA + SideB + SideC) / 2.0;
			return Math.Sqrt((semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC) * semiPerimeter);
		}

		public bool IsRight() {
			var squaredA = SideA * SideA;
			var squaredB = SideB * SideB;
			var squaredC = SideC * SideC;
			return squaredA == squaredB + squaredC
				|| squaredB == squaredC + squaredA
				|| squaredC == squaredA + squaredB;
		}

		public bool IsRight2() {
			var sides = new double[] { SideA, SideB, SideC };
			sides = sides.OrderByDescending(x => x).ToArray();
			return sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];
		}
	}
}
