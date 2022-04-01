using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShapesTest.Shapes;
using GeometricCalculations;
using GeometricCalculations.Shapes;

namespace ShapesTest.AreaTests {
	[TestClass]
	public class UndefinedShapeAreaTest {
		[TestMethod]
		public void Circle_As_IShape_Area_Equal_To_16Pi() {
			var circle = (IShape)new Circle(4.0);
			Assert.AreEqual(circle.CalculateArea(), 16.0 * Math.PI);
		}

		[TestMethod]
		public void Triangle_As_IShape_Area_Equal_To_Some_Value() {
			var triangle = (IShape)new Triangle(6.0, 100.0, 95.0);
			Assert.AreEqual(triangle.CalculateArea(), 161.6089029106998, 0.001);
		}

		[TestMethod]
		[ExpectedException(typeof(NotImplementedException))]
		public void Square_Area_Is_Not_Implemented() {
			var square = new Square(10.0);
			Assert.AreEqual(square.CalculateArea(), 100.0);
		}
	}
}
