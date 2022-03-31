using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricCalculations.Shapes;

namespace ShapesTest.Shapes {
	public class Circle: ICircle {
		public double Radius { get; set; }

		public Circle(double radius) {
			Radius = radius;
		}
	}
}
