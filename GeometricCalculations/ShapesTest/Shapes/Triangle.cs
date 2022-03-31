using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricCalculations.Shapes;

namespace ShapesTest.Shapes {
	class Triangle: ITriangle {
		public double SideA { get; set; }
		public double SideB { get; set; }
		public double SideC { get; set; }

		public Triangle(double sideA, double sideB, double sideC) {
			SideA = sideA;
			SideB = sideB;
			SideC = sideC;
		}
	}
}
