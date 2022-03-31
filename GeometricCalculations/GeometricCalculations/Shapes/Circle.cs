using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculations.Shapes {
	public class Circle: IShape {
		public double Radius;

		public Circle(double radius) {
			Radius = radius;
		}

		public double CalculateArea() {
			return Math.PI * Radius * Radius;
		}
	}
}
