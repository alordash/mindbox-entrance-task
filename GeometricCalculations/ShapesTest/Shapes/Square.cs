using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricCalculations;

namespace ShapesTest.Shapes {
	class Square: IShape {
		public double Side;

		public Square(double side) {
			Side = side;
		}
	}
}
