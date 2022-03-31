using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricCalculations;

namespace ShapesTest.Shapes {
	// Shape undefined in the library
	class Square: IShape {
		public double Side { get; set; }

		public Square(double side) {
			Side = side;
		}
	}
}
