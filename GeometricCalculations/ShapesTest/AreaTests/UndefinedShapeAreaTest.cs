using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations;
using GeometricCalculations.Shapes;

namespace ShapesTest.AreaTests {
	[TestClass]
	public class UndefinedShapeTest {
		static double UndefinedShapeArea(IShape undefinedShape) {
			return undefinedShape.CalculateArea();
		}

		[TestMethod]
		public void CircleAsUndefinedShapeTest() {
			var circle = new Circle(2.0);
			var area = UndefinedShapeArea(circle);
			Assert.AreEqual(area, Math.PI * 4.0);
		}

		[TestMethod]
		public void TriangleAsUndefinedShapeTest() {
			var triangle = new Triangle(10.0, 8.0, 6.0);
			var area = UndefinedShapeArea(triangle);
			Assert.AreEqual(area, 24.0);
		}

		[TestMethod]
		public void SquareAsUndefinedShapeTest() {
			var square = new Square(42.0);
			var area = UndefinedShapeArea(square);
			Assert.AreEqual(area, 0.0);
		}
	}
}
